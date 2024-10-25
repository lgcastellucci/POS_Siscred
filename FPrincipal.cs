using Newtonsoft.Json.Linq;
using POS_Siscred.Controllers;

namespace POS_Siscred
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
            gbConfiguracoes.Visible = false;

            LoadConfiguration();
        }

        private void LoadConfiguration()
        {
            try
            {
                string jsonVazio = "{}";
                var config = JObject.Parse(jsonVazio);
                try
                {
                    var configText = File.ReadAllText("config.json");
                    config = JObject.Parse(configText);
                }
                catch
                {
                    return;
                }

                // Iterar sobre todas as propriedades do JSON
                foreach (var property in config.Properties())
                {
                    // Obter o nome da propriedade
                    string componentName = property.Name;
                    var value = property.Value;

                    // Encontrar o componente correspondente no formulário
                    var controls = Controls.Find(componentName, true);
                    if (controls.Length > 0)
                    {
                        var control = controls[0];

                        // Atualizar o valor do componente
                        if (control is TextBox textBox)
                            textBox.Text = value.ToString();
                        else if (control is MaskedTextBox maskedTextBox)
                            maskedTextBox.Text = value.ToString();
                        else if (control is CheckBox checkBox)
                            checkBox.Checked = value.ToObject<bool>();
                        // Adicione mais tipos de componentes conforme necessário
                    }
                }

            }
            catch (FileNotFoundException)
            {
                // Arquivo de configuração não encontrado, usar valor padrão ou lançar exceção
                tbHostApi.Text = "http://defaultapi.com";
            }
            catch (Exception ex)
            {
                // Tratar outras exceções
                Console.WriteLine($"Erro ao carregar configuração: {ex.Message}");
            }

        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            gbConfiguracoes.Visible = !gbConfiguracoes.Visible;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            lbStatus.Text = "";
            tbNsuHost.Text = "";

            if (string.IsNullOrEmpty(tbHostApi.Text))
            {
                lbStatus.Text = "Url precisa ser preenchida";
                return;
            }
            if (string.IsNullOrEmpty(tbChaveIntegrador.Text))
            {
                lbStatus.Text = "Chave Integrador precisa ser preenchido";
                return;
            }
            if (string.IsNullOrEmpty(tbIdEstabelecimento.Text))
            {
                lbStatus.Text = "ID do estabelecimento precisa ser preenchido";
                return;
            }

            if (string.IsNullOrWhiteSpace(tbToken.Text))
            {
                lbStatus.Text = "Buscando token ...";

                var buscarToken = new BuscarToken(tbHostApi.Text);
                var retBuscarToken = buscarToken.Execute(tbChaveIntegrador.Text);
                if (!retBuscarToken.Sucesso)
                {
                    lbStatus.Text = "Erro ao buscar token";
                    return;
                }
                tbToken.Text = retBuscarToken.Token;
            }


            tbNumeroCartao.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string tmpCartao = tbNumeroCartao.Text.Trim();
            tbNumeroCartao.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;

            string tmpvalor = tbValor.Text.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");

            bool lConfirmarAgora = true;
            if (cbConfirmarAgora.Text == "Não")
                lConfirmarAgora = false;

            if (string.IsNullOrEmpty(tbToken.Text))
            {
                lbStatus.Text = "Token precisa ser preenchido";
                return;
            }
            if (string.IsNullOrEmpty(tbNsuGuest.Text))
            {
                lbStatus.Text = "NsuGuest precisa ser preenchido";
                return;
            }
            if (string.IsNullOrEmpty(tmpCartao))
            {
                lbStatus.Text = "Cartão precisa ser preenchido";
                return;
            }
            try
            {
                double tmpVlr = Convert.ToDouble(tmpvalor);
                if (tmpVlr == 0)
                {
                    lbStatus.Text = "Valor precisa ser preenchido";
                    return;
                }
            }
            catch
            {
                lbStatus.Text = "Valor precisa ser preenchido";
                return;
            }

            lbStatus.Text = "Efetuando venda ...";

            var efetuarVenda = new EfetuarVenda(tbHostApi.Text);
            var retEfetuarVenda = efetuarVenda.Execute(tbToken.Text, tbIdEstabelecimento.Text, tbNsuGuest.Text, tmpCartao, tbCartaoValidade.Text, tbCartaoCvv.Text, tmpvalor, lConfirmarAgora);
            if (retEfetuarVenda.response_code != "00")
            {
                lbStatus.Text = retEfetuarVenda.response_message;
                return;
            }

            tbNsuHost.Text = retEfetuarVenda.authorization;
            try
            {
                int seqNsuGuest = Convert.ToInt32(tbNsuGuest.Text) + 1;
                tbNsuGuest.Text = seqNsuGuest.ToString().PadLeft(6, '0');
                //config.NsuGuest = tbNsuGuest.Text;
            }
            catch
            { }

            lbStatus.Text = retEfetuarVenda.response_message;

        }

        private void tbValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox textBox)
            {

                if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
                {
                    if (e.KeyChar == ',')
                    {
                        e.Handled = (textBox.Text.Contains(","));
                    }
                    else
                        e.Handled = true;
                }
            }
        }

        private void tbValor_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string valor = textBox.Text.Replace("R$", "");
                textBox.Text = string.Format("{0:C}", Convert.ToDouble(valor));
            }
        }

        private void tbValor_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                string valor = textBox.Text.Replace("R$", "").Replace(",", "").Replace(" ", "").Replace("00,", "");
                if (valor.Length == 0)
                {
                    textBox.Text = "0,00" + valor;
                }
                if (valor.Length == 1)
                {
                    textBox.Text = "0,0" + valor;
                }
                if (valor.Length == 2)
                {
                    textBox.Text = "0," + valor;
                }
                else if (valor.Length >= 3)
                {
                    if (textBox.Text.StartsWith("0,"))
                    {
                        textBox.Text = valor.Insert(valor.Length - 2, ",").Replace("0,", "");
                    }
                    else if (textBox.Text.Contains("00,"))
                    {
                        textBox.Text = valor.Insert(valor.Length - 2, ",").Replace("00,", "");
                    }
                    else
                    {
                        textBox.Text = valor.Insert(valor.Length - 2, ",");
                    }
                }
                valor = textBox.Text;
                textBox.Text = string.Format("{0:C}", Convert.ToDouble(valor));
                textBox.Select(textBox.Text.Length, 0);
            }
        }


        private void btnFinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}

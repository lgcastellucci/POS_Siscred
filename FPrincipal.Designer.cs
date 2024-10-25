namespace POS_Siscred
{
    partial class FPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConfigurar = new Button();
            gbConfiguracoes = new GroupBox();
            lbIdEstabelecimento = new Label();
            tbIdEstabelecimento = new TextBox();
            lbToken = new Label();
            tbToken = new TextBox();
            lbChaveIntegrador = new Label();
            lbHostApi = new Label();
            tbChaveIntegrador = new TextBox();
            tbHostApi = new TextBox();
            gbVender = new GroupBox();
            lbAcaoFinalizar = new Label();
            cbAcaoFinalizar = new ComboBox();
            tbValorConfirmacao = new TextBox();
            lbValorConfirmacao = new Label();
            btnFinalizar = new Button();
            lbConfirmarAgora = new Label();
            cbConfirmarAgora = new ComboBox();
            lbCartaoCvv = new Label();
            tbCartaoCvv = new TextBox();
            lbCartaoValidade = new Label();
            tbCartaoValidade = new TextBox();
            tbValor = new TextBox();
            tbNumeroCartao = new MaskedTextBox();
            lbNsuHost = new Label();
            tbNsuHost = new TextBox();
            lbValor = new Label();
            lbNsuGuest = new Label();
            lbNumeroCartao = new Label();
            tbNsuGuest = new TextBox();
            btnVender = new Button();
            lbStatus = new Label();
            gbConfiguracoes.SuspendLayout();
            gbVender.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfigurar
            // 
            btnConfigurar.Location = new Point(713, 12);
            btnConfigurar.Name = "btnConfigurar";
            btnConfigurar.Size = new Size(75, 23);
            btnConfigurar.TabIndex = 0;
            btnConfigurar.Text = "Configurar";
            btnConfigurar.UseVisualStyleBackColor = true;
            btnConfigurar.Click += btnConfigurar_Click;
            // 
            // gbConfiguracoes
            // 
            gbConfiguracoes.BackColor = SystemColors.Control;
            gbConfiguracoes.Controls.Add(lbIdEstabelecimento);
            gbConfiguracoes.Controls.Add(tbIdEstabelecimento);
            gbConfiguracoes.Controls.Add(lbToken);
            gbConfiguracoes.Controls.Add(tbToken);
            gbConfiguracoes.Controls.Add(lbChaveIntegrador);
            gbConfiguracoes.Controls.Add(lbHostApi);
            gbConfiguracoes.Controls.Add(tbChaveIntegrador);
            gbConfiguracoes.Controls.Add(tbHostApi);
            gbConfiguracoes.Location = new Point(12, 12);
            gbConfiguracoes.Name = "gbConfiguracoes";
            gbConfiguracoes.Size = new Size(695, 71);
            gbConfiguracoes.TabIndex = 1;
            gbConfiguracoes.TabStop = false;
            gbConfiguracoes.Text = "Configuracoes";
            // 
            // lbIdEstabelecimento
            // 
            lbIdEstabelecimento.AutoSize = true;
            lbIdEstabelecimento.Location = new Point(325, 19);
            lbIdEstabelecimento.Name = "lbIdEstabelecimento";
            lbIdEstabelecimento.Size = new Size(104, 15);
            lbIdEstabelecimento.TabIndex = 7;
            lbIdEstabelecimento.Text = "IdEstabelecimento";
            // 
            // tbIdEstabelecimento
            // 
            tbIdEstabelecimento.Location = new Point(325, 37);
            tbIdEstabelecimento.Name = "tbIdEstabelecimento";
            tbIdEstabelecimento.Size = new Size(171, 23);
            tbIdEstabelecimento.TabIndex = 6;
            // 
            // lbToken
            // 
            lbToken.AutoSize = true;
            lbToken.Location = new Point(502, 19);
            lbToken.Name = "lbToken";
            lbToken.Size = new Size(38, 15);
            lbToken.TabIndex = 5;
            lbToken.Text = "Token";
            // 
            // tbToken
            // 
            tbToken.Location = new Point(502, 37);
            tbToken.Name = "tbToken";
            tbToken.Size = new Size(187, 23);
            tbToken.TabIndex = 4;
            // 
            // lbChaveIntegrador
            // 
            lbChaveIntegrador.AutoSize = true;
            lbChaveIntegrador.Location = new Point(224, 19);
            lbChaveIntegrador.Name = "lbChaveIntegrador";
            lbChaveIntegrador.Size = new Size(95, 15);
            lbChaveIntegrador.TabIndex = 3;
            lbChaveIntegrador.Text = "ChaveIntegrador";
            // 
            // lbHostApi
            // 
            lbHostApi.AutoSize = true;
            lbHostApi.Location = new Point(17, 19);
            lbHostApi.Name = "lbHostApi";
            lbHostApi.Size = new Size(50, 15);
            lbHostApi.TabIndex = 2;
            lbHostApi.Text = "HostApi";
            // 
            // tbChaveIntegrador
            // 
            tbChaveIntegrador.Location = new Point(224, 37);
            tbChaveIntegrador.Name = "tbChaveIntegrador";
            tbChaveIntegrador.Size = new Size(95, 23);
            tbChaveIntegrador.TabIndex = 1;
            // 
            // tbHostApi
            // 
            tbHostApi.Location = new Point(17, 37);
            tbHostApi.Name = "tbHostApi";
            tbHostApi.Size = new Size(201, 23);
            tbHostApi.TabIndex = 0;
            // 
            // gbVender
            // 
            gbVender.Controls.Add(lbAcaoFinalizar);
            gbVender.Controls.Add(cbAcaoFinalizar);
            gbVender.Controls.Add(tbValorConfirmacao);
            gbVender.Controls.Add(lbValorConfirmacao);
            gbVender.Controls.Add(btnFinalizar);
            gbVender.Controls.Add(lbConfirmarAgora);
            gbVender.Controls.Add(cbConfirmarAgora);
            gbVender.Controls.Add(lbCartaoCvv);
            gbVender.Controls.Add(tbCartaoCvv);
            gbVender.Controls.Add(lbCartaoValidade);
            gbVender.Controls.Add(tbCartaoValidade);
            gbVender.Controls.Add(tbValor);
            gbVender.Controls.Add(tbNumeroCartao);
            gbVender.Controls.Add(lbNsuHost);
            gbVender.Controls.Add(tbNsuHost);
            gbVender.Controls.Add(lbValor);
            gbVender.Controls.Add(lbNsuGuest);
            gbVender.Controls.Add(lbNumeroCartao);
            gbVender.Controls.Add(tbNsuGuest);
            gbVender.Controls.Add(btnVender);
            gbVender.Location = new Point(12, 89);
            gbVender.Name = "gbVender";
            gbVender.Size = new Size(776, 301);
            gbVender.TabIndex = 2;
            gbVender.TabStop = false;
            // 
            // lbAcaoFinalizar
            // 
            lbAcaoFinalizar.AutoSize = true;
            lbAcaoFinalizar.Location = new Point(278, 151);
            lbAcaoFinalizar.Name = "lbAcaoFinalizar";
            lbAcaoFinalizar.Size = new Size(34, 15);
            lbAcaoFinalizar.TabIndex = 24;
            lbAcaoFinalizar.Text = "Acao";
            // 
            // cbAcaoFinalizar
            // 
            cbAcaoFinalizar.FormattingEnabled = true;
            cbAcaoFinalizar.Items.AddRange(new object[] { "Confirmar", "Desfazer" });
            cbAcaoFinalizar.Location = new Point(278, 169);
            cbAcaoFinalizar.Name = "cbAcaoFinalizar";
            cbAcaoFinalizar.Size = new Size(96, 23);
            cbAcaoFinalizar.TabIndex = 23;
            cbAcaoFinalizar.Tag = "";
            cbAcaoFinalizar.Text = "Confirmar";
            // 
            // tbValorConfirmacao
            // 
            tbValorConfirmacao.Location = new Point(149, 172);
            tbValorConfirmacao.Name = "tbValorConfirmacao";
            tbValorConfirmacao.Size = new Size(109, 23);
            tbValorConfirmacao.TabIndex = 22;
            tbValorConfirmacao.KeyPress += tbValor_KeyPress;
            tbValorConfirmacao.KeyUp += tbValor_KeyUp;
            tbValorConfirmacao.Leave += tbValor_Leave;
            // 
            // lbValorConfirmacao
            // 
            lbValorConfirmacao.AutoSize = true;
            lbValorConfirmacao.Location = new Point(149, 154);
            lbValorConfirmacao.Name = "lbValorConfirmacao";
            lbValorConfirmacao.Size = new Size(105, 15);
            lbValorConfirmacao.TabIndex = 21;
            lbValorConfirmacao.Text = "Valor Confirmacao";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(431, 164);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(109, 31);
            btnFinalizar.TabIndex = 20;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // lbConfirmarAgora
            // 
            lbConfirmarAgora.AutoSize = true;
            lbConfirmarAgora.Location = new Point(278, 78);
            lbConfirmarAgora.Name = "lbConfirmarAgora";
            lbConfirmarAgora.Size = new Size(96, 15);
            lbConfirmarAgora.TabIndex = 19;
            lbConfirmarAgora.Text = "Confirmar Agora";
            // 
            // cbConfirmarAgora
            // 
            cbConfirmarAgora.FormattingEnabled = true;
            cbConfirmarAgora.Items.AddRange(new object[] { "Sim", "Não" });
            cbConfirmarAgora.Location = new Point(278, 96);
            cbConfirmarAgora.Name = "cbConfirmarAgora";
            cbConfirmarAgora.Size = new Size(96, 23);
            cbConfirmarAgora.TabIndex = 18;
            cbConfirmarAgora.Tag = "";
            cbConfirmarAgora.Text = "Sim";
            // 
            // lbCartaoCvv
            // 
            lbCartaoCvv.AutoSize = true;
            lbCartaoCvv.Location = new Point(303, 25);
            lbCartaoCvv.Name = "lbCartaoCvv";
            lbCartaoCvv.Size = new Size(29, 15);
            lbCartaoCvv.TabIndex = 17;
            lbCartaoCvv.Text = "CVV";
            // 
            // tbCartaoCvv
            // 
            tbCartaoCvv.Location = new Point(303, 43);
            tbCartaoCvv.Name = "tbCartaoCvv";
            tbCartaoCvv.Size = new Size(109, 23);
            tbCartaoCvv.TabIndex = 16;
            // 
            // lbCartaoValidade
            // 
            lbCartaoValidade.AutoSize = true;
            lbCartaoValidade.Location = new Point(188, 25);
            lbCartaoValidade.Name = "lbCartaoValidade";
            lbCartaoValidade.Size = new Size(89, 15);
            lbCartaoValidade.TabIndex = 15;
            lbCartaoValidade.Text = "Cartao Validade";
            // 
            // tbCartaoValidade
            // 
            tbCartaoValidade.Location = new Point(188, 43);
            tbCartaoValidade.Name = "tbCartaoValidade";
            tbCartaoValidade.Size = new Size(109, 23);
            tbCartaoValidade.TabIndex = 14;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(149, 96);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(109, 23);
            tbValor.TabIndex = 13;
            tbValor.KeyPress += tbValor_KeyPress;
            tbValor.KeyUp += tbValor_KeyUp;
            tbValor.Leave += tbValor_Leave;
            // 
            // tbNumeroCartao
            // 
            tbNumeroCartao.Location = new Point(17, 43);
            tbNumeroCartao.Mask = "0000 0000 0000 0000";
            tbNumeroCartao.Name = "tbNumeroCartao";
            tbNumeroCartao.Size = new Size(165, 23);
            tbNumeroCartao.TabIndex = 12;
            // 
            // lbNsuHost
            // 
            lbNsuHost.AutoSize = true;
            lbNsuHost.Location = new Point(17, 154);
            lbNsuHost.Name = "lbNsuHost";
            lbNsuHost.Size = new Size(53, 15);
            lbNsuHost.TabIndex = 11;
            lbNsuHost.Text = "NsuHost";
            // 
            // tbNsuHost
            // 
            tbNsuHost.Enabled = false;
            tbNsuHost.Location = new Point(17, 172);
            tbNsuHost.Name = "tbNsuHost";
            tbNsuHost.Size = new Size(109, 23);
            tbNsuHost.TabIndex = 10;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Location = new Point(149, 78);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(33, 15);
            lbValor.TabIndex = 9;
            lbValor.Text = "Valor";
            // 
            // lbNsuGuest
            // 
            lbNsuGuest.AutoSize = true;
            lbNsuGuest.Location = new Point(16, 78);
            lbNsuGuest.Name = "lbNsuGuest";
            lbNsuGuest.Size = new Size(58, 15);
            lbNsuGuest.TabIndex = 7;
            lbNsuGuest.Text = "NsuGuest";
            // 
            // lbNumeroCartao
            // 
            lbNumeroCartao.AutoSize = true;
            lbNumeroCartao.Location = new Point(17, 25);
            lbNumeroCartao.Name = "lbNumeroCartao";
            lbNumeroCartao.Size = new Size(89, 15);
            lbNumeroCartao.TabIndex = 6;
            lbNumeroCartao.Text = "Numero Cartao";
            // 
            // tbNsuGuest
            // 
            tbNsuGuest.Location = new Point(16, 96);
            tbNsuGuest.Name = "tbNsuGuest";
            tbNsuGuest.Size = new Size(109, 23);
            tbNsuGuest.TabIndex = 5;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(431, 91);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(109, 31);
            btnVender.TabIndex = 0;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lbStatus.ForeColor = SystemColors.Highlight;
            lbStatus.Location = new Point(367, 426);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(72, 19);
            lbStatus.TabIndex = 3;
            lbStatus.Text = "lbStatus";
            lbStatus.TextAlign = ContentAlignment.BottomCenter;
            // 
            // FPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbStatus);
            Controls.Add(gbVender);
            Controls.Add(gbConfiguracoes);
            Controls.Add(btnConfigurar);
            Name = "FPrincipal";
            Text = "POS_Siscred";
            gbConfiguracoes.ResumeLayout(false);
            gbConfiguracoes.PerformLayout();
            gbVender.ResumeLayout(false);
            gbVender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfigurar;
        private GroupBox gbConfiguracoes;
        private GroupBox gbVender;
        private TextBox tbChaveIntegrador;
        private TextBox tbHostApi;
        private Label lbChaveIntegrador;
        private Label lbHostApi;
        private Label lbToken;
        private TextBox tbToken;
        private Button btnVender;
        private Label lbStatus;
        private Label lbNsuGuest;
        private Label lbNumeroCartao;
        private TextBox tbNsuGuest;
        private Label lbValor;
        private Label lbNsuHost;
        private TextBox tbNsuHost;
        private Label lbIdEstabelecimento;
        private TextBox tbIdEstabelecimento;
        private MaskedTextBox tbNumeroCartao;
        private TextBox tbValor;
        private Label lbCartaoCvv;
        private TextBox tbCartaoCvv;
        private Label lbCartaoValidade;
        private TextBox tbCartaoValidade;
        private Label lbConfirmarAgora;
        private ComboBox cbConfirmarAgora;
        private Label lbAcaoFinalizar;
        private ComboBox cbAcaoFinalizar;
        private TextBox tbValorConfirmacao;
        private Label lbValorConfirmacao;
        private Button btnFinalizar;
    }
}

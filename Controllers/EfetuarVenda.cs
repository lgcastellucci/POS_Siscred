using System.Text.Json;
using POS_Siscred.Models;

namespace POS_Siscred.Controllers
{
    internal class EfetuarVenda
    {
        private string _url = "";
        public EfetuarVenda(string url)
        {
            _url = url;
        }

        public RetornoEfetuarVenda Execute(string token, string idEstabelecimento, string nsuGuest, string cartaoNumero, string cartaoValidade, string cartaoCVV,  string valor, bool confirmarAgora)
        {
            var objRetorno = new RetornoEfetuarVenda();

            var payLoad = new
            {
                reference_id = nsuGuest,
                merchant_id = idEstabelecimento,
                capture = confirmarAgora,
                payer = new
                {
                    identification = new
                    {
                        type = "CPF",
                        number = "28740762874"
                    }
                },
                payment = new
                {
                    amount = valor,
                    installments = "1"
                },
                card = new
                {
                    number = cartaoNumero,
                    holderName = "CARTAO TESTE",
                    expirationDate = cartaoValidade,
                    securityCode = cartaoCVV
                },
                soft_descriptor = new
                {
                    name = "",
                    detail = ""
                }
            };

            var httpService = new HttpService();
            var retHttp = httpService.ExecutePost(_url + "ecommerce/venda", token, JsonSerializer.Serialize(payLoad));

            if (retHttp.erro)
                return objRetorno;

            try
            {
                objRetorno = JsonSerializer.Deserialize<RetornoEfetuarVenda>(retHttp.responseBody);
            }
            catch
            {
                return objRetorno;
            }

            return objRetorno;

        }
    }
}

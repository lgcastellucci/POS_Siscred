using System.Text.Json;
using POS_Siscred.Models;

namespace POS_Siscred.Controllers
{
    internal class EfetuarConfirmacao
    {
        private string _url = "";
        public EfetuarConfirmacao(string url)
        {
            _url = url;
        }

        public RetornoEfetuarConfirmacaoVenda Execute(string token, string idEstabelecimento, string nsuGuest, string nsuHost, string valor)
        {
            var objRetorno = new RetornoEfetuarConfirmacaoVenda();

            var payLoad = new
            {
                reference_id = nsuGuest,
                merchant_id = idEstabelecimento,
                amount = valor,
                authorization = nsuHost
            };

            var httpService = new HttpService();
            var retHttp = httpService.ExecutePost(_url + "ecommerce/confirmacao", token, JsonSerializer.Serialize(payLoad));

            if (retHttp.erro)
                return objRetorno;

            try
            {
                objRetorno = JsonSerializer.Deserialize<RetornoEfetuarConfirmacaoVenda>(retHttp.responseBody);
            }
            catch
            {
                return objRetorno;
            }

            return objRetorno;

        }
    }
}

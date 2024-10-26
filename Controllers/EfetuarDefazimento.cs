using System.Text.Json;
using POS_Siscred.Models;

namespace POS_Siscred.Controllers
{
    internal class EfetuarDesfazimentoVenda
    {
        private string _url = "";
        public EfetuarDesfazimentoVenda(string url)
        {
            _url = url;
        }

        public RetornoEfetuarDesfazimentoVenda Execute(string token, string idEstabelecimento, string nsuGuest, string nsuHost, string valor)
        {
            var objRetorno = new RetornoEfetuarDesfazimentoVenda();

            var payLoad = new
            {
                reference_id = nsuGuest,
                merchant_id = idEstabelecimento,
                amount = valor,
                authorization = nsuHost
            };

            var httpService = new HttpService();
            var retHttp = httpService.ExecutePost(_url + "ecommerce/desfazimento", token, JsonSerializer.Serialize(payLoad));

            if (retHttp.erro)
                return objRetorno;

            try
            {
                objRetorno = JsonSerializer.Deserialize<RetornoEfetuarDesfazimentoVenda>(retHttp.responseBody);
            }
            catch
            {
                return objRetorno;
            }

            return objRetorno;

        }
    }
}

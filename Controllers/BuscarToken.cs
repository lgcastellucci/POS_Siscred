using System.Text.Json;
using POS_Siscred.Models;
using System.Reflection;

namespace POS_Siscred.Controllers
{
    internal class BuscarToken
    {
        private string _url = "";
        public BuscarToken(string url)
        {
            _url = url;
        }

        public RetornoBuscarToken Execute(string chaveDoIntegrador)
        {
            var objRetorno = new RetornoBuscarToken();

            var payLoad = new
            {
                ChaveIntegrador = chaveDoIntegrador,
                Aplicacao = new
                {
                    Nome = Assembly.GetEntryAssembly().GetName().Name,
                    Versao = Assembly.GetEntryAssembly().GetName().Version
                }
            };

            var httpService = new HttpService();
            var retHttp = httpService.ExecutePost(_url + "token", "", JsonSerializer.Serialize(payLoad));

            if (retHttp.erro)
                return objRetorno;

            try
            {
                objRetorno = JsonSerializer.Deserialize<RetornoBuscarToken>(retHttp.responseBody);
            }
            catch
            {
                return objRetorno;
            }

            return objRetorno;

        }
    }
}

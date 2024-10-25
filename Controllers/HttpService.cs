using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Text.Json;

namespace POS_Siscred.Controllers
{
    internal class HttpService
    {
        /// <summary>
        /// Classe de retorno
        /// </summary>
        public class RetHttpService
        {
            public bool erro { get; set; }
            public string responseBody { get; set; }

            public RetHttpService(string? body = null)
            {
                if (string.IsNullOrEmpty(body))
                {
                    erro = true;
                    responseBody = "";
                }
                else
                {
                    erro = false;
                    responseBody = body;
                }
            }
        }

        //public HttpService()
        //{

        //}

        public RetHttpService ExecutePost(string url, string token, string payload)
        {
            RetHttpService retorno = ExecutePostAsync(url, token, payload).Result;
            return retorno;
        }
        private async Task<RetHttpService> ExecutePostAsync(string url, string token, string payload)
        {
            HttpClient httpClient = new HttpClient();
            try
            {
                httpClient.BaseAddress = new Uri(url);
            }
            catch
            {
                return new RetHttpService();
            }

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            if (!string.IsNullOrEmpty(token))
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent stringContent = new StringContent(payload, Encoding.UTF8, "application/json");
            HttpResponseMessage response;
            string responseBody = "";
            try
            {
                httpClient.Timeout = TimeSpan.FromMinutes(2);
                response = httpClient.PostAsync(url, stringContent).Result;
            }
            catch
            {
                return new RetHttpService();
            }

            try
            {
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch
            {
                return new RetHttpService();
            }

            if (response.StatusCode != HttpStatusCode.OK)
            {
                return new RetHttpService();
            }

            JsonDocument dataJson;
            try
            {
                dataJson = JsonDocument.Parse(responseBody);
            }
            catch
            {
                return new RetHttpService();
            }

            if (dataJson == null)
                return new RetHttpService();

            return new RetHttpService(responseBody);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                return;
            }
        }
    }
}

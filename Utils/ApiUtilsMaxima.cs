using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Utils
{
    public static class ApiUtilsMaxima
    {
        public static async Task<TResult> RequisicaoAsync<TResult, TInput>(string url, HttpMethod method, TInput obj)
        {
            using var client = new HttpClient();
            var request = new HttpRequestMessage(method, url);
            var jsonPost = JsonConvert.SerializeObject(obj, Formatting.None, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            request.Content = new StringContent(jsonPost);
            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await client.SendAsync(request);
            var tmp = response.IsSuccessStatusCode;

            var resultJson = await response.Content.ReadAsStringAsync();

            var objpronto = JsonConvert.DeserializeObject<TResult>(resultJson);
            return objpronto;
        }

        public static Dictionary<string, string> RecuperarEtapaMaxima()
        {
            try
            {
                var retorno = new Dictionary<string, string>();

                retorno.Add("0", "Pendente");
                retorno.Add("2", "Liberado");
                retorno.Add("3", "Montado");
                retorno.Add("4", "Faturado");


                return retorno;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

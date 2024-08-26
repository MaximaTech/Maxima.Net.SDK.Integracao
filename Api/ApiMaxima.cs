using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Api
{
    /// <summary>
    /// Classe para a execução de chamadas à API da Máxima.
    /// </summary>
    internal class ApiMaxima : IApiMaxima
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        private readonly string _BaseAddress = "https://intext.solucoesmaxima.com.br:81/";
        private readonly string _BaseAddressPedido = "https://intpdv.solucoesmaxima.com.br:81";
        private string _Token;
        private DateTime _DataExpiracao;

        public ApiMaxima(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }

        public ApiMaxima() { }

        public string Token
        {
            get
            {
                var login = Usuario;
                var senha = Senha;

                if (_DataExpiracao <= DateTime.Now.AddMinutes(-30))
                    if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(senha))
                    {
                        var dadosLogin = RealizarLoginAsync(login, senha).Result;
                        if (dadosLogin.Success)
                        {
                            _Token = dadosLogin.TokenDeAcesso;
                            _DataExpiracao = dadosLogin.DataExpiracao;
                        }
                    }
                return _Token;
            }
            set => throw new NotImplementedException();
        }

        public HttpClient MontaClienteMaxima(bool isPedido = false)
        {
            if (string.IsNullOrEmpty(Token))
                throw new Exception(
                    "Erro ao efetuar o login na maxima, verifique suas credenciais."
                );

            var httpClientApi = new HttpClient
            {
                BaseAddress = new Uri(isPedido ? _BaseAddressPedido : _BaseAddress),
                Timeout = TimeSpan.FromMinutes(5)
            };

            httpClientApi.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
            );
            httpClientApi.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);
            return httpClientApi;
        }

        public async Task<RetornoApiMaxima> Delete<TInput>(
            string versao,
            string caminho,
            TInput objeto
        )
        {
            using var cliente = MontaClienteMaxima();
            var JsonEnvio = JsonConvert.SerializeObject(objeto);
            HttpRequestMessage request =
                new()
                {
                    Content = new StringContent(JsonEnvio, Encoding.UTF8, "application/json"),
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_BaseAddress}api/{versao}/{caminho}")
                };
            var resposta = await cliente.SendAsync(request);
            return await ConverterRetornoApi(resposta);
        }

        public async Task<RetornoApiMaxima> Get(string versao, string caminho, string id)
        {
            try
            {
                using var cliente = MontaClienteMaxima();
                var resposta = await cliente.GetAsync($"/api/{versao}/{caminho}/{id}");
                return await ConverterRetornoApi(resposta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RetornoApiMaxima> Get(string versao, string caminho)
        {
            try
            {
                using var cliente = MontaClienteMaxima();
                var resposta = await cliente.GetAsync($"/api/{versao}/{caminho}");
                return await ConverterRetornoApi(resposta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<PedidoMaxima>> GetPedidosNaoImportados()
        {
            try
            {
                var listPedido = new List<PedidoMaxima>();
                using var cliente = new HttpClient { BaseAddress = new Uri(_BaseAddressPedido) };

                cliente.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json")
                );
                cliente.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);

                var resposta = await cliente.GetAsync($"/api/v1/StatusPedidos/0,1,2,9/1,2");
                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objConvertido = JsonConvert.DeserializeObject<
                    RetornoApi<List<ResponsePedidoMaxima>>
                >(conteudoResposta);

                foreach (var pedido in objConvertido.Sucesso)
                {
                    listPedido.Add(JsonConvert.DeserializeObject<PedidoMaxima>(pedido.ObjPedido));
                }

                return listPedido;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RetornoApiMaxima> Post<TInput>(
            string versao,
            string caminho,
            TInput objeto
        )
        {
            try
            {
                using var cliente = MontaClienteMaxima();
                var JsonEnvio = JsonConvert.SerializeObject(objeto);
                var content = new StringContent(JsonEnvio, Encoding.UTF8, "application/json");
                var resposta = await cliente.PostAsync($"/api/{versao}/{caminho}", content);
                return await ConverterRetornoApi(resposta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RetornoApiMaxima> Put<TInput>(
            string versao,
            string caminho,
            TInput objeto,
            bool isPedido = false
        )
        {
            try
            {
                using var cliente = MontaClienteMaxima(isPedido);
                var JsonEnvio = JsonConvert.SerializeObject(
                    objeto,
                    new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }
                );
                var content = new StringContent(JsonEnvio, Encoding.UTF8, "application/json");
                var resposta = await cliente.PutAsync($"/api/{versao}/{caminho}", content);

                if (!resposta.IsSuccessStatusCode)
                    throw new Exception(
                        "Erro ao realizar requisição para api "
                            + await resposta.Content.ReadAsStringAsync()
                    );

                return await ConverterRetornoApi(resposta);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RetornoApiMaxima> ConverterRetornoApi(HttpResponseMessage resposta)
        {
            try
            {
                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objConvertido = JsonConvert.DeserializeObject<RetornoApiMaxima>(
                    conteudoResposta
                );

                return objConvertido;
            }
            catch (Exception)
            {
                return new RetornoApiMaxima();
            }
        }

        public async Task<Login> RealizarLoginAsync(string login, string password)
        {
            try
            {
                using var clientHttp = new HttpClient();
                clientHttp.BaseAddress = new Uri(_BaseAddress);
                var objectJson = JsonConvert.SerializeObject(new { login, password });
                var content = new StringContent(objectJson, Encoding.UTF8, "application/json");
                var resposta = await clientHttp.PostAsync($"/api/v3/Login", content);
                return JsonConvert.DeserializeObject<Login>(
                    await resposta.Content.ReadAsStringAsync()
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<TReturn> GetAllClientes<TReturn>(string versao, string caminho)
        {
            try
            {
                using var cliente = MontaClienteMaxima(true);
                var resposta = await cliente.GetAsync($"/api/{versao}/{caminho}/0,1,2,9");
                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                var objConvertido = JsonConvert.DeserializeObject<RetornoApi<TReturn>>(
                    conteudoResposta
                );

                if (objConvertido?.Error != null)
                    throw new Exception("Erro Api Maxima " + conteudoResposta);

                return objConvertido.Sucesso;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<RetornoApiMaxima> Delete(string versao, string caminho)
        {
            using var cliente = MontaClienteMaxima();
            HttpRequestMessage request =
                new()
                {
                    Method = HttpMethod.Delete,
                    RequestUri = new Uri($"{_BaseAddress}api/{versao}/{caminho}")
                };
            var resposta = await cliente.SendAsync(request);
            return await ConverterRetornoApi(resposta);
        }
    }
}

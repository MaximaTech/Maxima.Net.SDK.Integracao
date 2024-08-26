using System;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto
{
   public class Login
    {

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data_Criacao")]
        public DateTimeOffset DataCriacao { get; set; }

        [JsonProperty("data_Expiracao")]
        public DateTime DataExpiracao { get; set; }

        [JsonProperty("token_De_Acesso")]
        public string TokenDeAcesso { get; set; }

        [JsonProperty("resposta")]
        public string Resposta { get; set; }
    }
}
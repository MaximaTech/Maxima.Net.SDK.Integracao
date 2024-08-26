using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto
{
    public class RetornoApiMaxima
    {
        public List<object> ItensInserido { get; set; }

        [JsonProperty("success")]
        public object Data { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        public bool Sucesso { get { return !string.IsNullOrEmpty(Data?.ToString()); } }
    }

    public class RetornoApi<T>
    {
        [JsonProperty("success")]
        public T Sucesso { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }
    }
}

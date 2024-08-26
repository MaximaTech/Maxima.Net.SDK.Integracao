using System;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto
{
    public class ResponsePedidoMaxima
    {
        [JsonProperty("id_pedido")]
        public string idPedido { get; set; }
        [JsonProperty("objeto_json")]
        public string ObjPedido { get; set; }
    }
}
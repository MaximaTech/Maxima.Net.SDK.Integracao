using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RestricaoVendaMaximaApi : ApiBase<RestricaoVendaMaxima>
    {
        override public string VersaoAPI { get; set; } = RestricaoVendaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RestricaoVendaMaxima.EndPoint;
        public RestricaoVendaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<RestricaoVendaMaxima> list)
        {
            foreach (var item in list)
            {
                item.OrigemPedido = item.OrigemPedido ?? "F";
            }
        }
    }
}

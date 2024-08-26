using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class HistoricoPedidoFaltaApi : ApiBase<HistoricoPedidoFaltaMaxima>
    {
        override public string VersaoAPI { get; set; } = HistoricoPedidoFaltaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = HistoricoPedidoFaltaMaxima.EndPoint;
        public HistoricoPedidoFaltaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<HistoricoPedidoFaltaMaxima> list)
        {
            foreach (var item in list)
            {
                item.QuantidadePedida = item.QuantidadePedida ?? 0;
                item.QuantidadeFalta = item.QuantidadeFalta ?? 0;
            }
        }
    }

}

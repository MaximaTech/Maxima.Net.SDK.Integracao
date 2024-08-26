using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{

    internal class HistoricoPedidoCorteApi : ApiBase<HistoricoPedidoCorteMaxima>
    {
        override public string VersaoAPI { get; set; } = HistoricoPedidoCorteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = HistoricoPedidoCorteMaxima.EndPoint;
        public HistoricoPedidoCorteApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<HistoricoPedidoCorteMaxima> list)
        {
            foreach (var item in list)
            {
                item.QuantidadeCortada = item.QuantidadeCortada ?? 0;
            }
        }
    }
}

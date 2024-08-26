using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class HistoricoCapaMaximaApi : ApiBase<HistoricoPedidoCapa>
    {
        public HistoricoCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        public override string VersaoAPI { get; set; } = HistoricoPedidoCapa.VersaoAPI;
        public override string EndPoint { get; set; } = HistoricoPedidoCapa.EndPoint;

        internal override void DefinirCamposDefault(List<HistoricoPedidoCapa> list)
        {
            foreach (var item in list)
            {
                item.ValorTotal = item.ValorTotal ?? 0;
                item.ValorTabela = item.ValorTabela ?? 0;
                item.ValorAtendido = item.ValorAtendido ?? 0;
                item.ValorFrete = item.ValorFrete ?? 0;
                item.TipoVenda = item.TipoVenda ?? 1;
            }
        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class HistoricoItensMaximaApi : ApiBase<HistoricoPedidoItem>
    {
        public HistoricoItensMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        public override string VersaoAPI { get; set; } = HistoricoPedidoItem.VersaoAPI;
        public override string EndPoint { get; set; } = HistoricoPedidoItem.Endpoint;

        internal override void DefinirCamposDefault(List<HistoricoPedidoItem> list)
        {
            foreach (var item in list)
            {
                item.Quantidade = item.Quantidade ?? 0;
                item.PrecoVenda = item.PrecoVenda ?? 0;
                item.PrecoTabela = item.PrecoTabela ?? 0;
            }
        }
    }
}

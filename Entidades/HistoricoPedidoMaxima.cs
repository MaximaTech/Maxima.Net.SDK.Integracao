using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o histórico do pedido
    /// </summary>
    public class HistoricoPedidoMaxima
    {
        public HistoricoPedidoMaxima()
        {
            CapaPedido = new HistoricoPedidoCapa();
            ItensPedido = new List<HistoricoPedidoItem>();
        }
        public HistoricoPedidoCapa CapaPedido { get; set; }
        public List<HistoricoPedidoItem> ItensPedido { get; set; }
    }
}

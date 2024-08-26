using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Dto
{
    public class RequestStatusPedido
    {
        public string CodigoPedidoNuvemMaxima { get; set; }
        public string CodigoUsuarioMaxima { get; set; } 
        public string NumeroPedidoRcaMaxima { get; set; }
        public int NumeroPedidoERP { get; set; }
        public string CriticaPedido { get; set; }
        public EnumPosicaoPedido PosicaoPedidoMaxima { get; set; }
    }
}
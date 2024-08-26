namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class ComprovantePagamentoCartaoCredito
    {
        public string codigoAutorizacao { get; set; }
        public string codigoNSU { get; set; }
        public string codigoPedido { get; set; }
        public string codigoTransacao { get; set; }
        public string codigoCliente { get; set; }
        public string codigoClienteMaxima { get; set; }
        public string codigoUsuario { get; set; }
        public string dataAlteracao { get; set; }
        public string dataCriacao { get; set; }
        public ComprovantePagamentoCartaoCreditoOperadora dadosOperadora { get; set; }
        public ComprovantePagamentoCartaoCreditoStatusTransacao statusTransacao { get; set; }
        public decimal valorPedido { get; set; }
    }
}
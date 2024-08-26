namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class Cobranca
    {
        public bool Boleto
        { get; set; }


        public decimal ValorMinimoPedido
        { get; set; }


        public bool Cartao
        { get; set; }


        public ushort NivelVenda
        { get; set; }


        public string Descricao
        { get; set; }


        public string Codigo
        { get; set; }


        public bool PossuiRestricaoPlanoPagto
        { get; set; }
    }
}
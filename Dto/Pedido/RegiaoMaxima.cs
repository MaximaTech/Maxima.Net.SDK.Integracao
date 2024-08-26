namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class RegiaoMaxima
    {
         public string Codigo
        { get; set; }

        public string Descricao
        { get; set; }


        public decimal PercFreteTerceiros
        { get; set; }


        public decimal PercFreteEspecial
        { get; set; }


        public decimal ValorFreteKgVenda
        { get; set; }


        public decimal PercFrete
        { get; set; }

        public bool ZonaFranca
        { get; set; }

        public bool Marcado { get; set; }
    }
}
namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class TransportadoraPedido
    {

        public string Codigo
        { get; set; }

        public string Nome
        { get; set; }


        public bool ExigeRedespacho
        { get; set; }


        public bool Redespacho
        { get; set; }

        public string Fantasia
        { get; set; }

        public string Cnpj
        { get; set; }

        public string Endereco
        { get; set; }

        public string Bairro
        { get; set; }

        public string Cidade
        { get; set; }

        public string Estado
        { get; set; }

        public string Telefone
        { get; set; }


        public decimal PercFreteValor
        { get; set; }


        public decimal PercGRIS
        { get; set; }


        public decimal ValorPedagio
        { get; set; }


        public decimal GatilhoPesoExcedente
        { get; set; }


        public bool IcmsSobreTaxaMinima
        { get; set; }

        public bool Marcado { get; set; }
    }
}
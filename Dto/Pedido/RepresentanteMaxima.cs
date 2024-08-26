namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class RepresentanteMaxima
    {
         #region Fields

        private SupervisorMaxima supervisor;

        #endregion

        #region Propriedades


        public string Codigo
        { get; set; }


        public string Nome
        { get; set; }


        public string CodigoDistribuicao
        { get; set; }


        public decimal PercMaxVenda
        { get; set; }


        public string TipoVendedor
        { get; set; }


        public decimal? PercComissaoVV
        { get; set; }


        public decimal? PercComissaoVP
        { get; set; }


        public SupervisorMaxima Supervisor
        {
            get
            {

                if (supervisor == null)
                    supervisor = new SupervisorMaxima();
                return supervisor;

            }
            set { supervisor = value; }
        }


        public bool Bloqueado
        { get; set; }


        public decimal ValorMinimoPedido
        { get; set; }


        public string AreaAtuacao
        { get; set; }


        public bool UsaDebitoCreditoRCA
        { get; set; }


        public bool RestringeFornecedores
        { get; set; }


        public decimal SaldoCcRca
        { get; set; }

        public string Email
        { get; set; }

        public string Telefone
        { get; set; }


        public bool AceitaDescontoAcrescimoPrecoFixo { get; set; }

        public decimal PercAcrescimoFV { get; set; }

        #endregion


        public decimal LimiteCcRca { get; set; }


        public short CodUsuario { get; set; }


        public decimal SaldoCCRCAEmissaoPedido { get; set; }
        
    }
}
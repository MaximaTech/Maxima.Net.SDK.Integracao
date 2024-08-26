using System.Collections.Generic;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class FilialPedido
    {
                public string Codigo
        { get; set; }


        public string Nome
        { get; set; }


        public bool CalcularIpiVenda
        { get; set; }


        public string NumRegiao
        { get; set; }


        public int TipoAvalicacaoComissao
        { get; set; }

        /// <summary>
        /// Informa se as comissoes zeradas serão avaliadas durante o calculo da comissao do RCA
        /// </summary>

        public bool ConsiderarComissaoZerada
        { get; set; }


        public bool AceitaVendaSemEstoque
        { get; set; }


        public bool BloquearPedidoAbaixoValorMinimo
        { get; set; }


        public bool AlterarCobrancaBoletoParaChequeAutomaticamente
        { get; set; }


        public string OrdemAvaliacaoComissao
        { get; set; }


        public bool UtilizaVendaPorEmbalagem
        { get; set; }


        public string TipoFreteAuto
        { get; set; }


        public bool LancarFretePesoAutomaticamente
        { get; set; }


        public bool UtilizaNFE
        { get; set; }


        public bool UtilizaEstoqueDepositoFechado
        { get; set; }

        public string CGC
        { get; set; }

        public string IE
        { get; set; }


        public Endereco Endereco
        { get; set; }

        public string Telefone
        { get; set; }

        public string Fax
        { get; set; }


        public bool AceitaDescontoMaiorFlexivel
        { get; set; }


        public bool UsaDescontoSimplesNacional { get; set; }


        public string TipoPrecificacao
        { get; set; }


        public bool UtilizaControleMedicamentos { get; set; }


        public bool UsaAbatimento { get; set; }


        public decimal PercentualMaximoAbatimento { get; set; }


        public string OrigemCustoFilialRetira { get; set; }


        public bool AutoServico { get; set; }


        public decimal NumeroMaximoItensNF { get; set; }


        public bool BloquearVendaPessoaFisica { get; set; }


        public bool UtilizaPrecoPorEmbalagem { get; set; }


        public bool UtilizaAcrescimoVendaCupom { get; set; }


        public bool ObrigatorioVincularTv5ComTv1 { get; set; }


        public bool usaVendaPorGrade { get; set; }


        public bool AceitaVendaRCASemSaldoCC { get; set; }


        public List<string> FiliaisRetira { get; set; }


        public bool UtilizaAliquotaReduzidaValoresPautados { get; set; }


    }

    
    
}
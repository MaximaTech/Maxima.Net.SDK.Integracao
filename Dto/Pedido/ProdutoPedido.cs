using System;
using System.Collections.Generic;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class ProdutoPedido
    {

        public class OrigemComissaoProduto
        {

            public double perCom { get; set; }


            public long numPed { get; set; }


            public int numSeq { get; set; }


            public string codProd { get; set; }


            public string origemPed { get; set; }


            public string codAuxiliar { get; set; }


            public string codFilial { get; set; }


            public int? numRegiao { get; set; }


            public double perDesc { get; set; }


            public string codUsur { get; set; }


            public string codCli { get; set; }


            public string codCob { get; set; }


            public string codPlPag { get; set; }


            public string codRotinaComis { get; set; }


            public int codComis { get; set; }


            public string tipoComissao { get; set; }


            public string tipoVend { get; set; }


            public string tipoVenda { get; set; }


            public string codLinhaProd { get; set; }


            public int tipoAvaliacaoComissao { get; set; }


            public int ordemAvaliacaoComissaoRca { get; set; }


            public bool usaComissaoPorRca { get; set; }


            public bool usaComissaoPorCliente { get; set; }


            public bool usaComissaoPorLinhaProd { get; set; }


            public bool comissaoOrcaTipoVenda { get; set; }


            public bool considerarComissaoZero { get; set; }
        }

        public class PrevisaoEntrega
        {

            public DateTime DataPrevisao { get; set; }
            public decimal Quantidade { get; set; }
            public string CodigoFilial { get; set; }
        }

        /// <summary>
        /// Classe responsavel pelos dados de tributacao do produto
        /// </summary>

        public class ImpostosProduto
        {

            #region Propriedades


            public decimal ValorST { get; set; }


            //Armazena o valor de ST que sera utilizado nos calculos de preco de tabela, quand
            //o sistema estiver parametrizado para apresentar o valor da venda sem ST

            public decimal ValorST_Tabela { get; set; }


            public decimal ValorIPI_Tabela { get; set; }


            public decimal ValorIPI { get; set; }


            public decimal ValorBaseST { get; set; }


            public decimal MargemPrecificacao { get; set; }


            public decimal ValorSTClienteGNRE { get; set; }


            public bool TributacaoFonteSTAtiva { get; set; }


            public decimal DescontoReducaoPIS { get; set; }


            public decimal DescontoReducaoPISEntrada { get; set; }


            public decimal PercDescontoPIS { get; set; }


            public decimal DescontoReducaoCofins { get; set; }


            public decimal DescontoReducaoCofinsEntrada { get; set; }


            public decimal PercDescontoCofins { get; set; }


            public decimal ValorDescontoSUFRAMA { get; set; }


            public decimal ValorDescontoSUFRAMAEntrada { get; set; }


            public decimal ValorDescontoPISSUFRAMA { get; set; }


            public decimal ValorDescontoICMSInsencao { get; set; }


            public decimal PercDescontoIsentoICMS { get; set; }


            public decimal ValorDiferencaAliquotas { get; set; }


            public decimal BaseDiferencaAliquotas { get; set; }


            public decimal PercDiferencaAliquotas { get; set; }


            public decimal? ValorReducaoSimplesNacional { get; set; }


            public decimal? ValorReducaoCMVSimplesNacional { get; set; }


            public decimal PercReducaoSimplesNacional { get; set; }


            public decimal ValorDescAcrescPlanoPagamento { get; set; }


            public decimal ValorBaseICMS { get; set; }


            public decimal ValorICMS { get; set; }

            private PartilhaIcms _PartilhaIcms;

            public PartilhaIcms PartilhaIcms
            {
                get
                {
                    if (this._PartilhaIcms == null)
                    {
                        this._PartilhaIcms = new PartilhaIcms();
                    }
                    return this._PartilhaIcms;
                }
                set
                {
                    if (this._PartilhaIcms != value)
                    {
                        this._PartilhaIcms = value;
                    }
                }
            }


            public decimal ValorSTSemReducaoSimples { get; set; }


            public decimal ValorFECP { get; set; }


            public decimal BaseFECP { get; set; }

            #endregion



        }

        /// <summary>
        /// Classe responsável por manter todos os parametros que serao utilizados no calculo da tributacao do produto
        /// </summary>

        public class TributacaoProduto
        {

            #region Fields

            private ParamIPI ipi;
            private ParamST st;
            private ProdutoPedido.TributacaoProduto.ParamPISCofins pisCofins;
            private ProdutoPedido.TributacaoProduto.ParamSUFRAMA suframa;

            #endregion

            #region Classes

            /// <summary>
            /// Classe responsavel por armazenar os parametros de ST que serao calculados para o produto
            /// </summary>

            public class ParamST
            {


                public decimal PercIVA { get; set; }


                public decimal PercBaseSTRJ { get; set; }


                public decimal AliquotaICMS1 { get; set; }


                public decimal AliquotaICMS2 { get; set; }


                public decimal ValorPauta { get; set; }


                public decimal PercReducaoBaseCalculo { get; set; }


                public decimal PercReducaoBaseCalculoFonte { get; set; }


                public decimal ValorUltimaEntrada { get; set; }


                public bool UsarValorUltEntradaBaseST { get; set; }


                public bool UsarValorUltEntradaBaseST2 { get; set; }


                public bool MostrarPrecoVendaSemST { get; set; }


                public decimal ValorSTEntrada { get; set; }


                public decimal PercIVAFonte { get; set; }


                public decimal AliquotaICMS1Fonte { get; set; }


                public decimal AliquotaICMS2Fonte { get; set; }


                public decimal PercReducaoBaseNRPA { get; set; }


                public decimal PercReducaoBaseConsumidor { get; set; }


                public bool UtilizaPercBaseReducaoPF { get; set; }


                public decimal PercDescontoSimplesNacional { get; set; }


                public decimal PercCreditoVendasSimplesNacional { get; set; }


                public bool CreditoVendasSimplesNacionalAplicado { get; set; }

                public decimal PercIVASemReducaoSimples { get; set; }


                public decimal PercAcrescimoSimplesNacional { get; set; }


                public decimal AliquotaFECP { get; set; }
            }


            /// <summary>
            /// Classe responsavel por armazenar os parametros de SUFRAMA
            /// </summary>

            public class ParamSUFRAMA
            {


                public decimal PercDescontoSuframa { get; set; }


                public decimal PercDescontoPISSuframa { get; set; }

            }


            /// <summary>
            /// Classe responsavel por armazenar os parametros de PIS e Confins do produto
            /// </summary>

            public class ParamPISCofins
            {


                public decimal PercDescontoPIS { get; set; }


                public decimal PercDescontoCofins { get; set; }

            }


            /// <summary>
            /// Classe responsavel por manter as informacoes relacionadas aos parametros que serao utilizados no cálculo de IPI
            /// </summary>

            public class ParamIPI
            {

                /// <summary>
                /// Valor do IPI por Pauta
                /// </summary>

                public decimal? ValorPauta { get; set; }

                /// <summary>
                /// Valor do IPI por Kg
                /// </summary>

                public decimal? ValorKg { get; set; }

                /// <summary>
                /// Percentual de IPI que incide sob o produto
                /// </summary>

                public decimal? Perc { get; set; }


                public bool MostrarPrecoVendaSemIPI { get; set; }


                public decimal ValorIPIEntrada { get; set; }

                public decimal? PercReal { get; set; }
            }

            #endregion

            #region Propriedades

            /// <summary>
            /// Código ICMS pessoa física
            /// </summary>

            public decimal? CodIcmPF { get; set; }


            public decimal? CodIcmRural { get; set; }
            /// <summary>
            /// Código ICMS pessoa jurídica
            /// </summary>

            public decimal? CodIcmPJ { get; set; }

            /// <summary>
            /// % de ICMS
            /// </summary>

            public decimal? CodIcmTAB { get; set; }

            /// <summary>
            /// Situação tributária
            /// </summary>

            public string SitTributaria { get; set; }

            /// <summary>
            /// Código Fiscal Estadual
            /// </summary>

            public string CodFiscal { get; set; }

            /// <summary>
            /// Código Fiscal InterEstadual
            /// </summary>

            public string CodFiscalInterestadual { get; set; }


            public ParamIPI IPI
            {
                get
                {

                    if (ipi == null)
                        ipi = new ParamIPI();

                    return ipi;
                }
                set { ipi = value; }
            }


            public ParamST ST
            {
                get
                {

                    if (st == null)
                        st = new ParamST();

                    return st;
                }
                set { st = value; }
            }

            /// <summary>
            /// Codigo da figura tributaria na PCTRIBUT
            /// </summary>

            public string CodST { get; set; }


            public decimal PercDescontoCusto { get; set; }


            public decimal? CodIcmTABPF { get; set; }


            public decimal PercDescontoIsentoICMS { get; set; }


            public decimal PercDescontoPIS { get; set; }


            public decimal PercDescontoCofins { get; set; }


            public decimal PercDescRepasse { get; set; }


            public bool AgregarIPICalculoST { get; set; }


            public decimal PercAcrescimoPessoaFisica { get; set; }


            public decimal? PercDiferencaAliquotas { get; set; }


            public string TipoCalculoGNRE { get; set; }


            public bool AplicaAcrescimoPessoaJuridicaIsenta { get; set; }


            public decimal PercReducaoBase { get; set; }


            public bool UsaValorUltimaEntradaMedioBase { get; set; }


            public ProdutoPedido.TributacaoProduto.ParamPISCofins PisCofins
            {
                get
                {

                    if (pisCofins == null)
                        pisCofins = new ParamPISCofins();

                    return pisCofins;

                }
                set { pisCofins = value; }
            }


            public ProdutoPedido.TributacaoProduto.ParamSUFRAMA Suframa
            {
                get
                {

                    if (suframa == null)
                        suframa = new ParamSUFRAMA();

                    return suframa;
                }
                set { suframa = value; }
            }


            public decimal PercAcrescimoFUNCEP { get; set; }

            #endregion
        }

        /// <summary>
        /// Classe responsavel por armazenar informacoes sobre as comissoes desse produto
        /// </summary>

        public class ComissoesProduto
        {


            public decimal? PercComissaoProduto { get; set; }


            public decimal? PercComissaoCliente { get; set; }


            public decimal? PercComissaoRCA { get; set; }


            public decimal? PercComissaoLinhaProduto { get; set; }


            public decimal? PercComissaoFaixaDescontoLucratividade { get; set; }


            public decimal? PercComissaoFaixaDescontoRCA { get; set; }


            public decimal? PercComissaoFaixaDescontoRegiao { get; set; }


            public decimal? PercComissaoFaixaDescontoPlanoPagamento { get; set; }


            public decimal? PercComissaoPrecoVendaAutorizacao { get; set; }


            public decimal? PercComissaoPoliticaComercial { get; set; }
        }

        /// <summary>
        /// Classe que contem informações sobre todas as politicas comerciais validas para esse produto.
        /// </summary>

        public class PoliticasComerciaisProduto
        {

            #region Classes

            /// <summary>
            /// Politica de Acrescimo ou Desconto Comercial (RN.EPV.00106)
            /// </summary>

            public class DescontoOuAcrescimoComercial
            {

                #region Metodos

                /// <summary>
                /// Funcao realizada para fazer a comparacao dos Percentuais de Desconto
                /// </summary>
                /// <param name="x"></param>
                /// <param name="y"></param>
                /// <returns></returns>
                public static int CompararPercentualDesconto(DescontoOuAcrescimoComercial x,
                                                             DescontoOuAcrescimoComercial y)
                {
                    if (x.PercentualDesconto.Equals(y.PercentualDesconto))
                        return 0;
                    else if (x.PercentualDesconto > y.PercentualDesconto)
                        return -1;
                    else
                        return 1;

                }

                /// <summary>
                /// Funcao realizada para fazer a comparacao dos Percentuais de Acrescimo
                /// </summary>
                /// <param name="x"></param>
                /// <param name="y"></param>
                /// <returns></returns>
                public static int CompararPercentualAcrescimo(DescontoOuAcrescimoComercial x,
                                                              DescontoOuAcrescimoComercial y)
                {
                    if (x.PercentualDesconto.Equals(y.PercentualDesconto))
                        return 0;
                    else if (x.PercentualDesconto > y.PercentualDesconto)
                        return 1;
                    else
                        return -1;

                }

                #endregion

                #region Propriedades


                public string CodigoPolitica { get; set; }


                public DateTime DataInicio { get; set; }


                public DateTime DataFim { get; set; }


                public decimal PercentualDesconto { get; set; }


                public bool BaseDebCredRCA { get; set; }


                public bool AlteraPrecoTabela { get; set; }


                public bool CreditaSobrePolitica { get; set; }


                public bool Prioritaria { get; set; }


                public bool PrioritariaGeral { get; set; }


                public bool AplicacaoAutomatica { get; set; }


                public decimal? PercentualComissao { get; set; }

                #endregion



            }

            /// <summary>
            /// Politica de Preco Fixo (RN.EPV.00107)
            /// </summary>

            public class PrecoFixo
            {


                public string CodigoPolitica { get; set; }


                public decimal Valor { get; set; }


                public DateTime DataInicioVigencia { get; set; }


                public DateTime DataTerminoVigencia { get; set; }


                public bool AplicaDescontoSimples { get; set; }


                public bool AceitaDescontoPrecoFixo { get; set; }


                public bool AceitaAcrescimoPrecoFixo { get; set; }


                public bool ConsideraPrecoSemImposto { get; set; }
            }

            /// <summary>
            /// Politica de Desconto/Acrescimo por Quantidade (RN.EPV.00108)
            /// </summary>

            public class DescontoOuAcrescimoPorQuantidade
            {

                #region Metodos

                /// <summary>
                /// Funcao realizada para fazer a comparacao dos Percentuais de Desconto
                /// </summary>
                /// <param name="x"></param>
                /// <param name="y"></param>
                /// <returns></returns>
                public static int CompararPercentualDesconto(DescontoOuAcrescimoPorQuantidade x,
                                                             DescontoOuAcrescimoPorQuantidade y)
                {
                    if (x.PercentualDesconto.Equals(y.PercentualDesconto))
                        return 0;
                    else if (x.PercentualDesconto > y.PercentualDesconto)
                        return -1;
                    else
                        return 1;

                }

                /// <summary>
                /// Funcao realizada para fazer a comparacao dos Percentuais de Acrescimo
                /// </summary>
                /// <param name="x"></param>
                /// <param name="y"></param>
                /// <returns></returns>
                public static int CompararPercentualAcrescimo(DescontoOuAcrescimoPorQuantidade x,
                                                              DescontoOuAcrescimoPorQuantidade y)
                {
                    if (x.PercentualDesconto.Equals(y.PercentualDesconto))
                        return 0;
                    else if (x.PercentualDesconto > y.PercentualDesconto)
                        return 1;
                    else
                        return -1;

                }


                #endregion

                #region Propriedades


                public string CodigoPolitica { get; set; }


                public uint QuantidadeInicial { get; set; }


                public uint QuantidadeFinal { get; set; }


                public decimal PercentualDesconto { get; set; }


                public decimal? PercentualDescontoMaximo { get; set; }


                public bool AplicacaoAutomatica { get; set; }


                public bool Prioritaria { get; set; }


                public bool CreditaSobrePrecoTabela { get; set; }


                public bool BaseDebCredRCA { get; set; }


                public DateTime? DataInicio { get; set; }


                public DateTime? DataTermino { get; set; }


                public bool AlteraPrecoTabela { get; set; }

                #endregion



            }


            public class CampanhaDesconto
            {


                public string Codigo { get; set; }


                public string Descricao { get; set; }


                public string TipoPatrocinio { get; set; }


                public string TipoCampanha { get; set; }


                public DateTime DataInicio { get; set; }


                public DateTime DataTermino { get; set; }


                public string CodigoProduto { get; set; }


                public decimal QtMinima { get; set; }


                public decimal QtMaxima { get; set; }


                public decimal PercDesconto { get; set; }


                public decimal QtPedido { get; set; }


                public bool UtilizaCodProdPrincipal { get; set; }


                public string DescricaoProduto { get; set; }


                public int Sequencia { get; set; }


                public string Chave { get; set; }


                public bool ComboContinuo { get; set; }

            }

            /// <summary>
            /// Autorizacoes de Venda
            /// </summary>

            public class AutorizacaoDeVenda
            {


                public decimal? InicioIntervalo { get; set; }


                public decimal? FimIntervalo { get; set; }


                public decimal PercDescontoAutorizado { get; set; }


                public decimal? PercComissao { get; set; }

                public decimal PrecoVendaAutorizado
                {
                    get { return PrecoVendaAtual * (1 - PercDescontoAutorizado); }
                }


                public string BaseDebCredRCA { get; set; }


                public decimal PrecoVendaAtual { get; set; }


                public decimal PrecoVendido { get; set; }


                public uint NumeroAutorizacao { get; set; }

            }


            public class ComboContinuoClass
            {

                public long CodigoCampanha { get; set; }


                public decimal PercDesconto { get; set; }


                public bool TerceiroCombo { get; set; }


                public long CodCampanhaTerceiroCombo { get; set; }
            }

            #endregion


            public ComboContinuoClass ComboContinuo { get; set; }


            public DescontoOuAcrescimoComercial PoliticaAcrescimoComercial { get; set; }

            /// <summary>
            /// Politica de Desconto ou Acrescimo Comercial aplicada automaticamente
            /// </summary>
            ///

            public DescontoOuAcrescimoComercial PoliticaDescontoComercial { get; set; }

            /// <summary>
            /// Percentual máximo de desconto dentre todas as politicas comerciais validas para esse produto
            /// </summary>

            public decimal PercentualMaximoDescontoComercial { get; set; }

            /// <summary>
            /// Percentual máximo de acrescimo dentre todas as politicas de acrescimo comercial válidas
            /// </summary>

            public decimal PercentualMaximoAcrescimoComercial { get; set; }

            /// <summary>
            /// Politica de Preco Fixo Aplicada
            /// </summary>

            public PrecoFixo PoliticaPrecoFixo { get; set; }

            /// <summary>
            /// Relação de todas as politicas de desconto por quantidade que sao aplicaveis a esse produto
            /// </summary>

            public List<DescontoOuAcrescimoPorQuantidade> ListaPoliticasDescontoPorQuantidade { get; set; }

            /// <summary>
            /// Politica de Desconto por Quantidade Aplicada Automaticamente
            /// </summary>

            public DescontoOuAcrescimoPorQuantidade PoliticaDescontoPorQuantidade { get; set; }


            public DescontoOuAcrescimoPorQuantidade PoliticaAcrescimoPorQuantidade { get; set; }


            public AutorizacaoDeVenda PoliticaAutorizacaoVenda { get; set; }

            /// <summary>
            /// Informa o código de restrição de venda cadastrado para esse produto. Caso seja não nulo, o produto não poderá ser inserido no pedido.
            /// </summary>

            public string CodigoRestricaoVenda { get; set; }

            /// <summary>
            /// Lista com as campanhas de desconto disponiveis para esse produto
            /// </summary>

            public List<CampanhaDesconto> ListaCampanhasDesconto { get; set; }

            /// <summary>
            /// Campanha de desconto sendo utilizada para esse produto
            /// </summary>

            public CampanhaDesconto PoliticaCampanhaDesconto { get; set; }

            /// <summary>
            /// Politica de desconto comercial ativa para calculo do Preco Base do produto (Conta corrente do RCA)
            /// </summary>

            public DescontoOuAcrescimoComercial PoliticaDescontoComercialCC { get; set; }

            /// <summary>
            /// Politica de acrescimo comercial ativa para calculo do Preso Base do produto (Conta Corrente do RCA)
            /// </summary>

            public DescontoOuAcrescimoComercial PoliticaAcrescimoComercialCC { get; set; }

            /// <summary>
            /// Politica de desconto comercial ativa para Aplicação Automatica
            /// </summary>

            public DescontoOuAcrescimoComercial PoliticaDescontoComercialAA { get; set; }

            /// <summary>
            /// Politica de acrescimo comercial ativa para Aplicacao Automatica
            /// </summary>

            public DescontoOuAcrescimoComercial PoliticaAcrescimoComercialAA { get; set; }

            /// <summary>
            /// Codigo da politica de preco Fixo Aplicada a essa Cesta Basica
            /// </summary>

            public string CodigoPoliticaCestaBasica { get; set; }
        }

        /// <summary>
        /// Classe responsavel por armazenar dados referentes aos parametros de calculo de frete para esse produto
        /// </summary>

        public class FreteProduto
        {


            public decimal PercFrete { get; set; }


            public bool DescontaFrete { get; set; }


            public decimal PercDescontoFreteFOB { get; set; }


            public bool FreteEspecial { get; set; }

        }

        /// <summary>
        /// Classe que armazena informacoes sobre o historico de vendas desse produto
        /// </summary>

        public class HistoricoVendaProduto
        {

            public decimal QtdeCompraMesAtual { get; set; }

            public decimal MediaCompraUltTrimestre { get; set; }

            public DateTime DtUltimaCompra { get; set; }

            public decimal QtdeUltimaCompra { get; set; }

            public PlanoPagamentoPedido PlanoPagtoUltimaCompra { get; set; }

            public decimal ValorUltimaCompra { get; set; }

            public decimal PercDescontoUltimaCompra { get; set; }

            public decimal MediaVendaUltimoTrimestre { get; set; }

            public decimal MediaPercDescontoUltimoTrimestre { get; set; }

        }

        /// <summary>
        /// Classe responsavel por apresentar dados adicionais do produto
        /// </summary>

        public class DadosAdicionaisProduto
        {
            public string InformacoesTecnicas { get; set; }

            public string DadosTecnicos { get; set; }

            public byte[] DadosImagem { get; set; }

            public string Descricao { get; set; }

            public string CodFabrica { get; set; }

            public string NBM { get; set; }

            public string PrincipioAtivo { get; set; }

            public DateTime? DataVencimento { get; set; }
        }

        /// <summary>
        /// Classe que representa uma embalagem de um produto
        /// </summary>

        public class EmbalagemProduto
        {

            public string Embalagem { get; set; }


            public string CodBarras { get; set; }


            public decimal Fator { get; set; }


            public decimal? PrecoVenda { get; set; }


            public decimal? PrecoTabela { get; set; }


            public decimal? PrecoOferta { get; set; }


            public decimal? PrecoTabelaAtac { get; set; }


            public decimal? PrecoVendaAtac { get; set; }


            public decimal? PrecoOfertaAtac { get; set; }


            public decimal? QtMaximaVenda { get; set; }


            public decimal? QtMinimaAtacado { get; set; }


            public bool PermiteMultiplicacao { get; set; }


            public bool PermiteVendaAtacado { get; set; }


            public string TipoEmbalagem { get; set; }


            public decimal QtUnit { get; set; }


            public decimal QtUnitEmbalagem { get; set; }


            public decimal FatorPreco { get; set; }


            public decimal Multiplo { get; set; }


            public DateTime? DataOfertaInicio { get; set; }


            public DateTime? DataOfertaFim { get; set; }


            public DateTime? DataOfertaAtacadoInicio { get; set; }


            public DateTime? DataOfertaAtacadoFim { get; set; }


            public string Unidade { get; set; }

        }

        /// <summary>
        /// Dados relacionados à ultima entrada do produto
        /// </summary>

        public class DadosUltimaEntradaProduto
        {


            public decimal ValorST { get; set; }


            public decimal ValorSTGuia { get; set; }


            public decimal CustoNFSemSTGuia { get; set; }


            public decimal IVA { get; set; }


            public decimal AliqICMS1 { get; set; }


            public decimal AliqICMS2 { get; set; }


            public decimal ReducaoBaseIVA { get; set; }


            public decimal PercICMSFreteFOB { get; set; }


            public decimal ValorFreteConhecimento { get; set; }


            public decimal PercAliqExternaGuia { get; set; }


            public decimal BaseICMS { get; set; }

        }

        /// <summary>
        /// Classe que representa os produtos filhos atribuido a esse produto
        /// </summary>

        public class ProdutoFilho
        {


            public string Codigo { get; set; }


            public string Descricao { get; set; }


            public decimal Quantidade { get; set; }


            public string Embalagem { get; set; }


            public String FilialRetira { get; set; }


            public decimal EstoqueDisponivel { get; set; }
        }


        public class PrecificacaoProduto
        {

            public FilialPedido Filial { get; set; }
        }

        /// <summary>
        /// Classe para validação dos impostos de partilha de icms
        /// </summary>

        public class PartilhaIcms
        {

            public decimal ValorIcmsPartilha { get; set; }


            public decimal ValorBaseIcmsPartilha { get; set; }


            public decimal ValorPartilhaOrigem { get; set; }


            public decimal ValorPartilhaDestino { get; set; }


            public decimal PercentualParticipacao { get; set; }


            public decimal DiferencaAliquotaPartilha { get; set; }


            public decimal AliquotaPartilhaUtilizadaOrigem { get; set; }


            public decimal AliquotaPartilhaUtilizadaDestino { get; set; }


            public decimal ValorPartilhaFuncep { get; set; }
        }

        public class ParametroCalcularPartilha
        {
            public bool CalcularPartilha { get; set; }

            public bool ConsumidorFinal { get; set; }

            public bool Contribuinte { get; set; }

            public string UfOrigem { get; set; }

            public string UfDestino { get; set; }
        }

        public class ParametroPartilhaIcms
        {
            public bool AgregaPartilhaPrecoBase { get; set; }
            public decimal PrecoSemImpostos { get; set; }

            public decimal PorcentagemBaseReducao { get; set; }

            public decimal AliquotaOrigem { get; set; }

            public decimal AliquotaDestino { get; set; }

            public decimal AliquotaParametro { get; set; }

            public decimal PorcentagemParticipacao { get; set; }

            public decimal PorcentagemAcrescimoFUNCEP { get; set; }
        }

        public class RetornoIcmsPartilha
        {
            public decimal ValorPartilha { get; set; }

            public decimal ValorBasePartilha { get; set; }

            public decimal ValorPartilhaOrigem { get; set; }

            public decimal ValorPartilhaDestino { get; set; }

            public decimal ValorPartilhaFUNCEP { get; set; }

            public decimal DiferencaAliquota { get; set; }

        }



        #region Fields

        private ProdutoPedido.ImpostosProduto impostos;
        private ProdutoPedido.TributacaoProduto tributacao;
        private ProdutoPedido.TributacaoProduto tributacaoDestino;
        private ComissoesProduto comissoes;
        private ProdutoPedido.FreteProduto frete;
        private ProdutoPedido.PoliticasComerciaisProduto politicasComerciais;
        private EmbalagemProduto embalagemSelecionada;
        private List<FilialRetiraPedido> filiaisRetira;

        #endregion

        #region Propriedades

        public static ProdutoPedido Copy(ProdutoPedido produto)
        {
            return (ProdutoPedido)produto.MemberwiseClone();
        }


        public string Codigo
        { get; set; }


        public string Descricao
        { get; set; }

        public string Embalagem
        { get; set; }

        public string EmbalagemProdutoFilho { get; set; }


        public string Unidade
        { get; set; }


        public string UnidadeMaster { get; set; }

        public string Obs
        { get; set; }

        public string Obs2
        { get; set; }


        public decimal QtUnit
        { get; set; }


        public decimal QtUnitCX
        { get; set; }


        public decimal PesoPeca { get; set; }


        public decimal PesoBrutoMaster { get; set; }


        public bool PesoVariavel { get; set; }


        public decimal PercDiferencaKgFrio { get; set; }


        public decimal? QtMinimaAtacado
        { get; set; }


        public decimal PercDescontoFlexivel
        { get; set; }


        public decimal PercDescontoFlexivelBalcao
        { get; set; }

        /// <summary>
        /// Preco de Tabela vigente
        /// </summary>

        public decimal PrecoTabela
        { get; set; }

        /// <summary>
        /// Preco de Venda Vigente
        /// </summary>

        public decimal PrecoVenda
        { get; set; }

        /// <summary>
        /// Preco de Venda Varejo Indice - PVENDAX
        /// </summary>

        public decimal PrecoTabelaIdx
        { get; set; }

        /// <summary>
        /// Preco de Venda Atacado Indice - PVENDAATACX
        /// </summary>

        public decimal? PrecoTabelaAtacadoIdx
        { get; set; }


        public decimal? PercComissao
        { get; set; }


        public double Percom2 { get; set; }


        public double Percom3 { get; set; }


        public double Percom4 { get; set; }


        public decimal Quantidade
        { get; set; }


        public decimal QuantidadePecas
        { get; set; }


        public decimal QuantidadeCaixas
        { get; set; }


        public ProdutoPedido.ImpostosProduto Impostos
        {
            get
            {
                if (impostos == null)
                    impostos = new ImpostosProduto();
                return impostos;
            }

            set { impostos = value; }
        }


        public bool SolicitandoAutorizacaoPreco { get; set; }

        public DepartamentoProduto Departamento
        { get; set; }


        public SecaoProduto Secao
        { get; set; }


        public FornecedorPedido Fornecedor
        { get; set; }

        public decimal EstoqueDisponivel
        { get; set; }

        public decimal EstoqueDisponivelCaixa
        {
            get
            {

                if (embalagemSelecionada == null || embalagemSelecionada.Fator == 0)
                    return EstoqueDisponivel;
                else
                    return EstoqueDisponivel / embalagemSelecionada.Fator;

            }
        }


        public string Filial
        { get; set; }


        public List<FilialRetiraPedido> FiliaisRetira
        {
            get
            {
                if (filiaisRetira == null)
                {
                    filiaisRetira = new List<FilialRetiraPedido>();
                }
                return filiaisRetira;
            }

            set { filiaisRetira = value; }
        }


        public decimal PesoLiquido
        { get; set; }


        public decimal PesoBruto
        { get; set; }


        public decimal CustoFinanceiro
        {
            get { return _custoFinanceiro; }
            set { _custoFinanceiro = value; }
        }


        public decimal CustoReal
        {
            get { return _custoReal; }
            set { _custoReal = value; }
        }


        public decimal CustoReposicao
        { get; set; }


        public uint? PrazoMedioVenda
        { get; set; }


        public int Sequencia
        { get; set; }


        public decimal PercDescontoInformadoTela { get; set; }

        public decimal PercDesconto
        {
            get
            {
                decimal vPercDec = 0;
                if (PrecoTabela != 0)
                    vPercDec = Math.Round((PrecoVenda - PrecoTabela) / PrecoTabela, 6) * -1;

                return vPercDec;
            }
        }

        public decimal PercDescontoInformado
        {
            get
            {

                // Se algumas das compontes de valores informados for nula, retorna o valor padrao
                if (PrecoTabelaInformado == null || PrecoVendaInformado == null)
                    return PercDesconto;

                if (PercDescontoInformadoTela != 0)
                    return PercDescontoInformadoTela;

                if (PrecoTabelaInformado != 0)
                    return Math.Round(((decimal)PrecoVendaInformado - (decimal)PrecoTabelaInformado) / (decimal)PrecoTabelaInformado, 6) * -1;
                else
                    return 0;

            }

        }

        public decimal PercLucratividade
        {
            get
            {
                if (!SemCadastro)
                    if (PrecoVenda.Equals(0))
                        return 0;
                    else
                        return (PrecoVenda - CustoFinanceiro) / PrecoVenda;
                else
                    return 0;
            }
        }


        public ProdutoPedido.TributacaoProduto Tributacao
        {
            get
            {

                if (tributacao == null)
                    tributacao = new TributacaoProduto();

                return tributacao;
            }
            set { tributacao = value; }
        }


        public ProdutoPedido.TributacaoProduto TributacaoDestino
        {
            get
            {

                if (tributacaoDestino == null)
                    tributacaoDestino = new TributacaoProduto();

                return tributacaoDestino;
            }
            set { tributacaoDestino = value; }
        }


        public string CodigoDistribuicao
        { get; set; }


        public decimal CustoContabil
        { get; set; }


        public ComissoesProduto Comissoes
        {
            get
            {

                if (comissoes == null)
                    comissoes = new ComissoesProduto();
                return comissoes;

            }
            set { comissoes = value; }
        }


        public decimal PercDescontoFlexivelMax
        { get; set; }


        public decimal PercAcrescimoFlexivelMax
        { get; set; }


        public decimal PrecoVendaSemImpostos
        { get; set; }


        public decimal PrecoSemImpostos
        { get; set; }


        public decimal PrecoVendaAtacSemImpostos
        { get; set; }


        public decimal PrecoTabelaSemImpostos
        { get; set; }


        public decimal PrecoTabelaAtacSemImpostos
        { get; set; }

        /// <summary>
        /// Precos sem impostos, calculado.
        /// Deve ser usado somente para fins de apresentacao. Para fins de calculo, usar o campo PrecoSemImpostos
        /// </summary>
        public decimal PrecoSemImpostosCalc
        {
            get
            {
                if (impostos != null)
                    return PrecoVenda - (impostos.ValorST + impostos.ValorIPI + impostos.ValorDiferencaAliquotas);
                else
                    return PrecoVenda;

            }
        }


        public decimal CustoFinanceiroEstoque
        { get; set; }

        public decimal QuantidadeFalta
        { get; set; }

        public CategoriaProduto Categoria
        { get; set; }


        public string CodigoPrincipal
        { get; set; }

        /// <summary>
        /// Informa se um determinado produto ja foi inserido no pedido
        /// </summary>
        public bool PreviamenteInseridoPedido
        { get; set; }

        public bool UtilizandoQuantidadeEmbalagem = false;


        public decimal PrecoBase
        { get; set; }


        public string TipoEstoque
        { get; set; }


        public decimal Multiplo
        {
            get { return _multiplo; }
            set { _multiplo = value; }
        }


        public decimal QuantidadeMaximaPorPedido
        { get; set; }

        /// <summary>
        /// Validar multiplo de venda na bonificacao
        /// </summary>

        public bool ChecarMultiploVendaBonificacao
        { get; set; }

        /// <summary>
        /// Quando verdadeiro, o sistema arredondará a quantidade para cima. Caso contrario, arredondará para baixo
        /// </summary>

        public bool UtilizaQtdeSuperiorMultipla
        { get; set; }


        public ProdutoPedido.FreteProduto Frete
        {
            get
            {
                if (frete == null)
                    frete = new FreteProduto();
                return frete;
            }
            set { frete = value; }
        }


        public decimal PrecoOriginal
        {
            get { return _precoOriginal; }
            set { _precoOriginal = value; }
        }


        public decimal PrecoVendaBase
        { get; set; }


        public decimal PrecoVenda0
        { get; set; }


        public decimal PrecoVenda1
        { get; set; }

        public decimal PrecoVenda2
        { get; set; }

        public decimal PrecoVenda3
        { get; set; }

        public decimal PrecoVenda4
        { get; set; }

        public decimal PrecoVenda5
        { get; set; }

        public decimal PrecoVenda6
        { get; set; }

        public decimal PrecoVenda7
        { get; set; }

        public decimal? PrecoVendaAtacado0
        { get; set; }

        public decimal? PrecoVendaAtacado1
        { get; set; }

        public decimal? PrecoVendaAtacado2
        { get; set; }

        public decimal? PrecoVendaAtacado3
        { get; set; }

        public decimal? PrecoVendaAtacado4
        { get; set; }

        public decimal? PrecoVendaAtacado5
        { get; set; }

        public decimal? PrecoVendaAtacado6
        { get; set; }

        public decimal? PrecoVendaAtacado7
        { get; set; }


        public ProdutoPedido.PoliticasComerciaisProduto PoliticasComerciais
        {
            get
            {
                if (politicasComerciais == null)
                    politicasComerciais = new PoliticasComerciaisProduto();
                return politicasComerciais;
            }
            set { politicasComerciais = value; }
        }


        public decimal PrecoTabelaBase
        { get; set; }


        public string Classe
        { get; set; }

        public uint CodigoBrinde
        { get; set; }

        public bool Brinde
        { get; set; }


        public decimal? PrecoMinimo
        { get; set; }

        public ProdutoPedido.HistoricoVendaProduto HistoricoVenda
        { get; set; }


        public string Complemento
        { get; set; }


        public string TipoComissao
        { get; set; }

        public string Marca
        { get; set; }

        public string CodigoMarca
        { get; set; }


        public bool SemCadastro
        { get; set; }


        public string Localizacao
        { get; set; }


        public string AceitaVendaFracionada
        { get; set; }


        public decimal CustoNotaFiscalSemST
        { get; set; }


        public decimal CustoNotaFiscalSemST_ST
        { get; set; }


        public bool Importado
        { get; set; }

        /// <summary>
        /// Contem o preco originalmente informado pelo Usuário, no momento da confecção do pedido
        /// </summary>

        public decimal? PrecoVendaInformado
        { get; set; }

        /// <summary>
        /// Contem o preco originalmente informado pelo Usuário, no momento da confecção do pedido
        /// </summary>

        public decimal? PrecoTabelaInformado
        { get; set; }

        /// <summary>
        /// Contem o preco originalmente informado pelo Usuário, no momento da confecção do pedido
        /// </summary>

        public decimal? PrecoBaseInformado
        { get; set; }


        public decimal PercFreteCMV
        { get; set; }


        public decimal PercImpostoFederal
        { get; set; }


        public decimal PercDescontoCusto
        { get; set; }


        public decimal CodigoICMTab
        { get; set; }


        public decimal ValorDescontoCustoCMV
        { get; set; }


        public string FilialRetira
        { get; set; }

        /// <summary>
        /// Posicao do pedido no momento em que o estoque foi processado
        /// </summary>
        public string PosicaoPedidoProcEstoque
        { get; set; }

        /// <summary>
        /// Relacao de embalagens disponiveis para utilizacao do produto, quando
        /// o recurso de venda por embalagem estiver disponivel
        /// </summary>
        public List<ProdutoPedido.EmbalagemProduto> EmbalagensDisponiveis
        { get; set; }

        /// <summary>
        /// Embalagem atualmente selecionada, quando a venda por embalagem estiver selecionada
        /// </summary>

        public EmbalagemProduto EmbalagemSelecionada
        {
            get
            {
                return embalagemSelecionada;
            }
            set
            {
                //if (value != null)
                //    this.Embalagem = value.Embalagem;
                embalagemSelecionada = value;
            }
        }


        public string CodigoBarras { get; set; }


        public string TipoMercadoria { get; set; }


        public decimal CustoContabilOriginal { get; set; }


        public decimal CustoFinanceiroEstoqueOriginal { get; set; }


        public decimal CustoFinanceiroOriginal { get; set; }


        public decimal CustoRealOriginal { get; set; }


        public decimal CustoReposicaoOriginal { get; set; }

        DadosUltimaEntradaProduto ultimaEntrada;


        public DadosUltimaEntradaProduto UltimaEntrada
        {
            get
            {
                if (ultimaEntrada == null)
                    ultimaEntrada = new DadosUltimaEntradaProduto();
                return ultimaEntrada;
            }
            set
            {
                ultimaEntrada = value;
            }
        }


        public bool UtilizandoPrecoAtacado { get; set; }


        public decimal PrecoFabrica { get; set; }


        public bool AplicouPoliticaDescontoAA { get; set; }


        public decimal PrecoMaximoConsumidor { get; set; }

        public byte[] PictureData { get; set; }


        public bool UtilizandoPrecoEmbalagem { get; set; }


        public string CodFabricante { get; set; }


        public List<ProdutoFilho> Filhos { get; set; }


        public PrecificacaoProduto Precificacao { get; set; }


        public bool ControladoIbama { get; set; }

        public decimal PercDescontoCC
        {
            get
            {
                if (PrecoBase != 0)
                    if (PrecoBase.Equals(0))
                        return 0;
                    else
                        return Math.Round((PrecoVenda - PrecoBase) / PrecoBase, 6) * -1;
                else
                    return 0;
            }
        }


        public decimal QuantidadeMaximaPorVenda { get; set; }


        public string NBM { get; set; }


        public decimal CustoReposicaoZonaFranca { get; set; }


        public decimal ValorRepasse { get; set; }


        public decimal ValorOutros { get; set; }


        public decimal PercBonificVenda
        { get; set; }


        public string NumOriginal
        { get; set; }


        public decimal PercDescontoBoleto
        { get; set; }


        public decimal ValorDescontoBoleto
        { get; set; }

        decimal currentFatorEmbalagem = 1;
        private decimal _multiplo;
        private decimal _custoFinanceiro;
        private decimal _custoReal;
        private decimal _precoOriginal;

        public decimal CurrentFatorEmbalagem
        {
            get
            {
                return currentFatorEmbalagem;
            }
            set
            {
                currentFatorEmbalagem = value;
            }
        }


        /// <summary>
        /// Obtem o fator de embalagem ativo de acordo com a configuracao atual do produto
        /// </summary>
        public decimal FatorEmbalagemAtual
        {

            get
            {
                decimal vFator;
                bool vEstoqueFrios = this.TipoEstoque != null && this.TipoEstoque.Equals("FR");

                if (!vEstoqueFrios)
                    vFator = this.EmbalagemSelecionada.Fator;
                else if (!this.EmbalagemSelecionada.Unidade.Equals("UN"))
                    vFator = this.EmbalagemSelecionada.QtUnit;
                else
                    vFator = this.EmbalagemSelecionada.Multiplo;

                return vFator;
            }

        }

        /// <summary>
        /// Obtem a quantidade do produto multiplicada pelo fator de embalagem vigente de acordo com a embalagem selecionada
        /// Utilizado, por exemplo, no calculo da quantidade que sera usada para aplicacao do desconto por quantidade percentual de desconto por quantidade
        /// </summary>
        /// <returns></returns>
        public decimal QuantidadeEmbalagem
        {

            get
            {

                return this.Quantidade * FatorEmbalagemAtual;

            }

        }


        public bool UsaPMCBaseST { get; set; }


        public string ImportadoValue { get; set; }

        /// <summary>
        /// Obtem a quantidade do produto na Unidade da Embalagem, desde que a quantidade esteja na quantidade minima (menor unidade)
        /// Utilizado, por exemplo, no processo de pronta entrega onde alimentamos a integradora com a quantidade em embalagem ao inves de quantidade
        /// minima
        /// </summary>
        public decimal QuantidadeEmbalagemInversa
        {
            get
            {
                return this.Quantidade / FatorEmbalagemAtual;
            }
        }

        public decimal EstoqueEmbalagemMaster
        {
            get
            {
                if (AceitaVendaFracionada.Equals("S"))
                    return EstoqueDisponivel / QtUnitCX;
                else
                    return Math.Round(EstoqueDisponivel / QtUnitCX);
            }

        }


        public decimal? ValorIPIPrecificado { get; set; }


        public decimal ValorUltimaEntradaMes { get; set; }


        public decimal ValorSTPrecificado { get; set; }

        public decimal PercDescontoSemImpostos()
        {
            return (PrecoVendaSemImpostos - PrecoVendCalcSemImpostos()) / PrecoVendaSemImpostos;
        }

        public decimal PrecoVendCalcSemImpostos()
        {
            return this.PrecoVenda - Impostos.ValorST - Impostos.ValorIPI;
        }

        public decimal PercDescontoInformadoBase { get; set; }

        public bool IsAlteraPrecoTabela { get; set; }

        public decimal PrecoVendaSemImpostosPorEntrada
        {
            get
            {
                return (PrecoTabela - Tributacao.ST.ValorSTEntrada - Tributacao.IPI.ValorIPIEntrada) *
                       (1 - PercDescontoInformado);
            }
        }

        public bool TemStIpiJaCalculado
        {
            get { return Tributacao.ST.ValorSTEntrada > 0 && Tributacao.IPI.ValorIPIEntrada > 0; }
        }

        public decimal PrecoVendaOriginal { get; set; }

        public decimal PrecoSemImpostoDePrecoTabela { get; set; }
        public string Confaz { get; set; }
        public bool PrecoFixo { get; set; }
        public uint PrazoMaxVenda { get; set; }
        public decimal MultiploOriginal { get; set; }

        public bool EhFrios
        {
            get { return (TipoEstoque ?? "").Equals("FR"); }
        }

        public bool ReducaoSimplesNacional { get; set; }


        public decimal PBonific { get; set; }


        public bool ItemBonificado { get; set; }


        public string TipoEntrega { get; set; }


        public OrigemComissaoProduto OrigemComissao { get; set; }


        public string NaturezaProduto { get; set; }


        public bool ProdutoComboPeg { get; set; }


        public bool ProdutoDescontoProgressivo { get; set; }


        public decimal? PercMegaDesconto { get; set; }


        public string MensagemCota { get; set; }

        #endregion

        public uint ObterCodigoDesconto()
        {
            uint vCodigoPoliticaDesconto = 0;

            if (PoliticasComerciais.PoliticaDescontoComercial != null)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaDescontoComercial.CodigoPolitica);
            else if (PoliticasComerciais.PoliticaDescontoPorQuantidade != null)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaDescontoPorQuantidade.CodigoPolitica);
            else if (PoliticasComerciais.PoliticaAcrescimoComercial != null)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaAcrescimoComercial.CodigoPolitica);

            if (PoliticasComerciais.PoliticaDescontoComercial != null && PoliticasComerciais.PoliticaDescontoComercial.Prioritaria)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaDescontoComercial.CodigoPolitica);
            else if (PoliticasComerciais.PoliticaDescontoPorQuantidade != null && PoliticasComerciais.PoliticaDescontoPorQuantidade.Prioritaria)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaDescontoPorQuantidade.CodigoPolitica);
            else if (PoliticasComerciais.PoliticaAcrescimoComercial != null && PoliticasComerciais.PoliticaAcrescimoComercial.Prioritaria)
                vCodigoPoliticaDesconto.Equals(PoliticasComerciais.PoliticaAcrescimoComercial.CodigoPolitica);

            return vCodigoPoliticaDesconto;
        }


        public int mNumeroItemPedidoCliente { get; set; }


        public int codigoMotivoGarantia { get; set; }


        public int codDescontoSimulador { get; set; }


        public decimal PrecoSemImpostostemp { get; set; }


        public string DocNumItmNum
        { get; set; }



        public const string VersaoAPI = "v3";
        public const string Endpoint = "Produtos";
    }

    public class CategoriaProduto
    {
        public string Codigo
        { get; set; }

        public string Nome
        { get; set; }

    }

    public class DepartamentoProduto
    {
        public string Codigo
        { get; set; }

        public string Nome
        { get; set; }

        public bool Marcado { get; set; }
    }

    public class SecaoProduto
    {

        public string Codigo
        { get; set; }

        public string CodigoDepartamento
        { get; set; }

        public string Nome
        { get; set; }

        public bool Marcado { get; set; }
    }


}

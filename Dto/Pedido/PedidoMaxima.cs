using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class PedidoMaxima
    {
        #region Fields

        private List<AlertasPedido> alertas;
        private List<ProdutoPedido> produtos;
        public const string VersaoAPI = "v1";
        public const string Endpoint = "StatusPedidos/0,1,2,9/1,2";
        #endregion Fields

        #region Enumeracoes

        public static EnumPosicaoPedido PosicaoPedidoMapCharToEnum(string pPosicao)
        {
            switch (pPosicao)
            {
                case "P":
                    return (EnumPosicaoPedido.Pendente);

                case "B":
                    return (EnumPosicaoPedido.Bloqueado);

                case "L":
                    return (EnumPosicaoPedido.Liberado);

                case "M":
                    return (EnumPosicaoPedido.Montado);

                case "F":
                    return (EnumPosicaoPedido.Faturado);

                case "C":
                    return (EnumPosicaoPedido.Cancelado);

                case "T":
                    return (EnumPosicaoPedido.Temporario);

                case "X":
                    return (EnumPosicaoPedido.Desconhecido);

                default:
                    return (EnumPosicaoPedido.Outros);
            }
        }

        #endregion Enumeracoes


        #region Classes


        public class Movimentacao
        {
            public int? CodFuncLiberacao { get; set; }

            public string NomeFuncLiberacao { get; set; }

            public DateTime? DataLiberacao { get; set; }

            public int? CodFuncCancelamento { get; set; }

            public string NomeFuncCancelamento { get; set; }

            public DateTime? DataCancelamento { get; set; }

            public string Motivo { get; set; }

            public DateTime? DataEmissaoMapaSep { get; set; }

            public int? CodFuncEmissaoMapaSep { get; set; }

            public string NomeFuncEmissaoMapaSep { get; set; }

            public DateTime? DataInicialSep { get; set; }

            public DateTime? DataFinalSep { get; set; }

            public int? CodFuncSep { get; set; }

            public string NomeFuncSep { get; set; }

            public DateTime? DataInicialConf { get; set; }

            public DateTime? DataFinalConf { get; set; }

            public int? CodFuncConf { get; set; }

            public string NomeFuncConf { get; set; }

            public DateTime? DataFaturamento { get; set; }

            public int? CodFuncFaturamento { get; set; }

            public string NomeFuncFaturamento { get; set; }
        }

        public class JustificativaNaoVendaPrePedido
        {
            public int CodigoPrePedido { get; set; }

            public string CodigoProduto { get; set; }

            public string MotivoNaoVenda { get; set; }

            public decimal Quantidade { get; set; }

            public long? CodigoBarras { get; set; }
        }

        public class CartaoAutorizacao
        {
            public string CodigoTransacao { get; set; }

            public string CodigoPreAutorizacao { get; set; }

            public decimal ValorPreAutorizado { get; set; }

            public decimal ValorAutorizado { get; set; }

            public DateTime DataPreAutorizacao { get; set; }

            public DateTime? DataExpiracaoPreAutorizacao { get; set; }

            public string Bandeira { get; set; }

            public string NumeroCartaoCredito { get; set; }

            public string CodigoNSU { get; set; }

            public int NumeroParcelas { get; set; }

            public decimal ValorAutorizacao { get; set; }

            [IgnoreDataMember]
            public DateTime DataUltimaAlteracao { get; set; }

            [IgnoreDataMember]
            public string NomeRca { get; set; }

            [IgnoreDataMember]
            public string NomeCliente { get; set; }

            [IgnoreDataMember]
            public decimal ValorCancelado { get; set; }
        }

        /// <summary>
        /// Representa o status do Pedido Enviado
        /// </summary>

        public class StatusEnvio
        {
            public EnumStatusEnvio Valor { get; set; }

            public string Descricao { get; set; }
        }

        [Serializable]
        public class PedidoPaiMultifilial
        {
            public ulong NumeroPedido { get; set; }
            public decimal ValorTotal { get; set; }
            public decimal ValorTabela { get; set; }
        }

        /// <summary>
        /// Representa o status do Pedido, quanto ao seu processamento
        /// </summary>

        public class PosicaoPedido
        {
            /// <summary>
            /// Valor do Status do Pedido
            /// </summary>

            public EnumPosicaoPedido Valor { get; set; }

            /// <summary>
            /// Descricao do Status do Pedido
            /// </summary>

            public string Description { get; set; }

            /// <summary>
            /// Flag do Status do Pedido
            /// </summary>

            public string Flag { get; set; }
        }

        /// <summary>
        /// Representa o bloqueio comercial do Pedido, caso exista algum
        /// </summary>

        public class BloqueioComercialPedido
        {
            public int? CodigoBloqueio { get; set; }

            public int? CodigoMotivo { get; set; }

            public string Descricao { get; set; }

            // Tipo Comercial "C" ou Financeiro "F".
            public string Tipo { get; set; }

            public decimal ValorMaxPedido { get; set; }

            // 1 = FILIAL; 2 = PRAÇA; 3 = CLIENTE; 4 = COBRANÇA; 5 = PLANO DE PAGAMENTO; 6 = PRODUTO
            public int TipoBloqueioMult { get; set; }

            public string ValorDoTipoMult { get; set; }

            public string CodCob { get; set; }

            public string OrigemPed { get; set; }
        }

        /// <summary>
        /// Alertar gerados para o Pedido
        /// </summary>

        public class AlertasPedido
        {
            /// <summary>
            /// Codigo do Alerta
            /// </summary>

            public decimal Codigo { get; set; }

            /// <summary>
            /// Mensagem do Alerta
            /// </summary>

            public string Descricao { get; set; }

            /// <summary>
            /// Tipo do Alerta
            /// </summary>

            public AlertasPedidoTipos Tipo { get; set; }
        }

        /// <summary>
        /// Classe responsavel por tratar os parametros de configuracao do pedido
        /// </summary>

        public class ConfiguracoesPedido
        {
            /// <summary>
            /// Determina se o cliente utiliza a embalagem de unidade padrão definida em BLL.Produtos.DefinirEmbalagem
            /// </summary>

            public bool UsaEmbalagemUnidadePadrao { get; set; }

            public bool ManterPrecoSimplesNacional { get; set; }

            public bool UsarPedidoPorDistribuicao { get; set; }

            public string CodigoDistribuicao { get; set; }

            public bool UsarTributacaoPorUF { get; set; }

            public bool CalcularSTComIPI { get; set; }

            public decimal PercMaxVenda { get; set; }

            public bool UsarControleCaixaFechada { get; set; }

            public bool IncluirComissaoCMVVenda { get; set; }

            public ushort PrazoMaximoDataEntrega { get; set; }

            public ushort OrdemAvaliacaoComissaoRCA { get; set; }

            public bool UsarComissaoPorCliente { get; set; }

            public bool UsarComissaoPorRCA { get; set; }

            public bool ControlarComissaoTipoVenda { get; set; }

            public bool AceitaVendaSemEstoque { get; set; }

            public bool LiberarPedidoPendente { get; set; }

            public decimal PercImpostoFederal { get; set; }

            public bool AbaterImpostoComissaoRCA { get; set; }

            public bool AceitaVendaBloqueada { get; set; }

            public bool VerificarLimiteCreditoCobrancaDinheiro { get; set; }

            public decimal ValorMaximoPedidoVendaPF { get; set; }

            public decimal ValorMaximoPedidoVenda { get; set; }

            public bool BloquearPrazoMedioVenda { get; set; }

            public bool PermitePlanoPagamentoSuperior { get; set; }

            public decimal ValorMinimoVendaBoleto { get; set; }

            public string TipoValorMinimoVendaBoleto { get; set; }

            public string PosicaoPadrao { get; set; }

            public bool UsarPercFinanceiroPrecoPromocional { get; set; }

            public bool UsarDescontoPorQuantidade { get; set; }

            public bool UsarRestricoesVenda { get; set; }

            public string ExibirPrecoVenda { get; set; }

            public bool AceitaDescontoPrecoFixo { get; set; }

            public bool AceitaAcrescimoPrecoFixo { get; set; }

            public bool AceitaDescontoMaiorFlexivel { get; set; }

            public decimal PercMaximoDescontoMedio { get; set; }

            public bool ValidarPrecoMinimo { get; set; }

            public bool UsarComissaoPorLinhaDeProdutos { get; set; }

            public int PrazoValidadeOrcamento { get; set; }

            public bool BloqueiaVendaEstoquePendente { get; set; }

            public bool UsarChaveTriplaPCPEDI { get; set; }

            public string CodigoProdutoSemCadastro { get; set; }

            public bool ControlarSaldoRCA { get; set; }

            public bool UsarDebCredRCAVendasBonificadas { get; set; }

            public string TipoMovimentacaoContaCorrenteRCA { get; set; }

            public bool UsaSaldoContaCorrenteDescontoFinanceiro { get; set; }

            public bool GravarObsClienteNoPedido { get; set; }

            ///// <summary>
            ///// Numero de casas decimais que serao consideradas no calculo de informacoes monetarias
            ///// </summary>

            public ushort NumCasasDecimaisVenda { get; set; }

            public bool AceitaPessoaFisicaContribuinte { get; set; }

            public bool CalcularSTPessoaFisica { get; set; }

            public string TipoCalculoST { get; set; }

            public decimal Taxa0 { get; set; }

            public decimal Taxa7 { get; set; }

            public decimal Taxa14 { get; set; }

            public decimal Taxa21 { get; set; }

            public decimal Taxa28 { get; set; }

            public decimal Taxa35 { get; set; }

            public decimal Taxa42 { get; set; }

            public bool ConsideraIsentoComoPF { get; set; }

            public string TipoCalculoIPI { get; set; }

            public bool UsarPercBaseReducaoPF { get; set; }

            public string TipoCalculoSUFRAMA { get; set; }

            public bool AplicarIndiceCMV { get; set; }

            public bool ValidarPrecoVendaBonificacao { get; set; }

            public decimal ValorMaximoPedidoVendaBonificacao { get; set; }

            public bool UsarPrecoTabelaComoBase { get; set; }

            public bool BloquearPedidoVendaBonificado { get; set; }

            public bool BonificacaoAlteraSaldoDebitoCreditoRca { get; set; }

            public char ModoProcessamentoPedido { get; set; }

            public string TipoFretePadrao { get; set; }

            public string TipoDocumentoVenda { get; set; }

            public bool UtilizaVendaPorEmbalagem { get; set; }

            public bool UtilizaRestricaoDeptoSecao { get; set; }

            public bool AceitaDescontoAcimaPermitidoTelemarketing { get; set; }

            public bool AceitaDescontoAcimaPermitidoBalcaoReserva { get; set; }

            public bool AplicarAcrescimoPessoaJuridicaIsenta { get; set; }

            public bool DigitarPedidoClienteAlvaraVencido { get; set; }

            public bool BloquearVendaPessoaFisica { get; set; }

            public int NumDiasMinimoParaVendaBK { get; set; }

            public bool UtilizaPrecoPorEmbalagem { get; set; }

            public bool AcrescimoPessoaFisicaComInscricaoEstadual { get; set; }

            public bool UsaCadastroEmbalagemEmProdutosFrios { get; set; }

            public bool AbateFreteVendaBalcao { get; set; }

            public bool VerificarBloqueioSefaz { get; set; }

            public bool UsaFilialNFClienteParaDefinirTributacao { get; set; }

            public bool TruncarPrecoItem { get; set; }

            public bool BloquearPedidosComValorAcimaFV { get; set; }

            public bool InformarRecebedorVenda { get; set; }

            public bool AceitaVendaBloqueadaClienteBloqueado { get; set; }

            public bool AceitaVendaAvistaClienteBloqueado { get; set; }

            public bool SomarQtdPedVenda { get; set; }

            public bool ApresentaInformacoesDesconto { get; set; }

            public bool UtilizaPlanoRelacionadoCobranca { get; set; }
        }

        /// <summary>
        /// Classe que trata algumas informacoes quando o pedido estiver sendo tratado como orcamento
        /// </summary>

        public class OrcamentoPedido
        {
            /// <summary>
            /// Data de Validade desse orcamento
            /// </summary>

            public DateTime Validade { get; set; }

            /// <summary>
            /// Flag que informa se o orcamento ja foi utilizado ou nao.
            /// </summary>

            public bool Importado { get; set; }

            /// <summary>
            /// Numero do pedido gerado a partir desse orcamento
            /// </summary>

            public ulong? NumPedido { get; set; }

            /// <summary>
            /// Numero do Orcamento que gerou esse pedido
            /// </summary>

            public ulong? NumOrcamento { get; set; }
        }

        #endregion Classes

        #region Propriedades


        public bool GerouBrinde { get; set; }

        public bool GerouBrindeAutomatico { get; set; }

        public string CodigoUsuarioMaxima { get; set; }

        public string CodigoPedidoNuvem { get; set; }

        public bool? EhOrcamento { get; set; }

        public bool PedidoBloqueadoEnvioErp { get; set; }

        /// <summary>
        /// Codigo do usuário que montou o pedido
        /// </summary>

        public string CodUsuario { get; set; }

        public string CodUsur { get; set; }

        /// <summary>
        /// Numero do Pedido ou do Orcamento
        /// </summary>

        public string NumPedido { get; set; }

        public ulong? NumPedidoPreposto { get; set; }

        public UInt64 NumPedidoBrinde { get; set; }

        /// <summary>
        /// Data em que o pedido foi montado
        /// </summary>

        public DateTime Data { get; set; }

        /// <summary>
        /// Valor de Tabela do Pedido
        /// </summary>

        public decimal ValorTabela { get; set; }

        /// <summary>
        /// Valor Total do Pedido
        /// </summary>

        public decimal ValorTotal { get; set; }

        /// <summary>
        /// Valor de Entrada
        /// </summary>

        public decimal ValorEntrada { get; set; }

        /// <summary>
        /// Determina se irá gravar preço com ou sem o Fecp, recebido pelo Apk
        /// </summary>

        public string PVendaSemImposto { get; set; }

        /// <summary>
        /// Observacoes do pedido
        /// </summary>

        public string Observacao { get; set; }

        /// <summary>
        /// Quantidade de Itens do Pedido
        /// </summary>

        public ushort QtdeItens { get; set; }

        /// <summary>
        /// Quantidade de Volumes do Pedido
        /// </summary>

        public decimal QtdeVolumes { get; set; }

        /// <summary>
        /// Código do pedido pai pedido complementar.
        /// </summary>

        public long? CodigoPaiPedidoComplementar { get; set; }

        /// <summary>
        /// verifica se é pedido complementar.
        /// </summary>

        public bool? PedidoComplementar { get; set; }

        /// <summary>
        /// Cliente para o qual o pedido foi feito
        /// </summary>

        [JsonProperty("Cliente")]
        public ClienteMaximaCadastro Cliente { get; set; }

        public bool PartilhaIcms { get; set; }

        public PedidoPaiMultifilial PedidoPai { get; set; }

        public EnumStatusAutorizacao StatusAutorizacaoPreco { get; set; }

        public EnumStatusAutorizacao StatusAutorizacaoLucratividade { get; set; }

        public EnumStatusAutorizacao StatusAutorizacaoGeral { get; set; }

        public EnumStatusAutorizacao StatusAutorizacaoBonificacao { get; set; }

        public EnumStatusAutorizacao StatusAutorizacaoPedidoTroca { get; set; }

        public bool DebitaContaRca { get; set; }

        public bool AguardandoAlgumaAutorizacao
        {
            get
            {
                return StatusAutorizacaoPreco == EnumStatusAutorizacao.AguardandoAutorizacao
                    || StatusAutorizacaoLucratividade == EnumStatusAutorizacao.AguardandoAutorizacao
                    || StatusAutorizacaoGeral == EnumStatusAutorizacao.AguardandoAutorizacao
                    || StatusAutorizacaoBonificacao == EnumStatusAutorizacao.AguardandoAutorizacao
                    || StatusAutorizacaoPedidoTroca == EnumStatusAutorizacao.AguardandoAutorizacao;
            }
        }

        public bool AutorizacaoLucratividade { get; set; }

        public bool AutorizacaoBonificacao { get; set; }

        public bool AutorizacaoPedidoTroca { get; set; }

        public CartaoAutorizacao DadosCartaoPreAutorizacao { get; set; }

        public ComprovantePagamentoCartaoCredito RetornoPreAutorizacaoCartao { get; set; }

        /// <summary>
        /// Status do Pedido
        /// </summary>
        private PosicaoPedido posicao;

        public PosicaoPedido Posicao
        {
            get
            {
                if (posicao == null)
                    posicao = new PosicaoPedido();
                return posicao;
            }
            set { posicao = value; }
        }

        /// <summary>
        /// Percentual de Débito/Crédito
        /// </summary>
        public decimal PercDC
        {
            get
            {
                if (ValorTabela == 0)
                    return 0;
                else
                {
                    if (ValorAtendido != 0)
                        return (ValorTabela - ValorAtendido) / ValorTabela;
                    else
                        return (ValorTabela - ValorTotal) / ValorTabela;
                }
            }
        }

        /// <summary>
        /// Relação de cobrancas disponiveis
        /// </summary>
        [XmlIgnore()]
        public List<Cobranca> CobrancasDisponiveis { get; set; }

        /// <summary>
        /// Cobranca selecionada no pedido
        /// </summary>

        public Cobranca Cobranca { get; set; }

        /// <summary>
        /// Relacao de planos de pagamento disponiveis.
        /// </summary>
        [XmlIgnore()]
        public List<PlanoPagamentoPedido> PlanosPagamentoDisponiveis { get; set; }

        /// <summary>
        /// Plano de pagamento disponivel
        /// </summary>

        public PlanoPagamentoPedido PlanoPagamento { get; set; }

        /// <summary>
        /// Plano de pagamento com prazos flexiveis.
        /// </summary>

        public PlanoPagamentoPedido PlanoDePagamentoComPrazosFlexiveis { get; set; }

        /// <summary>
        /// Representante
        /// </summary>

        public RepresentanteMaxima Representante { get; set; }

        /// <summary>
        /// Sequencia atual dos produtos no pedido
        /// </summary>

        public ushort SequenciaAtual { get; set; }

        public bool Multifilial { get; set; }

        /// <summary>
        /// Colecao de produtos do pedido
        /// </summary>

        public List<ProdutoPedido> Produtos
        {
            get
            {
                if (produtos == null)
                    produtos = new List<ProdutoPedido>();
                return produtos;
            }
            set { produtos = value; }
        }

        /// <summary>
        /// Configuracoes do Pedido
        /// </summary>

        public ConfiguracoesPedido Configuracoes { get; set; }

        public string PrioridadeSeparacao { get; set; }

        public int? CodProfissionalVenda { get; set; }

        public int? CodProfissionalVenda2 { get; set; }

        public int? CodProfissionalVenda3 { get; set; }

        /// <summary>
        /// Relacao das filiais disponiveis
        /// </summary>
        [XmlIgnore()]
        public List<FilialPedido> FiliaisDisponiveis { get; set; }

        /// <summary>
        /// Relacao das filiais disponiveis
        /// </summary>
        [XmlIgnore()]
        public List<FilialPedido> FiliaisNFDisponiveis { get; set; }

        [XmlIgnore()]
        public List<FilialPedido> TodasFiliais { get; set; }

        /// <summary>
        /// FilialPedido utilizada pelo pedido
        /// </summary>

        [JsonProperty("Filial")]
        public FilialPedido FilialPedido { get; set; }

        /// <summary>
        /// FilialNF utilizada pelo pedido
        /// </summary>

        public FilialPedido FilialNF { get; set; }

        public string CodigoFilialNF { get; set; }

        /// <summary>
        /// Numero do Pedido gerado pelo ERP
        /// </summary>

        public string NumPedidoERP { get; set; }

        /// <summary>
        /// Numero do Pedido RCA
        /// </summary>

        public ulong NumPedidoRCA { get; set; }

        /// <summary>
        /// Numero do Pedido Bonificado
        /// </summary>

        public string NumPedBonific { get; set; }

        ///// <summary>
        ///// Valor da Comissao do Pedido
        ///// </summary>

        public decimal ValorComissao { get; set; }

        /// <summary>
        /// Peso Bruto do Pedido
        /// </summary>

        public decimal PesoBruto { get; set; }

        /// <summary>
        /// Peso Liquido do Pedido
        /// </summary>

        public decimal PesoLiquido { get; set; }

        /// <summary>
        /// Custo Contabil
        /// </summary>

        public decimal CustoContabil { get; set; }

        /// <summary>
        /// Custo Real
        /// </summary>

        public decimal CustoReal { get; set; }

        /// <summary>
        /// Custo Financeiro
        /// </summary>

        public decimal CustoFinanceiro { get; set; }

        /// <summary>
        /// Custo de reposicao
        /// </summary>

        public decimal CustoReposicao { get; set; }

        /// <summary>
        /// Valor do IPI
        /// </summary>

        public decimal ValorIPI { get; set; }

        public decimal PercDescontoPedido
        {
            get
            {
                var somaProdutoTabela = Produtos.Sum(x => x.PrecoTabelaInformado.GetValueOrDefault(0) * x.Quantidade);

                if (somaProdutoTabela == 0)
                {
                    return 0;
                }

                return (Math.Round((somaProdutoTabela - Produtos.Sum(x => x.PrecoVenda * x.Quantidade)) / somaProdutoTabela, 2)) * 100;
            }
        }

        /// <summary>
        /// Valor da Substituicao Tributaria
        /// </summary>
        public decimal ValorST { get; set; }

        /// <summary>
        /// Valor da base de ST
        /// </summary>

        public decimal ValorBaseST { get; set; }

        /// <summary>
        /// Observacoes de Entrega
        /// </summary>

        public string ObservacaoEntrega { get; set; }

        /// <summary>
        /// Percentual de lucratividade
        /// </summary>
        public decimal PercLucratividade
        {
            get
            {
                if (ValorTotal == 0)
                    return 0;
                else
                    return Lucratividade / ValorTotal;
            }
        }

        /// <summary>
        /// Percentual de lucratividade
        /// </summary>
        public decimal PercLucratividadeGestao
        {
            get
            {
                var valorDivisao = ValorTotal - ValorTotalBonificado;

                if (valorDivisao <= 0)
                {
                    return 0;
                }

                return Math.Round(((ValorTotal - ValorTotalBonificado) - CustoFinanceiro) / valorDivisao, 2);
            }
        }

        /// <summary>
        /// Lucratividade
        /// </summary>
        public decimal Lucratividade
        {
            get { return ValorTotal - CustoFinanceiro; }
        }

        /// <summary>
        /// Percentual de comissao
        /// </summary>
        public decimal PercComissao
        {
            get
            {
                if (ValorTotal == 0)
                    return 0;
                else
                    return ValorComissao / ValorTotal;
            }
        }

        /// <summary>
        /// Obtem o número da regiao padrão que está sendo utilizada pelo pedido, após verificar se o cliente possui regiao cadastrada
        /// </summary>
        public string NumRegiao
        {
            get
            {
                //Se o pedido utiliza uma região defaul (parametrizada no parâmetro 2398  da 132)
                if (Regiao != null)
                    return Regiao.Codigo;

                // Se a regiao atribuida à filial for nula, obtem a regiao da praca.
                if (FilialNF == null || FilialNF.NumRegiao == null)
                    return Cliente.Praca.Regiao.Codigo;
                else
                    return FilialNF.NumRegiao;
            }
        }

        public bool Cancelado { get; set; }

        /// <summary>
        /// Validação enviada pelo android para informar se o pedido é Broker
        /// </summary>

        public bool Broker { get; set; }

        /// <summary>
        /// Numero da tabela de preço do processo Broker
        /// </summary>

        public string NumeroTabela { get; set; }

        /// <summary>
        /// Código de estabelecimento do processo Broker
        /// </summary>

        public string CodigoEstabelecimento { get; set; }

        /// <summary>
        /// Data da Previsao de faturamento
        /// </summary>

        public DateTime? DataPrevisaoFaturamento { get; set; }

        /// <summary>
        /// Volume (M³) do pedido
        /// </summary>

        public decimal Volume { get; set; }

        /// <summary>
        /// Representa os alertas gerados para esse pedido
        /// </summary>

        /// <summary>
        /// Representa os alertas gerados para esse pedido
        /// </summary>
        public List<AlertasPedido> Alertas
        {
            get
            {
                if (alertas == null)
                    alertas = new List<AlertasPedido>();

                return alertas;
            }
            set { alertas = value; }
        }

        /// <summary>
        /// Tipos de venda disponiveis para uso
        /// </summary>
        [XmlIgnore]
        public List<TipoVenda> TiposVendaDisponiveis { get; set; }

        /// <summary>
        /// Tipo de Venda do Pedido
        /// </summary>

        public TipoVenda TipoVenda { get; set; }

        /// <summary>
        /// Numero do Pedido do Cliente
        /// </summary>

        public string NumPedidoCliente { get; set; }

        /// <summary>
        /// Codigo do Fornecedor de frete redespacho
        /// </summary>

        public uint? CodFornecedorRedespacho { get; set; }

        /// <summary>
        /// Codigo do cliente autorizado - CODCLIFNF
        /// </summary>

        public uint? CodClienteAutorizado { get; set; }

        /// <summary>
        /// Frete Despacho
        /// </summary>

        public string FreteDespacho { get; set; }

        /// <summary>
        /// Frete redespacho
        /// </summary>

        public string FreteRedespacho { get; set; }

        /// <summary>
        /// Transportadoras disponiveis
        /// </summary>
        [XmlIgnore()]
        public List<TransportadoraPedido> TransportadorasDisponiveis { get; set; }

        /// <summary>
        /// Transportadora despacho
        /// </summary>
        private TransportadoraPedido oTransportadoraDespacho;

        public TransportadoraPedido TransportadoraDespacho
        {
            get { return oTransportadoraDespacho; }
            set { oTransportadoraDespacho = value; }
        }

        /// <summary>
        /// Transportadora Redespacho
        /// </summary>

        public TransportadoraPedido TransportadoraRedespacho { get; set; }

        /// <summary>
        /// Valor de Frete
        /// </summary>

        public decimal ValorFrete { get; set; }

        /// <summary>
        /// Percentual de Frete
        /// </summary>
        public decimal PercFrete
        {
            get
            {
                if (ValorTotal != 0)
                    return ValorFrete / ValorTotal;
                else
                    return 1;
            }
        }

        /// <summary>
        /// Frete
        /// </summary>

        public Frete Frete { get; set; }

        private string origemPedido;

        /// <summary>
        /// Origem do Pedido
        /// </summary>

        public string OrigemPedido
        {
            get
            {
                if (Configuracoes != null && Configuracoes.ModoProcessamentoPedido == 'R')
                    return "R";
                else
                    return origemPedido;
            }
            set { origemPedido = value; }
        }

        /// <summary>
        /// Dados do orcamento que originou esse pedido, ou do orcamento carregado atualmente
        /// </summary>

        public PedidoMaxima.OrcamentoPedido Orcamento { get; set; }

        /// <summary>
        /// Valor de outras despesas
        /// </summary>

        public decimal ValorOutrasDespesas { get; set; }

        /// <summary>
        /// Valor dos produtos do Pedido
        /// </summary>
        public decimal ValorProdutos
        {
            get { return ValorTotal - (ValorOutrasDespesas + ValorFrete); }
        }

        /// <summary>
        /// Numero do Carregamento
        /// </summary>

        public string NumCarregamento { get; set; }

        /// <summary>
        /// Numero da Nota Fiscal
        /// </summary>

        public ulong? NumNotaFiscal { get; set; }

        /// <summary>
        /// Informacoes sobre o Bloqueio Comercial aplicado ao pedido
        /// </summary>

        public List<PedidoMaxima.BloqueioComercialPedido> BloqueioComercial { get; set; }

        /// <summary>
        /// Posicao do Pedido
        /// </summary>
        private StatusEnvio status;

        public StatusEnvio Status
        {
            get
            {
                if (status == null)
                    status = new StatusEnvio();
                return status;
            }
            set { status = value; }
        }

        public decimal ValorAtendido { get; set; }

        public decimal ObterValorAtendido()
        {
            if (TipoVenda == null)
            {
                return 0;
            }

            return TipoVenda.IsBonificacao || TipoVenda.Codigo.Equals(20)
                ? 0
                : ValorAtendido == 0
                    ? ValorTotal
                    : ValorAtendido;
        }

        public bool UtilizaVendaPorEmbalagem
        {
            get { return FilialPedido.UtilizaVendaPorEmbalagem || Configuracoes.UtilizaVendaPorEmbalagem; }
        }

        public decimal PercPoliticaComercialGlobal { get; set; }

        public decimal ValorSaldoCC { get; set; }

        /// <summary>
        /// Quantidade de Itens cesta no pedido
        /// </summary>
        public int QtdeItensCesta { get; set; }

        public decimal ValorCreditoDisponivel
        {
            get
            {
                if (Cliente == null || Cliente.Credito == null)
                    return 0;
                else
                    return Cliente.Credito.Disponivel - ValorTotal;
            }
        }

        /// <summary>
        /// Data de abertura do pedido no sistema
        /// </summary>
        /// <remarks>Tarefa 157194</remarks>

        public DateTime? DataAberturaPedido { get; set; }

        /// <summary>
        /// Data de fechamento do pedido no sistema
        /// </summary>
        /// <remarks>Tarefa 157194</remarks>

        public DateTime? DataFechamentoPedido { get; set; }

        public ulong? NumPedidoTV1 { get; set; }

        public ulong? NumPedidoTV7 { get; set; }

        public ulong NumPedidoWinThor { get; set; }

        public decimal ValorTabelaBase { get; set; }

        public decimal PercAbatimento { get; set; }

        public decimal ValorAbatimento { get; set; }

        public decimal PercDescontoCabecalho { get; set; }

        public string UFDesembaraco { get; set; }

        public string LocalDesembaraco { get; set; }

        public string HashCode { get; set; }

        public int? TipoBonificacao { get; set; }

        /// <summary>
        /// Objeto Bonificação para obter os dados da APK.
        /// </summary>

        public TipoBonificacao tipoBonificObjeto;

        public int? CFOPBonificacao { get; set; }

        public bool UsaFilialEspecifica { get; set; }

        public Critica UltimaCritica { get; set; }

        public GeoLocation GeoLocalizacao { get; set; }

        public bool Agrupamento { get; set; }

        //public Cotacao Cotacao { get; set; }


        public string Motorista { get; set; }

        public long DataRecalculoAlertas { get; set; }

        public ClienteMaximaCadastro.EnderecoEntrega EnderecoEntrega { get; set; }

        /// <summary>
        /// Informa se esse pedido é foi gerado a partir dos cortes de outro pedido
        /// </summary>

        public bool PedidoCortes { get; set; }

        public Movimentacao MovimentacaoPedido { get; set; }

        public RegiaoMaxima Regiao { get; set; }

        public decimal PercDescontoBoleto { get; set; }

        //public NotaFiscalTV14 DadosProntaEntrega { get; set; }


        public string CodCliRecebedor { get; set; }

        // public DadosConsumidorFinal DadosConsumidorFinal { get; set; }

        public decimal ValorOutrasDespesasPorProduto
        {
            get
            {
                return ValorOutrasDespesas != 0 && QtdeVolumes != 0
                    ? Math.Round(TruncateDecimal((ValorOutrasDespesas * PlanoPagamento.GetNumeroParcelas()) / QtdeVolumes, 2), 6)
                    : 0;
            }
        }

        public bool JaLancouDiferenca { get; set; }

        public decimal ObtenhaDiferencaValorTruncadoValorTotalDespesas()
        {
            return (ValorOutrasDespesas * PlanoPagamento.GetNumeroParcelas()) - (ValorOutrasDespesasPorProduto * QtdeVolumes);
        }

        public bool EhProdutoDeMaiorValor(ProdutoPedido produto)
        {
            return produto.PrecoVenda >= produtos.Max(x => x.PrecoVenda);
        }

        private decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            int tmp = (int)Math.Truncate(step * value);
            return tmp / step;
        }

        public bool VendaInterEstadual
        {
            get
            {
                if (Cliente == null || Cliente.Endereco == null || FilialPedido == null || FilialPedido.Endereco == null)
                    return false;

                return Cliente.Endereco.UF != FilialPedido.Endereco.UF;
            }
        }

        public bool Editado { get; set; }

        public decimal ValorTotalImpostos { get; set; }

        /// <summary>
        /// Uid registro do pedido
        /// </summary>

        public int? Uidregistro { get; set; }

        public decimal ValorTotalBonificado { get; set; }

        public bool VendaAssistida { get; set; }

        public List<JustificativaNaoVendaPrePedido> JustificativasNaoVenda { get; set; }

        public bool FreteJaInclusoNoValorTotal
        {
            get
            {
                var valorTotalProdutos = Produtos.Sum(x => x.PrecoVenda * x.Quantidade);

                if (
                    Math.Round((valorTotalProdutos + ValorOutrasDespesas), Configuracoes.NumCasasDecimaisVenda)
                    < Math.Round(ValorTotal, Configuracoes.NumCasasDecimaisVenda)
                )
                    return true;

                return false;
            }
        }

        #endregion Propriedades


        public bool ComboSku { get; set; }

        public string CondFinac { get; set; }

        public Dictionary<string, object> Parametros { get; set; }

        public DateTime? DataAutorizacao { get; set; }

        // [IgnoreDataMember]
        // public MovimentacaoCartaoCredito MovimentacaoCartaoCredito { get; set; }

        [IgnoreDataMember]
        public bool SolicitouAutorizacaoDePreco { get; set; }

        [IgnoreDataMember]
        public List<long> CodigosSupervisoresGestao { get; set; }
    }

    public class TipoVenda
    {
        public ushort Codigo { get; set; }

        public string Descricao { get; set; }

        public decimal PercVenda { get; set; }

        public bool IsBonificacao
        {
            get { return (Codigo.Equals(5) || Codigo.Equals(11)); }
        }

        public bool IsOnlyBonificacao
        {
            get { return Codigo.Equals(5); }
        }

        public bool IsTroca
        {
            get { return (Codigo.Equals(11) || Codigo.Equals(12)); }
        }
    }

    public class Frete
    {
        public ushort CodigoFrete { get; set; }

        public string CodigoTransportadora { get; set; }

        public string CodigoPracaOrigem { get; set; }

        public string CodigoPracaDestino { get; set; }

        public decimal PercFrete { get; set; }

        public decimal ValorFreteKgExcedente { get; set; }

        public decimal ValorMinimo { get; set; }

        public decimal AliqICMS { get; set; }

        /// <summary>
        /// Valor do Frete informado manualmente pelo usuário
        /// </summary>

        public decimal? ValorFreteUsuario { get; set; }

        /// <summary>
        /// Data/Hora em que o valor do frete foi informado manualmente pelo usuário
        /// </summary>

        public System.DateTime? DataCalculoFreteUsuario { get; set; }
    }

    public class TipoBonificacao
    {
        #region Propriedades

        /// <summary>
        /// Código de Bonificação
        /// </summary>

        public string CodigoBonificacao { get; set; }

        /// <summary>
        /// Descricao da Bonificação
        /// </summary>

        public string Descricao { get; set; }

        public bool? MovimentaCCRCA { get; set; }

        public bool? BonifPadrao { get; set; }

        public bool? CalculaIPI { get; set; }

        #endregion
    }
}

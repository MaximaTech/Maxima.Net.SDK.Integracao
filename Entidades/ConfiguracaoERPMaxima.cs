using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as configurações do ERP.
    /// </summary>
    public class ConfiguracaoERPMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ConfiguracoesErp";
        internal const string Tabela = "MXSCONFIGERP";

        /// <summary>
        /// Chave do cliente máxima.
        /// </summary>
        /// <value></value>
        [PropriedadePK]
        [JsonProperty("CodCliPc")]
        public int CodigoClienteMaxima { get; set; }

        /// <summary>
        /// Abate impostos do cálculo da comissão - Parâmetro Geral. Quando marcado como Sim os Impostos (ST e IPI) serão abatidos da Base de Comissão.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Abaterimpostoscomissaorca")]
        [RangeString("S", "N")]
        public string AbaterImpostoComissaoVendedor { get; set; }

        /// <summary>
        /// Aceita acréscimo sobre o preço fixo.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Aceitaacrescimoprecofixo")]
        [RangeString("S", "N")]
        public string AceitaAcrescimoPrecoFixo { get; set; }

        /// <summary>
        /// Aceita desconto sobre o preço fixo.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Aceitadescprecofixo")]
        [RangeString("S", "N")]
        public string AceitaDescontoPrecoFixo { get; set; }

        /// <summary>
        /// Aceitar desconto maior que o flexível na venda normal.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Aceitadesctmk")]
        [RangeString("S", "N")]
        public string AceitaDescontoMaiorQueFlexivel { get; set; }

        /// <summary>
        /// Aceitar venda sem estoque, default "S".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Aceitavendasemest")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string AceitaVendaSemEstoque { get; set; }

        /// <summary>
        /// Aceitar pedido de venda Bloqueado.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Aceitavendabloq")]
        [RangeString("S", "N")]
        public string AceitaVendaPedidoBloqueado { get; set; }

        /// <summary>
        /// Bloquear prazo médio de venda.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Bloqprazomdvenda")]
        [RangeString("S", "N")]
        public string BloquearPrazoMedioVenda { get; set; }

        /// <summary>
        /// Bloquear pedido bonificado no Força de Vendas.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Bloquearpedbonific")]
        [RangeString("S", "N")]
        public string BloquearPedidoBonificadoNoForcaVenda { get; set; }

        /// <summary>
        /// Usar déb./créd. RCA nas vendas bonificadas.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Bonificaltdebcredrca")]
        [RangeString("S", "N")]
        public string UsaDebitoCreditoVendedorVendaBonificada { get; set; }

        /// <summary>
        /// Calcular ST fonte para pessoa física. default "N"
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Calcstfontepf")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string CalculaStFontePessoaFisica { get; set; }

        /// <summary>
        /// Calcular ST para pessoa física, default "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Calcstpf")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string CalculaStPessoaFisica { get; set; }

        /// <summary>
        /// Calcular preço de venda com IPI, default "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Calcularstcomipi")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string CalculaStComIpi { get; set; }

        /// <summary>
        /// Gravar observação de cliente no pedido.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Gravarobsclientenopedido")]
        [RangeString("S", "N")]
        public string GravarObsClienteNoPedido { get; set; }

        /// <summary>
        /// Incluir comissão RCA no cálculo do CMV da venda.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Incluircomissaocmvvenda")]
        [RangeString("S", "N")]
        public string IncluirComissaoCmvVenda { get; set; }

        /// <summary>
        /// Nº de casas decimais estoque.
        /// </summary>
        [JsonProperty("Numcasasdecestoque")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 99)]
        public int? NumeroCasasDecimaisEstoque { get; set; }

        /// <summary>
        /// Nº de casas decimais preço de venda.
        /// </summary>
        [JsonProperty("Numcasasdecvenda")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 99)]
        public int? NumeroCasasDecimaisVenda { get; set; }

        /// <summary>
        /// Aceitar venda de clientes em atraso até X dias.
        /// </summary>
        [JsonProperty("Numdiasmaxvendacliinadimplente")]
        [ValorEntre(0, 999999)]
        public int? NumeroDiasMaximoVendaClienteInadimplente { get; set; }

        /// <summary>
        /// Porcentagem máximo de desconto Médio nos Orçamentos e Pedidos Venda.
        /// </summary>
        [JsonProperty("Permaxdescvenda")]
        [ValorEntre(0, 999.99)]
        public double? PercentualMaximoDescontoVenda { get; set; }

        /// <summary>
        /// Percentual máximo de acréscimo na venda.
        /// </summary>
        [JsonProperty("Permaxvenda")]
        [ValorEntre(0, 999999999999.999999)]
        public double? PercentualMaximoAcrescimoVenda { get; set; }

        /// <summary>
        /// Permiti alterar cobrança na venda.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Permitealtcodcobvenda")]
        [RangeString("S", "N")]
        public string PermiteAlterarCobrancaNaVenda { get; set; }

        /// <summary>
        /// Permite alterar o plano de pagamento na venda.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Permitealtplpagvenda")]
        [RangeString("S", "N")]
        public string PermiteAlterarPlanoPagamentoNaVenda { get; set; }

        /// <summary>
        /// Permite plano de pagamento supervisor.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Permiteplpagtosuperior")]
        [RangeString("S", "N")]
        public string PermitePlanoPagamentoSuperior { get; set; }

        /// <summary>
        /// Número de dias máximo para previsão do faturamento.
        /// </summary>
        [JsonProperty("Prazomaxdtentrega")]
        [ValorEntre(0, 999)]
        public int? PrazoMaximoDiasEntrega { get; set; }

        /// <summary>
        /// Prazo de validade do orçamento em dias.
        /// </summary>
        [JsonProperty("Prazovalidadeorcamento")]
        [ValorEntre(0, 9999)]
        public int? PrazoValidadeOrcamento { get; set; }

        /// <summary>
        ///<br>Cálculo de IPI - Parâmetro Geral. Permite a definição de com quantas casas decimais é gravado o IPI.</br>
        ///<br>Se selecionada opção "Conf. Casas Dec. Venda (PV)", o número de casas decimais que irá gravar o IPI será</br>
        ///<br>conforme o definido no parâmetro “NUMCASASDECVENDA” - Número de casas decimais preço de venda.</br>
        ///<br>Se selecionada opção "Arredondar para 2 casas decimais (A2)", o IPI é gravado com arredondamento para duas casas decimais.</br>
        /// </summary>
        /// <value>PV ou A2</value>
        [JsonProperty("Tipocalcipi")]
        [CampoObrigatorioAoInserir]
        [RangeString("PV", "A2")]
        public string TipoCalculoIpi { get; set; }

        /// <summary>
        ///<br>Cálculo de ST - Parâmetro Geral. Permite a definição de com quantas casas decimais é gravado o ST - Substituição Tributária.</br>
        ///<br>Se selecionada opção "Conf. Casas Dec. Venda (PV)", o número de casas decimais</br>
        ///<br>que será gravado no ST é definido no parâmetro “NUMCASASDECVENDA” - Número de casas decimais</br>
        ///<br>preço de venda. Se selecionada opção "Arredondar para 2 casas decimais (A2)" o ST é gravado com arredondamento para 2 casas decimais.</br>
        /// </summary>
        /// <value>PV ou A2</value>
        [JsonProperty("Tipocalcst")]
        [CampoObrigatorioAoInserir]
        [RangeString("PV", "A2")]
        public string TipoCalculoSt { get; set; }

        /// <summary>
        ///<br>Tipo de movimentação de conta corrente do RCA - É obrigatório informar este parâmetro para que a</br>
        ///<br>validação do desconto financeiro na venda seja aplicada corretamente no saldo de conta corrente do</br>
        ///<br>RCA. Rotinas de venda, alteração de vendas e faturamento deverão ser atualizados. Débito/Crédito</br>
        ///<br>no faturamento (FF) Débito na venda, crédito no acerto (VA)</br>
        ///<br>Débito na venda, crédito no faturamento (VF) Débito/Crédito na venda (VV)</br>
        /// </summary>
        /// <value>FF - VA - VF - VV</value>
        [JsonProperty("Tipomovccrca")]
        [CampoObrigatorioAoInserir]
        [RangeString("FF", "VA", "VF", "VV")]
        public string TipoMovimentacaoContaCorrenteVendedor { get; set; }

        /// <summary>
        /// Tipo Valor minimo venda boleto.
        /// </summary>
        [JsonProperty("Tipovlminvendabk")]
        public string TipoValorMinimoVenda { get; set; }

        /// <summary>
        /// Usar comissão por cliente.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usacomissaoporcliente")]
        [RangeString("S", "N")]
        public string UtilizaComissaoPorCliente { get; set; }

        /// <summary>
        /// Usar comissão por linha de produto.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usacomissaoporlinhaprod")]
        [RangeString("S", "N")]
        public string UtilizaComissaoPorLinhaDeProduto { get; set; }

        /// <summary>
        /// Usar comissão por RCA.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usacomissaoporrca")]
        [RangeString("S", "N")]
        public string UtilizaComissaoPorVendedor { get; set; }

        /// <summary>
        /// Utiliza o processo de conta corrente.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usacredrca")]
        [RangeString("S", "N")]
        public string UtilizaProcessoDeContaCorrente { get; set; }

        /// <summary>
        /// Utiliza desconto por quantidade.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usadescporquant")]
        [RangeString("S", "N")]
        public string UtilizaDescontoPorQuantidade { get; set; }

        /// <summary>
        /// Utiliza preço bruto como base para cálculo de déb./créd. RCA nas vendas bonificadas.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usaptabelacomobase")]
        [RangeString("S", "N")]
        public string UtilizaPrecoTabelaComoBaseContaCorrente { get; set; }

        /// <summary>
        /// Utiliza tributação por estado (UF), default "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Usatributacaoporuf")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string UtilizaTributacaopPorUf { get; set; }

        /// <summary>
        /// Utiliza redução da base de ICMS para pessoa física.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Utilizapercbaseredpf")]
        [RangeString("S", "N")]
        public string UtilizaPercentualBaseReducaoPessoaFisica { get; set; }

        /// <summary>
        /// Utiliza venda por embalagem, default "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Utilizavendaporembalagem")]
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string UtilizaVendaPorEmbalagem { get; set; }

        /// <summary>
        /// Validar preço mínimo, default "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Validaprecominimo")]
        [RangeString("S", "N")]
        public string ValidaPrecoMinimo { get; set; }

        /// <summary>
        /// Validar preço na bonificação.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Validapvendabonific")]
        [RangeString("S", "N")]
        public string ValidaPrecoVendaBonificada { get; set; }

        /// <summary>
        /// Valor máximo de pedido para pessoa física (reais).
        /// </summary>
        [JsonProperty("Vlmaxpedidopf")]
        public double? ValorMaximoPedidoPessoaFisica { get; set; }

        /// <summary>
        /// Valor máximo de venda (reais) - O parâmetro só é válido se for maior que 0. Se for igual a 0, estará
        ///desabilitado. Os pedidos com valor acima do máximo são gravados como bloqueados.
        /// </summary>
        [JsonProperty("Vlmaxvenda")]
        public double? ValorMaximoVenda { get; set; }

        /// <summary>
        /// Valor máximo para venda bonificada.
        /// </summary>
        [JsonProperty("Vlmaxvendabnf")]
        public double? ValorMaximoVendaBonificada { get; set; }

        /// <summary>
        /// Valor máximo para pessoa física (Mês).
        /// </summary>
        [JsonProperty("Vlmaxvendapf")]
        public double? ValorMaximoVendaPessoaFisica { get; set; }

        /// <summary>
        /// Valor mínimo pedido de venda.
        /// </summary>
        [JsonProperty("Vlminvenda")]
        public double? ValorMinimoVenda { get; set; }

        /// <summary>
        /// Valor mín. venda boleto bancário.
        /// </summary>
        [JsonProperty("Vlminvendabk")]
        public double? ValorMinimoVendaBoleto { get; set; }

        /// <summary>
        /// Valor mínimo para venda bonificada.
        /// </summary>
        [JsonProperty("Vlminvendabnf")]
        public double? ValorMinimoVendaBonificada { get; set; }

    }
}

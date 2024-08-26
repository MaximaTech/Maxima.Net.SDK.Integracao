using System;
using Maxima.Net.SDK.Integracao.Entidades;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    /// <summary>
    /// Entidade que armazena os históricos de pedidos.
    /// </summary>
    public class HistoricoPedidoCapa
    {
        /// <summary>
        /// Número do pedido do ERP
        /// </summary>
        [PropriedadePK]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int NumeroPedido { get; set; }

        [CampoObrigatorioAoInserir]
        public DateTime? Data { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Vltotal")]
        public decimal? ValorTotal { get; set; }

        [JsonIgnore]
        public string CodigoPedidoNuvem { get; set; }

        /// <summary>
        /// Valor total do pedido para o preço de tabela, com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vltabela")]
        public decimal? ValorTabela { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlatend")]
        public decimal? ValorAtendido { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlfrete")]
        public decimal? ValorFrete { get; set; }

        /// <summary>
        /// Define qual foi o tipo de venda do pedido.
        /// </summary>
        /// <value>1 – Venda Normal, 5 – Bonificação, 7 - Venda Futura, 11 – Troca, 13 – NF Manifesto (Saída), 14 – Venda Manifesto (Pronta-Entrega), 24 – Bonificação (Pronta-Entrega)</value>
        [CampoObrigatorioAoInserir]
        [RangeNumber(1, 5, 7, 11, 13, 14, 24)]
        [JsonProperty("Condvenda")]
        public int? TipoVenda { get; set; }

        /// <summary>
        /// Número da nota fiscal. Obrigatório se maxRoteirizador ou maxMotorista.
        /// </summary>
        /// <value>Um valor inteiro maior que zero.</value>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numnota")]
        public int? NumeroNotaFiscal { get; set; }

        [JsonProperty("Dtfat")]
        public DateTime? DataFaturamento { get; set; }

        /// <summary>
        /// Peso total das mercadorias do pedido.
        /// </summary>
        [JsonProperty("Totpeso")]
        public decimal? TotalPeso { get; set; }

        /// <summary>
        /// Número do pedido do vendedor (controle interno).
        /// </summary>
        /// <value></value>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numpedrca")]
        public int? NumeroPedidoRca { get; set; }

        /// <summary>
        /// Volume total do pedido. Obrigatório se maxRoteirização.
        /// </summary>
        [JsonProperty("Totvolume")]
        public decimal? TotalVolume { get; set; }

        /// <summary>
        /// Número de transação da venda, indentificador unico, pode ser o mesmo número do pedido caso não tenha essa numeração.
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numtransvenda")]
        public int? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Número de sequenciamento da entrega.
        /// </summary>
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Numseqentrega")]
        public long? NumeroSequenciaEntrega { get; set; }

        /// <summary>
        /// Código do endereço de entrega. Com limite de até 50 caracteres.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codendentcli")]
        public string CodigoEnderecoEntregaCliente { get; set; }

        /// <summary>
        /// Total de itens do pedido.
        /// </summary>
        [ValorEntre(0, 999999)]
        [JsonProperty("Numitens")]
        public int? TotalItens { get; set; }

        /// <summary>
        /// Código do cliente do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(
            ClienteMaxima.VersaoAPI,
            ClienteMaxima.EndPoint,
            ClienteMaxima.Tabela,
            typeof(ClienteMaxima)
        )]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do vendedor do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(
            VendedorMaxima.VersaoAPI,
            VendedorMaxima.EndPoint,
            VendedorMaxima.Tabela,
            typeof(VendedorMaxima)
        )]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Número do carregamento do pedido.
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numcar")]
        [PropriedadeFK(
            CarregamentoMaxima.VersaoAPI,
            CarregamentoMaxima.EndPoint,
            CarregamentoMaxima.Tabela,
            typeof(CarregamentoMaxima)
        )]
        public string NumeroCarregamento { get; set; }

        /// <summary>
        /// Código do plano de pagamento do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(
            PlanoPagamentoMaxima.VersaoAPI,
            PlanoPagamentoMaxima.EndPoint,
            PlanoPagamentoMaxima.Tabela,
            typeof(PlanoPagamentoMaxima)
        )]
        public string CodigoPlanoDePagamento { get; set; }

        [TamanhoMaximo(100)]
        [JsonProperty("Obs1")]
        public string Observacao1 { get; set; }

        [TamanhoMaximo(100)]
        [JsonProperty("Obs2")]
        public string Observacao2 { get; set; }

        [TamanhoMaximo(100)]
        [JsonProperty("Obsentrega1")]
        public string ObservacaoEntrega1 { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(
            FilialMaxima.VersaoAPI,
            FilialMaxima.EndPoint,
            FilialMaxima.Tabela,
            typeof(FilialMaxima)
        )]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define a posição atual do pedido.
        /// </summary>
        /// <value>F - Faturado, M - Montado, P - Pendente, C - Cancelado.</value>
        [TamanhoMaximo(4000)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Posicao")]
        public string PosicaoPedido { get; set; }

        /// <summary>
        /// Define para qual cobrança o pedido foi feito. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de cobranças.</value>
        [TamanhoMaximo(4000)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(
            CobrancaMaxima.VersaoAPI,
            CobrancaMaxima.EndPoint,
            CobrancaMaxima.Tabela,
            typeof(CobrancaMaxima)
        )]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Define qual a origem do pedido com preenchimento obrigatório.
        /// </summary>
        /// <value>T - Telemarketing, F – Forca Venda, W – Web, R – Balcão Reserva, B – Balcão </value>
        [RangeString("T", "F", "W", "R", "B")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Origemped")]
        public string OrigemPedido { get; set; }

        /// <summary>
        /// Define se o pedido é restrito por tipo de transporte, o campo recebe os valores S, N, R ou C..
        /// </summary>
        /// <value> S – Inflamáveis, N – Normal, R – Refrigerado, C – Congelados</value>
        [RangeString("S", "N", "R", "C")]
        [JsonProperty("RestricaoTransp")]
        public string RestricaoTransporte { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Obs")]
        public string Observacao { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Obsentrega")]
        public string ObservacaoEntrega { get; set; }

        /// <summary>
        /// Define o código do supervisor
        /// </summary>
        /// <value></value>
        [JsonProperty("Codsupervisor")]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Define o percentual de comissão do pedido
        /// </summary>
        /// <value></value>
        [JsonProperty("Percom")]
        public decimal? ValorPercentualComissao { get; set; }

        /// <summary>
        /// Define o valor da comissão do pedido
        /// </summary>
        /// <value></value>
        [JsonProperty("Comissao")]
        public decimal? ValorComissao { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "HistoricosPedidosCapas";
        internal const string Tabela = "MXSHISTORICOPEDC";
    }
}

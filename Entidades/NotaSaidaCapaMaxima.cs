using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a capa da nota fiscal.
    /// </summary>
    public class NotaSaidaCapaMaxima
    {
        /// <summary>
        /// Define o número da transação.
        /// </summary>
        /// <value>Sequencial único, que não se repete e que seja um identificador do cabeçalho da nota (Sequence, ROWID, ID e etc)</value>
        [PropriedadePK]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numtransvenda")]
        public int? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Define a data da saída da NF. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtsaida")]
        public DateTime? DataSaida { get; set; }

        /// <summary>
        /// Define o código da filial. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Código da filial referente ao cadastro da filial.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define o número da nota fiscal.
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numnota")]
        public int NumeroNota { get; set; }

        /// <summary>
        /// Define o número do pedido do ERP.
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int NumeroPedido { get; set; }

        /// <summary>
        /// Define qual o tipo da venda.
        /// </summary>
        /// <value> 1 – Venda Normal, 5 – Bonificação, 7 – Venda Futura, 11 – Troca, 13 – NF Manifesto (Saída/Mãe), 14 – Venda Manifesto (Pronta-Entrega), 24 – Bonificação (Pronta-Entrega).</value>
        [RangeNumber(1, 5, 7, 11, 13, 14, 24)]
        [JsonProperty("Condvenda")]
        public int TipoVenda { get; set; }

        /// <summary>
        /// Define a data do cancelamento da NF.
        /// </summary>
        /// <value></value>
        [JsonProperty("Dtcancel")]
        public DateTime? DataCancelamento { get; set; }

        /// <summary>
        /// Define o total de itens da NF.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, 9999)]
        [JsonProperty("Numitens")]
        public int NumeroTotalItens { get; set; }

        /// <summary>
        /// Define o valor total gerado.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vltotger")]
        public double ValorTotalGerado { get; set; }

        /// <summary>
        /// Define o valor total de preço tabela.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vltabela")]
        public double ValorTotalPrecoTabela { get; set; }

        /// <summary>
        /// Define o valor total da NF.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vltotal")]
        public double ValorTotalNF { get; set; }

        /// <summary>
        /// Define a data de entrega da NF.
        /// </summary>
        /// <value></value>
        [JsonProperty("Dtentrega")]
        public DateTime DataEntregaNF { get; set; }

        /// <summary>
        /// Define o total do peso.
        /// </summary>
        /// <value></value>
        [JsonProperty("Totpeso")]
        public decimal TotalPeso { get; set; }

        /// <summary>
        /// Define o total de volume.
        /// </summary>
        /// <value></value>
        [JsonProperty("Totvolume")]
        public decimal TotalVolume { get; set; }

        /// <summary>
        /// Define a seguência de entrega da NF.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Numseq")]
        public long NumeroSequenciaEntrega { get; set; }

        /// <summary>
        /// Define a data de faturamento da NF.
        /// </summary>
        /// <value></value>
        [JsonProperty("Dtfat")]
        public DateTime? DataFaturamento { get; set; }

        /// <summary>
        /// Define a série da NF. O preenchimento é obrigatório.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(5)]
        [CampoObrigatorioAoInserir]
        public string Serie { get; set; }

        /// <summary>
        /// Define a espécie da NF. O preenchimento é obrigatório.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(10)]
        [CampoObrigatorioAoInserir]
        public string Especie { get; set; }

        /// <summary>
        /// Define o código da cobrança. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Código da cobrança referente ao cadastro da cobrança.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Define o código do plano de pagamento. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Código do plano de pagamento referente ao cadastro de planos de pagamento.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [JsonProperty("Codplpag")]
        public string CodigoPlanoPagamento { get; set; }

        /// <summary>
        /// Define o código do supervidor.
        /// </summary>
        /// <value>Código referente ao cadastro de Supervisor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(SupervisorMaxima.VersaoAPI, SupervisorMaxima.EndPoint, SupervisorMaxima.Tabela, typeof(SupervisorMaxima))]
        [JsonProperty("Codsupervisor")]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Define o código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código cliente referente ao cadastro de cliente.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Define o código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Define o número do carregamento. O preenchimento é obrigatório.
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Numcar")]
        [PropriedadeFK(CarregamentoMaxima.VersaoAPI, CarregamentoMaxima.EndPoint, CarregamentoMaxima.Tabela, typeof(CarregamentoMaxima))]
        public string NumeroCarregamento { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "NotasSaidaCapas";
        internal const string Tabela = "ERP_MXSNFSAID";
    }
}

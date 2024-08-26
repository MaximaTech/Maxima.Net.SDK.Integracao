using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os tipos de cobranças do sistema
    /// </summary>
    public class CobrancaMaxima
    {
        [TamanhoMaximo(4000)]
        [JsonProperty("Codcob")]
        [PropriedadePK]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// [Propriedade interna] Nível de venda com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Nivelvenda")]
        [ValorEntre(0, 99)]
        internal int? Nivelvenda { get; set; }

        /// <summary>
        /// Valor mínimo de venda com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vlminpedido")]
        public double? ValorMinimoVendaPedido { get; set; }

        /// <summary>
        /// Prazo máximo de venda com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999)]
        [JsonProperty("Prazomaximovenda")]
        public int? PrazoMaximoVenda { get; set; }

        /// <summary>
        /// Tipo de venda.
        /// </summary>
        /// <value>VP - Venda a prazo, VV - Venda à vista</value>
        [RangeString(new string[] { "VP", "VV" })]
        [JsonProperty("Tipovenda")]
        public string TipoVenda { get; set; }

        /// <summary>
        /// Tipo de cobrança
        /// </summary>
        /// <value>B – Boleto, C – Cartão, CH – Cheque, D – Dinheiro, DU – Duplicata ou T – Transferência Bancária</value>
        [RangeString(new string[] { "B", "C", "CH", "D", "DU", "T" })]
        [JsonProperty("Tipocobranca")]
        public string TipoCobranca { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Descrição da cobrança com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("cobranca")]
        public string NomeCobranca { get; set; }

        /// <summary>
        /// Informa se a cobrança é cartão de crédito ou não. Preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Cartao")]
        internal string Cartao { get; set; }

        /// <summary>
        /// Informa se a cobrança é boleto ou não. Preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Boleto")]
        internal string Boleto { get; set; }

        /// <summary>
        /// Gravar o valor "S" para indicar que a cobrança e do tipo de operação Broker, default é "N".
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Cobrancabroker")]
        public string CobrancaBroker { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Cobrancas";
        internal const string Tabela = "MXSCOB";

    }
}

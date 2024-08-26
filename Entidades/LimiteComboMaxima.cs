using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar as vendas de combos por cliente e vendedor.
    /// </summary>
    public class LimiteComboMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "LimiteCombos";
        internal const string Tabela = "MXSLIMITECOMBOS";

        /// <summary>
        /// Número do pedido do ERP
        /// </summary>
        [PropriedadePK(1)]
        [ValorEntre(0, int.MaxValue)]
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        [JsonProperty("Numped")]
        public long? NumeroPedido { get; set; }

        /// <summary>
        /// Código do combo de desconto, com limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(2)]
        [JsonProperty("Codcombo")]
        [TamanhoMaximo(50)]
        public string CodigoCombo { get; set; }

        /// <summary>
        /// Código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [PropriedadePK(3)]
        [JsonProperty("Codcli")]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadePK(4)]
        [JsonProperty("Codusur")]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Status do pedido. O preenchimento é obrigatório.
        /// </summary>
        /// <value>L - Liberado ou C - Cancelado</value>
        [JsonProperty("Statuspedido")]
        [RangeString("L", "C")]
        [CampoObrigatorioAoInserir]
        public string StatusPedido { get; set; }
    }
}

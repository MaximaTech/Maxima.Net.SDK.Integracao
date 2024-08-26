using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os cortes dos pedidos.
    /// </summary>
    public class HistoricoPedidoCorteMaxima
    {
        /// <summary>
        /// Define o código do produto.
        /// </summary>
        /// <value>Código do produto referente ao cadastro de produto.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [PropriedadePK(1)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define código do pedido.
        /// </summary>
        /// <value>Código do pedido referente ao histórico do pedido.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int NumeroPedido { get; set; }

        /// <summary>
        /// Define a quantidade cortada, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.99)]
        [JsonProperty("Qtcortada")]
        public double? QuantidadeCortada { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "HistoricosPedidosCortes";
        internal const string Tabela = "MXSHISTORICOPEDCORTE";
    }
}

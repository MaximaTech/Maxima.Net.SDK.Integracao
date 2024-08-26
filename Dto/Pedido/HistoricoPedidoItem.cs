using System;
using System.ComponentModel.DataAnnotations;
using Maxima.Net.SDK.Integracao.Entidades;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    /// <summary>
    /// Entidade que armazena os itens do histórico de pedidos.
    /// </summary>
    public class HistoricoPedidoItem
    {
        /// <summary>
        /// Número do histórico do pedido. O preenchimento é obrigatório. <br/>
        /// Esse código usado deve estar no Histórico Pedido Capa.
        /// </summary>
        [PropriedadePK(1)]
        [PropriedadeFK(
            HistoricoPedidoCapa.VersaoAPI,
            HistoricoPedidoCapa.EndPoint,
            HistoricoPedidoCapa.Tabela,
            typeof(HistoricoPedidoCapa)
        )]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int NumeroPedido { get; set; }

        /// <summary>
        /// Define a ordem que o item foi incluida no pedido.
        /// </summary>
        [PropriedadePK(2)]
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Numseq")]
        public long SequenciaItem { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(
            ProdutoMaxima.VersaoAPI,
            ProdutoMaxima.EndPoint,
            ProdutoMaxima.Tabela,
            typeof(ProdutoMaxima)
        )]
        [JsonProperty("Codprod")]
        [PropriedadePK(3)]
        public string CodigoProduto { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Qt")]
        public decimal? Quantidade { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Pvenda")]
        public decimal? PrecoVenda { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Ptabela")]
        public decimal? PrecoTabela { get; set; }

        [JsonProperty("Qt_devolvida")]
        public decimal? QuantidadeDevolvida { get; set; }

        public DateTime? Data { get; set; }

        /// <summary>
        /// Define o percentual de comissão do produto.
        /// </summary>
        [JsonProperty("Percom")]
        [ValorEntre(0, 9999.9999)]
        public double? PercentualComissao { get; set; }

        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarras { get; set; }

        /// <summary>
        /// Posição do pedido (F – Faturado, M – Montado, P – Pendente, C – Cancelado)
        /// </summary>
        [RangeString("F", "M", "P", "C")]
        [JsonProperty("Posicao")]
        public string Posicao { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        public const string VersaoAPI = "v3";
        public const string Endpoint = "HistoricosPedidosItens";
        internal const string Tabela = "MXSHISTORICOPEDI";
    }
}

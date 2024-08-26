using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as informações de estoque por filial
    /// </summary>
    public class EstoqueMaxima
    {

        /// <summary>
        /// Código da filial responsável pelo estoque. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [TamanhoMaximo(4000)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [PropriedadePK(1)]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do produto do estoque.  O preenchimento é obrigatório com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [PropriedadePK(2)]
        public string CodigoProduto { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtreserv")]
        public decimal? QtdEstoqueReservado { get; set; }

        /// <summary>
        /// Quantidade do estoque gerencial com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtestger")]
        public decimal? QtdEstoqueGerencial { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtbloqueada")]
        public decimal? QtdEstoqueBloqueado { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Valorultent")]
        public decimal? ValorUltimaEntrada { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtpendente")]
        public decimal? QtdEstoquePendente { get; set; }

        /// <summary>
        /// Custo financeiro com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Custofin")]
        public decimal? CustoFinanceiro { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Custoreal")]
        public decimal? CustoReal { get; set; }

        [CampoObrigatorioAoInserir]
        [JsonProperty("Custorep")]
        public decimal? CustoReposicao { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Estoques";
        internal const string Tabela = "MXSEST";

    }
}

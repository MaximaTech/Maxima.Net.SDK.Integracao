using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade Tabela responsável por detalhar o  estoque da cesta.
    /// </summary>
    public class EstoqueCestaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "EstoquesCestas";
        internal const string Tabela = "MXSESTCESTA";

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        [PropriedadePK(2)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Custo contábil.
        /// </summary>
        [JsonProperty("Custocont")]
        public decimal? CustoContabil { get; set; }

        /// <summary>
        /// Custo financeiro com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Custofin")]
        [CampoObrigatorioAoInserir]
        public decimal? CustoFinanceiro { get; set; }

        /// <summary>
        /// Custo da nota fiscal sem ST.
        /// </summary>
        [JsonProperty("Custonfsemst")]
        public decimal? CustoNFSemST { get; set; }

        /// <summary>
        /// Custo real.
        /// </summary>
        public decimal? CustoReal { get; set; }

        /// <summary>
        /// Custo de reposição.
        /// </summary>
        [JsonProperty("Custorep")]
        public decimal? CustoReposicao { get; set; }

        /// <summary>
        /// Quantidade de produtos bloqueados.
        /// </summary>
        [JsonProperty("Qtbloqueada")]
        public decimal? QuantidadeProdutosBloqueados { get; set; }

        /// <summary>
        /// Quantidade de estoque gerencial.
        /// </summary>
        [JsonProperty("Qtestger")]
        public decimal? QuantidadeEstoqueGerencial { get; set; }

        /// <summary>
        /// Quantidade de estoque pendente.
        /// </summary>
        [JsonProperty("Qtpendente")]
        public decimal? QuantidadeEstoquePendente { get; set; }

        /// <summary>
        /// Quantidade de estoque reservado.
        /// </summary>
        [JsonProperty("Qtreserv")]
        public decimal? QuantidadeEstoqueReservado { get; set; }

        /// <summary>
        /// Valor da última entrada.
        /// </summary>
        [JsonProperty("Valorultent")]
        public decimal? ValorUltimaEntrada { get; set; }
    }
}

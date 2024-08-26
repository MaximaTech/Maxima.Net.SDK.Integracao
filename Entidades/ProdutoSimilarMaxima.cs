using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar a relação de produtos similares.
    /// </summary>
    public class ProdutoSimilarMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ProdutosSimilares";
        internal const string Tabela = "MXSPRODSIMIL";

        /// <summary>
        /// Código do produto com preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código do produto similar com preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsimil")]
        public string CodigoProdutoSimilar { get; set; }

        /// <summary>
        /// Flag que indica se o produto similar é apenas similar, ou também uma alternativa ao principal.
        /// </summary>
        /// <value>Valores possíveis: S (Similar) / A (Alternativa)</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "A")]
        [JsonProperty("Tipoprod")]
        public string TipoRelacao { get; set; }
    }
}

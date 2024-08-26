using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Tabela utilizada para armazenar as embalagens vinculadas ao produto,
    /// no caso de utilização de venda por embalagem por filial
    /// torna se obrigatório o preenchimento das informações.
    /// </summary>
    public class EmbalagemMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Embalagens";
        internal const string Tabela = "MXSEMBALAGEM";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da embalagem com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(2)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoEmbalagem { get; set; }

        /// <summary>
        /// Código da filial com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="FilialMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do produto com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ProdutoMaxima"/>.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Descrição da embalagem com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Embalagem")]
        public string Descricao { get; set; }

        /// <summary>
        /// Fator de conversão das unidades da embalagem com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtunit")]
        public decimal? FatorConversaoUnidade { get; set; }

        /// <summary>
        /// Fator de acréscimo ao preço de tabela.
        /// </summary>
        [JsonProperty("Fatorpreco")]
        public decimal? FatorAcrescimoPreco { get; set; }

        /// <summary>
        /// Informação de unidade da embalagem (ex: CX, UN, LT, PCT, etc...)
        /// </summary>
        public string Unidade { get; set; }
    }
}

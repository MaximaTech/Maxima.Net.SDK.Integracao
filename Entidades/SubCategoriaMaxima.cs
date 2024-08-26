using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar as informações de sub-categorias que podem ser utilizadas para agrupamento de produtos.
    /// </summary>
    public class SubCategoriaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Subcategorias";
        internal const string Tabela = "MXSSUBCATEGORIA";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da categoria com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="CategoriaMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(CategoriaMaxima.VersaoAPI, CategoriaMaxima.EndPoint, CategoriaMaxima.Tabela, typeof(CategoriaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcategoria")]
        public string CodigoCategoria { get; set; }

        /// <summary>
        /// Código da seção da sub-categoria com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de <see cref="SecaoMaxima"/>
        /// </value>
        [PropriedadePK(2)]
        [PropriedadeFK(SecaoMaxima.VersaoAPI, SecaoMaxima.EndPoint, SecaoMaxima.Tabela, typeof(SecaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsec")]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Código da sub-categoria com preenchimento obrigatório e limite de 50 caracteres.
        /// </summary>
        [PropriedadePK(3)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsubcategoria")]
        public string CodigoSubcategoria { get; set; }

        /// <summary>
        /// Descrição da sub-categoria com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Subcategoria")]
        public string Descicao { get; set; }
    }
}

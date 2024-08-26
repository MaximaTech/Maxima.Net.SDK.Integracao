using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar as categorias de produto, pode ser utilizado com o conceito de grupos de produtos.
    /// </summary>
    public class CategoriaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Categorias";
        internal const string Tabela = "MXSCATEGORIA";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da categoria com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(2)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcategoria")]
        public string CodigoCategoria { get; set; }

        /// <summary>
        /// Código da seção da categoria com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de <see cref="SecaoMaxima"/>
        /// </value>
        [PropriedadePK(1)]
        [PropriedadeFK(SecaoMaxima.VersaoAPI, SecaoMaxima.EndPoint, SecaoMaxima.Tabela, typeof(SecaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsec")]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Descrição da categoria com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Categoria")]
        public string Descicao { get; set; }
    }
}

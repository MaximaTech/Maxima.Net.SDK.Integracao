using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as categorias dos tipos de campanha.
    /// </summary>
    public class DescontoCategoriaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "DescontoCategoria";
        internal const string Tabela = "MXSDESCONTOCATEGORIA";

        /// <summary>
        /// Código do combro, campo é obrigatório. Limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codigo")]
        [PropriedadePK(1)]
        public string CodigoCombo { get; set; }

        /// <summary>
        /// Tipo de filtro, campo é obrigatório. Limite de até 100 caracteres.
        /// </summary>
        /// <value>F - Fornecedor, S - Seção, D - Departamento, C - Categoria, SC - SubCategoria, P - Produto </value>
        [RangeString("F", "S", "D", "C", "SC", "P")]
        [JsonProperty("Tipo")]
        [PropriedadePK(3)]
        public string TipoFiltro { get; set; }

        /// <summary>
        /// Código sequencial do combo, campo é obrigatório.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Seq")]
        [PropriedadePK(2)]
        public int? Sequencial { get; set; }

        /// <summary>
        /// Código alfanumérico do tipo do filtro, campo é obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Tipovalor")]
        [CampoObrigatorioAoInserir]
        public string TipoValor { get; set; }

        /// <summary>
        /// Percentual de desconto aplicado, campo é obrigatório.
        /// </summary>
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Percdesc")]
        [CampoObrigatorioAoInserir]
        public decimal? PercentualDesconto { get; set; }

        /// <summary>
        /// Intervalo inicial, campo é obrigatório.
        /// </summary>
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Iniciointervalo")]
        [CampoObrigatorioAoInserir]
        public decimal? InicioIntervalo { get; set; }

        /// <summary>
        /// Intervalo final, campo é obrigatório.
        /// </summary>
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Fimintervalo")]
        [CampoObrigatorioAoInserir]
        public decimal? FimIntervalo { get; set; }


    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as validações das campanhas de brinde.
    /// </summary>
    public class BrindeValidacaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "BrindesValidacoes";
        internal const string Tabela = "MXSBRINDEEXVALIDACOES";

        /// <summary>
        /// Código de identificação da campanha, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Brinde.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Codbrex")]
        [PropriedadeFK(BrindeMaxima.VersaoAPI, BrindeMaxima.EndPoint, BrindeMaxima.Tabela, typeof(BrindeMaxima))]
        public string CodigoBrinde{ get; set; }

        /// <summary>
        /// Identificador do tipo (D – Departamento, S – Seção, F – Fornecedor). Com preenchimento obrigatório.
        /// </summary>
        /// <value>D – Departamento, S – Seção, F – Fornecedor</value>
        [RangeString("D", "S", "F")]
        [PropriedadePK(2)]
        [JsonProperty("Tipo")]
        public string TipoDestino { get; set; }

        /// <summary>
        /// Código do tipo selecionado, com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(3)]
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Identificador do tipo de validação (PE – Peso, QT – Quantidade, VL - Valor). Com preenchimento obrigatório.
        /// </summary>
        /// <value>PE – Peso, QT – Quantidade, VL - Valor</value>
        [RangeString("PE", "QT", "VL")]
        [PropriedadePK(4)]
        [JsonProperty("Tipovalor")]
        public string TipoValidacao{ get; set; }

        /// <summary>
        /// Identificador do grupo de regra, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 999999)]
        [PropriedadePK(5)]
        [JsonProperty("Gruporegra")]
        public int? CodigoGrupoRegra { get; set; }

        /// <summary>
        /// Valor máximo, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlmax")]
        public decimal? ValorMaximo { get; set; }

        /// <summary>
        /// Valor mínimo, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlmin")]
        public decimal? ValorMinimo { get; set; }

    }
}

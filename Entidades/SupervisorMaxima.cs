using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o supervisor.
    /// </summary>
    public class SupervisorMaxima
    {

        /// <summary>
        /// Define o código do supervisor.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codsupervisor")]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Define se o supervisor esta ativo ou inativo. O preenchimento é obrigatório.
        /// </summary>
        /// <value>A - Para ativo, I - Para inativo.</value>
        [CampoObrigatorioAoInserir]
        [RangeString("A", "I")]
        [JsonProperty("Posicao")]
        public string Status { get; set; }

        /// <summary>
        /// Define o código de vendedor com figura de supervisor. O preenchimento é obrigatório.
        /// </summary>
        /// <value></value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Cod_cadrca")]
        public string CodigoVendedorSupervisor { get; set; }

        /// <summary>
        /// Define o código do gerente. O preenchimento é obrigatório.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codgerente")]
        public string CodigoGerente { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Define o nome do supervidor. O preenchimento é obrigatório.
        /// </summary>
        /// <value></value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Nome { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Supervisores";
        internal const string Tabela = "MXSSUPERV";

    }
}

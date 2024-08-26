using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os registros de concorrentes.
    /// </summary>
    public class ConcorrenteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Concorrentes";
        internal const string Tabela = "MXSCONCOR";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código de concorrentes, com preenchimento é obrigatório.
        /// </summary>
        [PropriedadePK]
        [JsonProperty("Codconc")]
        public string CodigoConcorrente { get; set; }

        /// <summary>
        /// Nome do concorrente, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Concorrente")]
        public string Descricao { get; set; }

        /// <summary>
        /// Ativo do concorrente, com preenchimento obrigatório.
        /// </summary>
        /// <value>S-Sim, N-Não</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Ativo")]
        public string Ativo { get; set; }

        /// <summary>
        /// Telefone do concorrente.
        /// </summary>
        [JsonProperty("Telefone")]
        public string Telefone { get; set; }
    }
}

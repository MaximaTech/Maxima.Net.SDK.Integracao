using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o informações do motivo da visita do vendedor ao cliente.
    /// </summary>
    public class MotivoVisitaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "MotivosVisitas";
        internal const string Tabela = "MXSMOTVISITA";

        /// <summary>
        /// Código do motivo, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 999999)]
        [PropriedadePK]
        [JsonProperty("Codmotivo")]
        public int? CodigoMotivo { get; set; }

        /// <summary>
        /// Descrição do motivo, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os motivos de devoluções de NF. Obrigatório se MaxGestão
    /// </summary>
    public class MotivoDevolucaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Devolucoes";
        internal const string Tabela = "ERP_MXSTABDEV";

        /// <summary>
        /// Código do motivo da devolução, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Coddevol")]
        public string CodigoDevolucao { get; set; }

        /// <summary>
        /// Tipo do motivo de devolução, com preenchimento obrigatório e limite de até 2 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [RangeString("ED")]
        [JsonProperty("Tipo")]
        public string Tipo { get; set; }

        /// <summary>
        /// Descrição do motivo de devolução, com preenchimento obrigatório e limite de até 30 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(30)]
        [JsonProperty("Motivo")]
        public string Motivo { get; set; }
    }
}

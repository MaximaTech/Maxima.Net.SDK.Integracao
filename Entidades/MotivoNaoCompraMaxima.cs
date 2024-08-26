using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena informações do motivo da não compra. São relacionadas no momento da justificativa de visita em caso de não positivação.
    /// </summary>
    public class MotivoNaoCompraMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "MotivosNaoCompra";
        internal const string Tabela = "MXSMOTNAOCOMPRA";

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

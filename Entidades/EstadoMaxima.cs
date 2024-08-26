using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os códigos e descrições dos estados
    /// </summary>
    public class EstadoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Estado";
        internal const string Tabela = "ERP_MXSESTADO";

        /// <summary>
        /// UF Unidade federativa, com preenchimento obrigatório e limite de até 2 caracteres
        /// </summary>
        [TamanhoMaximo(2)]
        [PropriedadePK]
        [JsonProperty("Uf")]
        public string UF { get; set; }

        /// <summary>
        /// Nome do estado com preenchimento obrigatório e limite de até 30 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(30)]
        public string Estado { get; set; }
    }
}

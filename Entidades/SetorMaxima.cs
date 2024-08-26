using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os setores da empresa.
    /// </summary>
    public class SetorMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Setores";
        internal const string Tabela = "MXSSETOR";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do Setor com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codsetor")]
        public string CodigoSetor { get; set; }

        /// <summary>
        /// Descricao do Setor com limite de até 4000 caracteres.
        /// </summary>
        [TamanhoMaximo(4000)]
        public string Descricao { get; set; }
    }
}

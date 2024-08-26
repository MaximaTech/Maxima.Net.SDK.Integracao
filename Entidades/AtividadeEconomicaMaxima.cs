using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena  as atividades econômicas relacionadas ao cadastro do cliente. 
    /// </summary>
    public class AtividadeEconomicaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Cnaes";
        internal const string Tabela = "MXSCNAE";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da Atividade Econômica, com preenchimento obrigatório e limite de até 60 caracteres.
        /// </summary>
        [TamanhoMaximo(60)]
        [PropriedadePK]
        [JsonProperty("Codcnae")]
        public string CodigoCnae { get; set; }

        /// <summary>
        /// Descricao da Atividade Econômica, com preenchimento obrigatório e com limite de até 250 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(250)]
        [JsonProperty("Desccnae")]
        public string Descricao { get; set; }
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as restrições das campanhas de brinde. Ex.: Campanha só é válida para a região centro oeste. 
    /// </summary>
    public class BrindeRestricaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "BrindesRestricoes";
        internal const string Tabela = "MXSBRINDEEXRESTRICOES";

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
        /// Código A, com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(6)]
        [PropriedadePK(2)]
        [JsonProperty("CodigoA")]
        public string CodigoA { get; set; }

        /// <summary>
        /// Código do tipo selecionado, com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(3)]
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Identificador do tipo de restrição (R – Região, F – Filial, S – Supervisor), com preenchimento obrigatório.
        /// </summary>
        /// <value>R – Região, F – Filial, S – Supervisor</value>
        [RangeString("R", "F", "S")]
        [PropriedadePK(4)]
        [JsonProperty("Tipo")]
        public string TipoRestricao { get; set; }

        /// <summary>
        /// Identificador do grupo de regra, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 999999)]
        [PropriedadePK(5)]
        [JsonProperty("Gruporegra")]
        public int? CodigoGrupoRegra { get; set; }

        /// <summary>
        /// Tipo (R - Restrição ou E - Exclusividade), com preenchimento obrigatório.
        /// </summary>
        /// <value>R - Restrição ou E - Exclusividade</value>
        [RangeString("R", "E")]
        [PropriedadePK(6)]
        [JsonProperty("Validacao")]
        public string TipoValidacao { get; set; }

    }
}

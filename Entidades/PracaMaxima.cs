using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as informações de praça de atendimento.
    /// </summary>
    public class PracaMaxima
    {
        [TamanhoMaximo(50)]
        [JsonProperty("Codpraca")]
        [PropriedadePK]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Indica se a praça está ativa ou não.
        /// </summary>
        /// <value>
        /// A=Ativo; I=Inativo
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "A", "I" })]
        [JsonProperty("Situacao")]
        public string Ativa { get; set; }

        ///<summary>
        /// Utilizado para vínculo com região do cliente. O preenchimento é obrigatório e com limite de até 50 caracteres. <br/>
        ///</summary>
        /// <value>Esse código usado deve estar no Cadastro de Região.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [JsonProperty("Numregiao")]
        public string CodigoRegiao { get; set; }

        /// <summary>
        ///Hash para controle de integração.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Descrição da Praça com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("praca")]
        public string Descricao { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Pracas";
        internal const string Tabela = "MXSPRACA";
    }
}

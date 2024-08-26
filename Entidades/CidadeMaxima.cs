using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as cidades e código de IBGE
    /// </summary>
    public class CidadeMaxima
    {
        /// <summary>
        /// Código da cidade com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codcidade")]
        public string CodigoCidade { get; set; }

        /// <summary>
        /// Código do IBGE da cidade com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codibge")]
        public string CodigoCidadeIBGE { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Nome da Cidade com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Nomecidade")]
        public string NomeCidade { get; set; }

        /// <summary>
        /// UF da Cidade com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Uf")]
        public string UF { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Cidades";
        internal const string Tabela = "MXSCIDADE";

    }
}

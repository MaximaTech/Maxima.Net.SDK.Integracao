using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar o cadastro de CFOP.
    /// </summary>
    public class CfopMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Cfos";
        internal const string Tabela = "MXSCFO";

        /// <summary>
        /// Código fiscal com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK]
        [TamanhoMaximo(50)]
        [JsonProperty("Codfiscal")]
        public string CodigoFiscal { get; set; }

        /// <summary>
        /// Descrição do CFO com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Desccfo")]
        public string Descricao { get; set; }
    }
}

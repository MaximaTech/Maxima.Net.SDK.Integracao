using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os códigos e descrições dos bancos
    /// </summary>
    public class BancoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Banco";
        internal const string Tabela = "MXSBANCO";

        /// <summary>
        /// Código do banco, conforme o código do BACEN com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codbanco")]
        public string CodigoBanco { get; set; }

        /// <summary>
        /// Nome do banco com preenchimento obrigatório e limite de até 200 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(200)]
        public string Nome { get; set; }
    }
}

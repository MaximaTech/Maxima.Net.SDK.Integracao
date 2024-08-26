using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar as redes de cliente.
    /// Exemplo; Carrefour, Walmart, Pão de Açúcar.
    /// </summary>
    public class RedeClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "RedesClientes";
        internal const string Tabela = "MXSREDECLIENTE";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da rede com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codrede")]
        public string CodigoRede { get; set; }

        /// <summary>
        /// Descrição da rede. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }
    }
}

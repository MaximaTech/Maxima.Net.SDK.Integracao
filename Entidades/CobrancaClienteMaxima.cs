using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as cobranças vinculadas ao cadastro do cliente.
    /// </summary>
    public class CobrancaClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "CobrancasClientes";
        internal const string Tabela = "MXSCOBCLI";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código de cobrança, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Cobranças.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }
    }
}

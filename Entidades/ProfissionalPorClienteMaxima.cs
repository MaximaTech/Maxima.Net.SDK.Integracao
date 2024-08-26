using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar os profissionais vinculados a cada cliente.
    /// </summary>
    public class ProfissionalPorClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ProfissionaisClientes";
        internal const string Tabela = "MXSPROFISSIONALCLI";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve exisitir no cadastro de Clientes.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Código do segundo vendedor com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur2")]
        public string CodigoVendedor2 { get; set; }

        /// <summary>
        /// Código do terceiro vendedor com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur3")]
        public string CodigoVendedor3 { get; set; }
    }
}

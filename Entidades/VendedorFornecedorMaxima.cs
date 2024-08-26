using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que relaciona vendedores e fornecedores.
    /// </summary>
    public class VendedorFornecedorMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "UsuariosFornecedores";
        internal const string Tabela = "MXSUSURFORNEC";

        /// <summary>
        /// Código do vendedor do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadePK(1)]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Código do fornecedor. Com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de fornecedores.</value>
        [PropriedadePK(2)]
        [TamanhoMaximo(50)]
        [PropriedadeFK(FornecedorMaxima.VersaoAPI, FornecedorMaxima.EndPoint, FornecedorMaxima.Tabela, typeof(FornecedorMaxima))]
        [JsonProperty("Codfornec")]
        public string CodigoFornecedor { get; set; }
    }
}

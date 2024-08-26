using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as informações dos fornecedores. Existe um vínculo obrigatório do fornecedor com o cadastro de produtos.
    /// </summary>
    public class FornecedorMaxima
    {
        [TamanhoMaximo(50)]
        [JsonProperty("Codfornec")]
        [PropriedadePK]
        public string CodigoFornecedor { get; set; }

        [TamanhoMaximo(15)]
        [JsonProperty("Ie")]
        public string InscricaoEstadual { get; set; }

        [TamanhoMaximo(20)]
        [JsonProperty("Telfab")]
        public string Telefone { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Nome do fornecedor com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("fornecedor")]
        public string NomeFornecedor { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Fantasia")]
        public string NomeFantasia { get; set; }

        /// <summary>
        /// CPF ou CNPJ do fornecedor com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Cgc")]
        public string CpfCnpj { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Ender")]
        public string Logradouro { get; set; }

        [TamanhoMaximo(4000)]
        public string Bairro { get; set; }

        /// <summary>
        /// Código da cidade do fornecedor. <br/>
        /// </summary>
        /// <value>
        /// Esse código usado deve estar no Cadastro de Cidades
        /// </value>
        [TamanhoMaximo(4000)]
        public string Cidade { get; set; }

        [TamanhoMaximo(4000)]
        public string Estado { get; set; }

        /// <summary>
        /// Indica se o Fornecedor está ativo ou não. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Bloqueio")]
        public string Ativo { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Fornecedores";
        internal const string Tabela = "MXSFORNEC";
    }
}

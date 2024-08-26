using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as filiais
    /// </summary>
    public class FilialMaxima
    {
        /// <summary>
        /// Código identificador da filial. O preenchimento é obrigatório.
        /// </summary>
        [TamanhoMaximo(4000)]
        [PropriedadePK]
        [JsonProperty("Codigo")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Razão Social da filial. O preenchimento é obrigatório e o limite de até 4000 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Razaosocial")]
        public string RazaoSocial { get; set; }

        /// <summary>
        /// Nome fantazia da filial.
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Fantasia")]
        public string NomeFantasia { get; set; }

        /// <summary>
        /// Hash para controle de integração.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// CNPJ da empresa. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Cgc")]
        public string Cnpj { get; set; }

        /// <summary>
        /// Inscrição Estadual da empresa. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Ie")]
        public string InscricaoEstadual { get; set; }

        /// <summary>
        /// Logradouro do endereço.
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Endereco")]
        public string Logradouro { get; set; }

        /// <summary>
        /// Bairro do endereço.
        /// </summary>
        [TamanhoMaximo(4000)]
        public string Bairro { get; set; }

        /// <summary>
        /// Código da Cidade da filial. <br/>
        /// Esse código usado deve estar no Cadastro de Cidades.
        /// </summary>
        [TamanhoMaximo(4000)]
        [PropriedadeFKAttribute(CidadeMaxima.VersaoAPI, CidadeMaxima.EndPoint, CidadeMaxima.Tabela, typeof(CidadeMaxima))]
        public string Cidade { get; set; }

        /// <summary>
        /// Estado.
        /// </summary>
        [TamanhoMaximo(4000)]
        public string Uf { get; set; }

        /// <summary>
        /// CEP.
        /// </summary>
        [TamanhoMaximo(4000)]
        public string Cep { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        [TamanhoMaximo(4000)]
        public string Telefone { get; set; }

        /// <summary>
        /// Identifica se a filial vai utilizar o processo de venda por emabalagem. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Utilizavendaporembalagem")]
        public string FilialUtilizaVendaPorEmbalagem { get; set; }

        /// <summary>
        /// Calcular IPI na venda. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Calcularipivenda")]
        public string CalcularIpiNaVenda { get; set; }

        /// <summary>
        /// Utiliza WMS.
        ///</summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Usawms")]
        public string UtilizaWMS { get; set; }

        /// <summary>
        /// Tipo de precificação. O preenchimento é obrigatório.
        ///</summary>
        /// <value>
        /// "A" (Atacado) ou "P" (Varejo)
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "A", "P" })]
        [JsonProperty("Tipoprecificacao")]
        public string TipoPrecificacao { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Filiais";
        internal const string Tabela = "MXSFILIAL";
    }
}

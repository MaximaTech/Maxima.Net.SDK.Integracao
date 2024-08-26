using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar endereços adicionais ao cadastro do cliente,
    /// podendo haver vários registros de endereços de entrega
    /// para o mesmo cliente.
    /// </summary>
    public class EnderecoClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ClientesEnderecos";
        internal const string Tabela = "MXSCLIENTENDENT";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do Endereço com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Codendentcli")]
        public string CodigoEndereco { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Endereço do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Enderent")]
        public string Endereco { get; set; }

        /// <summary>
        /// Bairo do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Bairroent")]
        public string Bairro { get; set; }

        /// <summary>
        /// Municipio do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Municent")]
        public string Municipio { get; set; }

        /// <summary>
        /// Estado do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Estent")]
        public string Estado { get; set; }

        /// <summary>
        /// CEP do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Cepent")]
        public string Cep { get; set; }

        /// <summary>
        /// Complemento do cliente limite de até 4000 caracteres
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Complementoent")]
        public string Complemento { get; set; }

        /// <summary>
        /// Numero do cliente com limite de até 400 caracteres
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Numeroent")]
        public string Numero { get; set; }

        /// <summary>
        /// Codigo da Cidade do cliente com limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>O código usado deve estar no Cadastro de Cidades</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(CidadeMaxima.VersaoAPI, CidadeMaxima.EndPoint, CidadeMaxima.Tabela, typeof(CidadeMaxima))]
        [JsonProperty("Codcidade")]
        public string CodigoCidade { get; set; }

        /// <summary>
        /// Código da Praça do cliente com limite de até 50 caracteres. <br/>
        /// O código usado deve existir no cadastro de Praça.
        /// </summary>
        [TamanhoMaximo(400)]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, typeof(PracaMaxima))]
        [JsonProperty("Codpracaent")]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Situacao do cliente com tamanho máximo de 1 caractere.
        /// </summary>
        /// <value>
        /// A - Ativo / I - Inativo
        /// </value>
        [RangeString(new string[] { "A", "I" })]
        [JsonProperty("Situacao")]
        public string Situacao { get; set; }

        /// <summary>
        /// Informação de nome fantasia ou apelido da unidade
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Apelidounidade")]
        public string ApelidoUnidade { get; set; }

        /// <summary>
        /// Ponto de Referência do endereço do cliente com limite de até 400 caracteres
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Pontorefer")]
        public string PontoDeReferencia { get; set; }
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os contatos dos clientes
    /// </summary>
    public class ContatoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Contatos";
        internal const string Tabela = "MXSCONTATO";

        /// <summary>
        /// Código do Contato, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codcontato")]
        public string CodigoContato { get; set; }

        ///<summary>
        /// Código do cliente, com preenchimento é obrigatório e com limite de até 50 caracteres.
        ///</summary>
        ///<value> CodigoCliente referente ao Cadastro de Clientes </value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codcli")]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Nome do contato do cliente e com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Nomecontato")]
        public string NomeContato { get; set; }

        /// <summary>
        /// Tipo de contato do cliente e com preenchimento obrigatório
        /// </summary>
        /// <value>I – Interno ou E - Externo</value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "I", "E" })]
        [JsonProperty("Tipocontato")]
        public string TipoContato { get; set; }

        /// <summary>
        /// Telefone do contato do cliente e com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Telefone { get; set; }

        [TamanhoMaximo(4000)]
        public string Celular { get; set; }

        [TamanhoMaximo(4000)]
        public string Email { get; set; }

        /// <summary>
        /// Cpf ou Cnpj do contato sem máscara.
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Cgccpf")]
        public string CpfCnpj { get; set; }

    }
}

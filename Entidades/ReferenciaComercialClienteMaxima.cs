using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar referências comercias ao cadastro do cliente.
    /// Exemplo de utilização: para aprovação de crédito entre outros.
    /// </summary>
    public class ReferenciaComercialClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ClientesRef";
        internal const string Tabela = "MXSCLIREF";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ClienteMaxima"/></value>
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Sequêncial para identificação da referência com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(2)]
        [ValorEntre(0, 99999999)]
        [JsonProperty("Numseqrefer")]
        public int? NumeroSequencia { get; set; }

        /// <summary>
        /// Contato da referência do cliente com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Contatorefer")]
        public string ContatoReferencia { get; set; }

        /// <summary>
        /// Empresa da referência do cliente.
        /// </summary>
        [JsonProperty("Emprefer")]
        public string EmpresaReferencia { get; set; }

        /// <summary>
        /// Telefone da referência do cliente com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Telrefer")]
        public string TelefoneReferencia { get; set; }
    }
}

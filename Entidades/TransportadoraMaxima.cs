using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as transportadoras
    /// </summary>
    public class TransportadoraMaxima
    {
        /// <summary>
        /// Código da transportadora com preenchimento obrigatório
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codtransp")]
        [PropriedadePK]
        public string CodigoTrasportadora { get; set; }

        /// <summary>
        /// Flag para informar se a transportadora está ativa.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Bloqueio")]
        public string Ativo { get; set; }

        /// <summary>
        /// Indica que transportadora é redespacho.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Eredespacho")]
        public string ERedespacho { get; set; }

        /// <summary>
        /// Indica se a transportadora atua com revenda. O valor padrão é N
        /// </summary>
        /// <value>
        /// N - Não ou T - Transportadora.
        /// </value>
        [RangeString("N", "T")]
        public string Revenda { get; set; }

        [TamanhoMaximo(50)]
        [JsonProperty("Cgc")]
        public string CpfCnpj { get; set; }

        [TamanhoMaximo(50)]
        public string Uf { get; set; }

        [TamanhoMaximo(50)]
        public string Telefone { get; set; }

        /// <summary>
        /// Cidade da transportadora.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Cidade")]
        public string Cidade { get; set; }

        /// <summary>
        ///Hash para controle de integração.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        [TamanhoMaximo(200)]
        public string Bairro { get; set; }

        [TamanhoMaximo(500)]
        [JsonProperty("Transportadora")]
        public string NomeTransportadora { get; set; }

        [TamanhoMaximo(500)]
        [JsonProperty("Endereco")]
        public string Logradouro { get; set; }

        [TamanhoMaximo(500)]
        [JsonProperty("Fantasia")]
        public string NomeFantasia { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Transportadoras";
        internal const string Tabela = "MXSTRANSPORTADORA";
    }
}

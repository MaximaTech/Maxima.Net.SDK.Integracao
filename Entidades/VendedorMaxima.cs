using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os dados dos vendedores
    /// </summary>
    public class VendedorMaxima
    {
        /// <summary>
        /// Código do vendedor com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        [PropriedadePK]
        public string CodigoVendedor { get; set; }

        [ValorEntre(0, 99.99)]
        [JsonProperty("Percent")]
        public double? PercentualComissaoVendaAvista { get; set; }

        [ValorEntre(0, 9999.99)]
        [JsonProperty("Percent2")]
        public double? PercentualComissaoVendaPrazo { get; set; }

        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vlvendaminped")]
        public double? ValorVendaMinimoPedido { get; set; }

        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Proxnumpedforca")]
        internal int? ProximoNumeroPedidoForcaVenda { get; set; }

        public DateTime? Dttermino { get; set; }

        [ValorEntre(0, 99999999.99)]
        public double? Vllimcred { get; set; }

        [ValorEntre(0, 99999999.99)]
        public double? Vlcorrente { get; set; }

        [TamanhoMaximo(2)]
        public string Estado { get; set; }

        [TamanhoMaximo(9)]
        public string Cep { get; set; }

        [TamanhoMaximo(15)]
        public string Cidade { get; set; }

        [TamanhoMaximo(25)]
        public string Bairro { get; set; }

        [TamanhoMaximo(40)]
        public string Endereco { get; set; }

        [TamanhoMaximo(50)]
        public string Codsupervisor { get; set; }

        [TamanhoMaximo(50)]
        public string Codfilial { get; set; }

        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Nome do vendedor com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Nome { get; set; }

        /// <summary>
        /// Tipo de vendedor, com preenchimento obrigatório.
        /// </summary>
        /// <value>
        /// I – Interno, E – Externo, R – Representante ou P – Profissional
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("I", "E", "R", "P")]
        [JsonProperty("Tipovend")]
        internal string TipoVendedor { get; set; }

        /// <summary>
        /// Flag para informar se o vendedor está ativo.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        public string Bloqueio { get; set; }

        /// <summary>
        /// Indica se o vendedor usa Déb. Crédito RCA (Específico para o Força de Venda).
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Usadebcredrca")]
        public string UsaDebitoCredito { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Telefone1")]
        public string Telefone { get; set; }

        [TamanhoMaximo(4000)]
        public string Email { get; set; }

        [TamanhoMaximo(4000)]
        public string Latitude { get; set; }

        [TamanhoMaximo(4000)]
        public string Longitude { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Usuaris";
        internal const string Tabela = "MXSUSUARI";
    }
}

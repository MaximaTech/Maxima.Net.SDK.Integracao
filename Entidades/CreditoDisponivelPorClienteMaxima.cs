using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar os valores que compõem o crédito disponível por cliente.
    /// </summary>
    public class CreditoDisponivelPorClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ClientesCreditosDisponiveis";
        internal const string Tabela = "MXSCLIENTECREDDISP";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de <see cref="ClienteMaxima"/>.
        /// </value>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Valor do limite de crédito.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vllimite")]
        public decimal? LimiteDeCredito { get; set; }

        /// <summary>
        /// Valor em aberto de títulos.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vltitulos")]
        public decimal? ValorTitulosEmAberto { get; set; }

        /// <summary>
        /// Valor dos pedidos em aberto (ainda não faturados).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlpedidos")]
        public decimal? ValorPedidosEmAberto { get; set; }

        /// <summary>
        /// Valor dos chegues em aberto (não baixados).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlcheques")]
        public decimal? ValorChequesEmAberto { get; set; }

        /// <summary>
        /// Valor de crédito.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlcredito")]
        public decimal? ValorDeCredito { get; set; }

        /// <summary>
        /// Valor de crédito.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vllimitecredsuppli")]
        public decimal? ValorDeCreditoDeTerceiros { get; set; }
    }
}

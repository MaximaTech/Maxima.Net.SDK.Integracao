using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as informações de conta corrente do vendedor.
    /// </summary>
    public class SaldoContaCorrenteVendedorMaxima
    {

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "SaldosContasCorrentesRcas";
        internal const string Tabela = "MXSSALDOCCRCA";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }


        /// <summary>
        /// Código do vendedor, com preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        [PropriedadePK]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Saldo da conta corrente do vendedor.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Saldocc")]
        public decimal? SaldoContaCorrente { get; set; }

        /// <summary>
        /// Limite de crédito do vendedor
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Limcredcc")]
        public decimal? LimiteCredito { get; set; }

    }
}

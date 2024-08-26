using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as relações entre cobrança e plano de pagamento. 
    /// </summary>
    public class CobrancaPlanoPagamentoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "CobrancasPlanosPagamentos";
        internal const string Tabela = "MXSCOBPLPAG";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da cobrança. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de cobranças.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, type: typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Código do plano de pagamento com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="PlanoPagamentoMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        public string CodigoPlanoDePagamento { get; set; }
    }
}

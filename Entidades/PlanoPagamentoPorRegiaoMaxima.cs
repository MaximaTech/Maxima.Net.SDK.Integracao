using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar as relações de regiões, planos de pagamentos e clientes.
    /// </summary>
    public class PlanoPagamentoPorRegiaoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PlanosPagamentosRegioes";
        internal const string Tabela = "MXSPLPAGREGIAO";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do plano de pagamento com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="PlanoPagamentoMaxima"/>.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ClienteMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código da região com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RegiaoMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        public string CodigoRegiao { get; set; }
    }
}

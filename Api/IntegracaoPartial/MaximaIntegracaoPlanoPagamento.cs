using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Plano de Pagamento para ser incluida na api máxima.
        /// </summary>
        /// <param name="planoPagamento">Representação de uma lista de Plano de Pagamento</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoMaxima>> IncluirPlanoPagamento(List<PlanoPagamentoMaxima> planoPagamento)
        {
            return _planoPagamentoApi.Incluir(planoPagamento);
        }

        /// <summary>
        /// Envia uma lista de Plano de Pagamento para ser alterada na api máxima, se o plano de pagamento não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="planoPagamento">Representação de uma lista de Plano de Pagamento</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoMaxima>> AlterarPlanoPagamento(List<PlanoPagamentoMaxima> planoPagamento)
        {
            return _planoPagamentoApi.Alterar(planoPagamento);
        }

        /// <summary>
        /// Envia uma array de strings com ids de PlanoPagamento para ser excluida.
        /// </summary>
        /// <param name="planoPagamento">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPlanoPagamento(string[] planoPagamento)
        {
            return _planoPagamentoApi.Deletar(planoPagamento);
        }
    }
}

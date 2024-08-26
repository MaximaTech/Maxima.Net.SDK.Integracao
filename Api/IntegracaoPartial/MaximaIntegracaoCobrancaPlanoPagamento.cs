using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cobrancas/Plano Pagamentos para ser incluida na api máxima.
        /// </summary>
        /// <param name="cobrancasPlanoPagamentos">Representação de uma lista de Cobrancas/Plano Pagamentos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaPlanoPagamentoMaxima>> IncluirCobrancasPlanoPagamentos(List<CobrancaPlanoPagamentoMaxima> cobrancasPlanoPagamentos)
        {
            return _cobrancaPlanoPagamentoMaximaApi.Incluir(cobrancasPlanoPagamentos);
        }

        /// <summary>
        /// Envia uma lista de Cobrancas/Plano Pagamentos para ser alterada na api máxima, se a Cobrancas/Plano Pagamentos não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cobrancasPlanoPagamentos">Representação de uma lista de Cobrancas/Plano Pagamentos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaPlanoPagamentoMaxima>> AlterarCobrancasPlanoPagamentos(List<CobrancaPlanoPagamentoMaxima> cobrancasPlanoPagamentos)
        {
            return _cobrancaPlanoPagamentoMaximaApi.Alterar(cobrancasPlanoPagamentos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cobrancas/Plano Pagamentos para ser excluida.
        /// </summary>
        /// <param name="cobrancasPlanoPagamentos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCobrancasPlanoPagamentos(string[] cobrancasPlanoPagamentos)
        {
            return _cobrancaPlanoPagamentoMaximaApi.Deletar(cobrancasPlanoPagamentos);
        }
    }
}

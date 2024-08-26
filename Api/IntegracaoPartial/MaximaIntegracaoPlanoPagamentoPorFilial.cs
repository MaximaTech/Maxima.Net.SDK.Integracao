using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorFilialMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="planosDePagamentoPorFilial">Representação de uma lista de <see cref="PlanoPagamentoPorFilialMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorFilialMaxima>> IncluirPlanosPagamentoPorFilial(List<PlanoPagamentoPorFilialMaxima> planosDePagamentoPorFilial)
        {
            return _planoPagamentoPorFilialApi.Incluir(planosDePagamentoPorFilial);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorFilialMaxima"/> para ser alterada na api máxima, se a <see cref="PlanoPagamentoPorFilialMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="planosDePagamentoPorFilial">Representação de uma lista de <see cref="PlanoPagamentoPorFilialMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorFilialMaxima>> AlterarPlanosPagamentoPorFilial(List<PlanoPagamentoPorFilialMaxima> planosDePagamentoPorFilial)
        {
            return _planoPagamentoPorFilialApi.Alterar(planosDePagamentoPorFilial);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PlanoPagamentoPorFilialMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="planosDePagamentoPorFilial">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPlanosPagamentoPorFilial(string[] planosDePagamentoPorFilial)
        {
            return _planoPagamentoPorFilialApi.Deletar(planosDePagamentoPorFilial);
        }
    }
}

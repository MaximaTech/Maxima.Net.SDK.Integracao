using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorRegiaoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="planosDePagamentoPorRegiao">Representação de uma lista de <see cref="PlanoPagamentoPorRegiaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorRegiaoMaxima>> IncluirPlanosPagamentoPorRegiao(List<PlanoPagamentoPorRegiaoMaxima> planosDePagamentoPorRegiao)
        {
            return _planoPagamentoPorRegiaoApi.Incluir(planosDePagamentoPorRegiao);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorRegiaoMaxima"/> para ser alterada na api máxima, se a <see cref="PlanoPagamentoPorRegiaoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="planosDePagamentoPorRegiao">Representação de uma lista de <see cref="PlanoPagamentoPorRegiaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorRegiaoMaxima>> AlterarPlanosPagamentoPorRegiao(List<PlanoPagamentoPorRegiaoMaxima> planosDePagamentoPorRegiao)
        {
            return _planoPagamentoPorRegiaoApi.Alterar(planosDePagamentoPorRegiao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PlanoPagamentoPorRegiaoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="planosDePagamentoPorRegiao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPlanosPagamentoPorRegiao(string[] planosDePagamentoPorRegiao)
        {
            return _planoPagamentoPorRegiaoApi.Deletar(planosDePagamentoPorRegiao);
        }
    }
}

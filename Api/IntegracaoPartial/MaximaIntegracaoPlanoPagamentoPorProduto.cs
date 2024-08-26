using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorProdutoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="planosDePagamentoPorProduto">Representação de uma lista de <see cref="PlanoPagamentoPorProdutoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorProdutoMaxima>> IncluirPlanosPagamentoPorProduto(List<PlanoPagamentoPorProdutoMaxima> planosDePagamentoPorProduto)
        {
            return _planoPagamentoPorProdutoApi.Incluir(planosDePagamentoPorProduto);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorProdutoMaxima"/> para ser alterada na api máxima, se a <see cref="PlanoPagamentoPorProdutoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="planosDePagamentoPorProduto">Representação de uma lista de <see cref="PlanoPagamentoPorProdutoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorProdutoMaxima>> AlterarPlanosPagamentoPorProduto(List<PlanoPagamentoPorProdutoMaxima> planosDePagamentoPorProduto)
        {
            return _planoPagamentoPorProdutoApi.Alterar(planosDePagamentoPorProduto);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PlanoPagamentoPorProdutoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="planosDePagamentoPorProduto">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPlanosPagamentoPorProduto(string[] planosDePagamentoPorProduto)
        {
            return _planoPagamentoPorProdutoApi.Deletar(planosDePagamentoPorProduto);
        }
    }
}

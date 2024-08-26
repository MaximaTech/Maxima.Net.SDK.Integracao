using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ProdutoSimilarMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtosSimilares">Representação de uma lista de <see cref="ProdutoSimilarMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ProdutoSimilarMaxima>> IncluirProdutosSimilares(List<ProdutoSimilarMaxima> produtosSimilares)
        {
            return _produtoSimilarMaximaApi.Incluir(produtosSimilares);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ProdutoSimilarMaxima"/> para ser alterada na api máxima, se a <see cref="ProdutoSimilarMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtosSimilares">Representação de uma lista de <see cref="ProdutoSimilarMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoSimilarMaxima>> AlterarProdutosSimilares(List<ProdutoSimilarMaxima> produtosSimilares)
        {
            return _produtoSimilarMaximaApi.Alterar(produtosSimilares);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ProdutoSimilarMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="produtosSimilares">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutosSimilares(string[] produtosSimilares)
        {
            return _produtoSimilarMaximaApi.Deletar(produtosSimilares);
        }
    }
}

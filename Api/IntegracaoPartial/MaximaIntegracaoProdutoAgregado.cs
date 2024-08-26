using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ProdutoAgregadoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtosAgregados">Representação de uma lista de <see cref="ProdutoAgregadoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ProdutoAgregadoMaxima>> IncluirProdutosAgregados(List<ProdutoAgregadoMaxima> produtosAgregados)
        {
            return _produtoAgregadoMaximaApi.Incluir(produtosAgregados);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ProdutoAgregadoMaxima"/> para ser alterada na api máxima, se a <see cref="ProdutoAgregadoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtosAgregados">Representação de uma lista de <see cref="ProdutoAgregadoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoAgregadoMaxima>> AlterarProdutosAgregados(List<ProdutoAgregadoMaxima> produtosAgregados)
        {
            return _produtoAgregadoMaximaApi.Alterar(produtosAgregados);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ProdutoAgregadoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="produtosAgregados">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutosAgregados(string[] produtosAgregados)
        {
            return _produtoAgregadoMaximaApi.Deletar(produtosAgregados);
        }
    }
}

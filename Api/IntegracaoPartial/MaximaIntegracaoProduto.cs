using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Produtos para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtos">Representação de uma lista de Produtos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>

        public Task<ResponseApiMaxima<ProdutoMaxima>> IncluirProdutos(List<ProdutoMaxima> produtos)
        {
            return _produtoMaximaApi.Incluir(produtos);
        }

        /// <summary>
        /// Envia uma lista de Produtos para ser alterada na api máxima, se o produto não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtos">Representação de uma lista de Produtos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoMaxima>> AlterarProdutos(List<ProdutoMaxima> produtos)
        {
            return _produtoMaximaApi.Alterar(produtos, ignoreValidacao: true);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Produtos para ser excluida.
        /// </summary>
        /// <param name="produtos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutos(string[] produtos)
        {
            return _produtoMaximaApi.Deletar(produtos);
        }
    }
}

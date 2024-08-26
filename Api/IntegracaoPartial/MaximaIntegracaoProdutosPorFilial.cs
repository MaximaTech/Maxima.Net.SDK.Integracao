using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Produtos por Filial para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtos">Representação de uma lista de Produtos por Filial</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>

        public Task<ResponseApiMaxima<ProdutosPorFilialMaxima>> IncluirProdutosPorFilial(List<ProdutosPorFilialMaxima> produtos)
        {
            return _produtosPorFilialMaximaApi.Incluir(produtos);
        }

        /// <summary>
        /// Envia uma lista de Produtos por Filial para ser alterada na api máxima, se o produto por filial não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtos">Representação de uma lista de Produtos por Filial</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutosPorFilialMaxima>> AlterarProdutosPorFilial(List<ProdutosPorFilialMaxima> produtos)
        {
            return _produtosPorFilialMaximaApi.Alterar(produtos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Produtos por Filial para ser excluida.
        /// </summary>
        /// <param name="produtos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutosPorFilial(string[] produtos)
        {
            return _produtosPorFilialMaximaApi.Deletar(produtos);
        }
    }
}

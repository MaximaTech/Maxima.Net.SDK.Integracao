using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cotas de Produtos para ser incluida na api máxima.
        /// </summary>
        /// <param name="cotasDeProdutos">Representação de uma lista de Cotas de Produtos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotasDeProdutoMaxima>> IncluirCotasDeProdutos(List<CotasDeProdutoMaxima> cotasDeProdutos)
        {
            return _cotasDeProdutoMaximaApi.Incluir(cotasDeProdutos);
        }

        /// <summary>
        /// Envia uma lista de Cotas de Produtos para ser alterada na api máxima, se a Cota de Produto não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cotasDeProdutos">Representação de uma lista de Cotas de Produtos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotasDeProdutoMaxima>> AlterarCotasDeProdutos(List<CotasDeProdutoMaxima> cotasDeProdutos)
        {
            return _cotasDeProdutoMaximaApi.Alterar(cotasDeProdutos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cotas de Produtos para ser excluida.
        /// </summary>
        /// <param name="cotasDeProdutos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCotasDeProdutos(string[] cotasDeProdutos)
        {
            return _cotasDeProdutoMaximaApi.Deletar(cotasDeProdutos);
        }
    }
}

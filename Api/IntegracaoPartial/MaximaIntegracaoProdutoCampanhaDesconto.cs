using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ProdutoCampanhaDescontoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtosCampanhaDescontos">Representação de uma lista de <see cref="ProdutoCampanhaDescontoMaxima"/></param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoCampanhaDescontoMaxima>> IncluirProdutosCampanhaDescontos(List<ProdutoCampanhaDescontoMaxima> produtosCampanhaDescontos)
        {
            return _produtoCampanhaDescontoMaximaApi.Incluir(produtosCampanhaDescontos);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ProdutoCampanhaDescontoMaxima"/> para ser alterada na api máxima, se o <see cref="ProdutoCampanhaDescontoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtosCampanhaDescontos">Representação de uma lista de <see cref="ProdutoCampanhaDescontoMaxima"/></param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoCampanhaDescontoMaxima>> AlterarProdutosCampanhaDescontos(List<ProdutoCampanhaDescontoMaxima> produtosCampanhaDescontos)
        {
            return _produtoCampanhaDescontoMaximaApi.Alterar(produtosCampanhaDescontos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ProdutoCampanhaDescontoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="produtosCampanhaDescontos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutosCampanhaDescontos(string[] produtosCampanhaDescontos)
        {
            return _produtoCampanhaDescontoMaximaApi.Deletar(produtosCampanhaDescontos);
        }
    }
}

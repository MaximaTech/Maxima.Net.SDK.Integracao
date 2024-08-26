using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ProdutoCestaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="produtoCesta">Representação de uma lista de <see cref="ProdutoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ProdutoCestaMaxima>> IncluirProdutoCesta(List<ProdutoCestaMaxima> produtoCesta)
        {
            return _produtoCestaApi.Incluir(produtoCesta);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ProdutoCestaMaxima"/> para ser alterada na api máxima, se a <see cref="ProdutoCestaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="produtoCesta">Representação de uma lista de <see cref="ProdutoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProdutoCestaMaxima>> AlterarProdutoCesta(List<ProdutoCestaMaxima> produtoCesta)
        {
            return _produtoCestaApi.Alterar(produtoCesta);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ProdutoCestaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="produtoCesta">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProdutoCesta(string[] produtoCesta)
        {
            return _produtoCestaApi.Deletar(produtoCesta);
        }
    }
}

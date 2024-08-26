using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Estoque para ser incluida na api máxima.
        /// </summary>
        /// <param name="estoques">Representação de uma lista de Estoque</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstoqueMaxima>> IncluirEstoques(List<EstoqueMaxima> estoques)
        {
            return _estoqueMaximaApi.Incluir(estoques);
        }

        /// <summary>
        /// Envia uma lista de Estoque para ser alterada na api máxima, se o estoque não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="estoques">Representação de uma lista de Estoque</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstoqueMaxima>> AlterarEstoques(List<EstoqueMaxima> estoques)
        {
            return _estoqueMaximaApi.Alterar(estoques);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Estoque para ser excluida.
        /// </summary>
        /// <param name="estoques">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEstoque(string[] estoques)
        {
            return _estoqueMaximaApi.Deletar(estoques);
        }
    }
}

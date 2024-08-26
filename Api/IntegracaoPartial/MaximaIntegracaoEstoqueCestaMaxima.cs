using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="EstoqueCestaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="estoquesCestas">Representação de uma lista de <see cref="EstoqueCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<EstoqueCestaMaxima>> IncluirEstoquesCestas(List<EstoqueCestaMaxima> estoquesCestas)
        {
            return _estoqueCestaMaximaApi.Incluir(estoquesCestas);
        }

        /// <summary>
        /// Envia uma lista de <see cref="EstoqueCestaMaxima"/> para ser alterada na api máxima, se a <see cref="EstoqueCestaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="estoquesCestas">Representação de uma lista de <see cref="EstoqueCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstoqueCestaMaxima>> AlterarEstoquesCestas(List<EstoqueCestaMaxima> estoquesCestas)
        {
            return _estoqueCestaMaximaApi.Alterar(estoquesCestas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="EstoqueCestaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="estoquesCestas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEstoquesCestas(string[] estoquesCestas)
        {
            return _estoqueCestaMaximaApi.Deletar(estoquesCestas);
        }
    }
}

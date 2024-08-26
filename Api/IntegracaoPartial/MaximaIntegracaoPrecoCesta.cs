using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PrecoCestaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="precosCesta">Representação de uma lista de <see cref="PrecoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrecoCestaMaxima>> IncluirPrecosCesta(List<PrecoCestaMaxima> precosCesta)
        {
            return _precoCestaMaximaApi.Incluir(precosCesta);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PrecoCestaMaxima"/> para ser alterada na api máxima, se a <see cref="PrecoCestaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="precosCesta">Representação de uma lista de <see cref="PrecoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrecoCestaMaxima>> AlterarPrecosCesta(List<PrecoCestaMaxima> precosCesta)
        {
            return _precoCestaMaximaApi.Alterar(precosCesta);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PrecoCestaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="precosCesta">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrecosCesta(string[] precosCesta)
        {
            return _precoCestaMaximaApi.Deletar(precosCesta);
        }
    }
}

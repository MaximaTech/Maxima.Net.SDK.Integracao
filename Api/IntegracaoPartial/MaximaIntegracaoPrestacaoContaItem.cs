using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PrestacaoContaItemMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="prestacoesContaItem">Representação de uma lista de <see cref="PrestacaoContaItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrestacaoContaItemMaxima>> IncluirPrestacoesContaItem(List<PrestacaoContaItemMaxima> prestacoesContaItem)
        {
            return _prestacaoContaItemMaximaApi.Incluir(prestacoesContaItem);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PrestacaoContaItemMaxima"/> para ser alterada na api máxima, se a <see cref="PrestacaoContaItemMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="prestacoesContaItem">Representação de uma lista de <see cref="PrestacaoContaItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrestacaoContaItemMaxima>> AlterarPrestacoesContaItem(List<PrestacaoContaItemMaxima> prestacoesContaItem)
        {
            return _prestacaoContaItemMaximaApi.Alterar(prestacoesContaItem);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PrestacaoContaItemMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="prestacoesContaItem">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrestacoesContaItem(string[] prestacoesContaItem)
        {
            return _prestacaoContaItemMaximaApi.Deletar(prestacoesContaItem);
        }
    }
}

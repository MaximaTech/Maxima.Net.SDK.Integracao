using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="TipoOperacaoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="tiposOperacao">Representação de uma lista de <see cref="TipoOperacaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<TipoOperacaoMaxima>> IncluirTiposOperacao(List<TipoOperacaoMaxima> tiposOperacao)
        {
            return _tipoOperacaoMaximaApi.Incluir(tiposOperacao);
        }

        /// <summary>
        /// Envia uma lista de <see cref="TipoOperacaoMaxima"/> para ser alterada na api máxima, se a <see cref="TipoOperacaoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tiposOperacao">Representação de uma lista de <see cref="TipoOperacaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TipoOperacaoMaxima>> AlterarTiposOperacao(List<TipoOperacaoMaxima> tiposOperacao)
        {
            return _tipoOperacaoMaximaApi.Alterar(tiposOperacao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="TipoOperacaoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="tiposOperacao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTiposOperacao(string[] tiposOperacao)
        {
            return _tipoOperacaoMaximaApi.Deletar(tiposOperacao);
        }
    }
}

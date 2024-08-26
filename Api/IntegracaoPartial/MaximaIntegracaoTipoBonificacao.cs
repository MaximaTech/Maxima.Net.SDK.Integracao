using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="TipoBonificacaoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="tipoBonificacao">Representação de uma lista de <see cref="TipoBonificacaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<TipoBonificacaoMaxima>> IncluirTipoBonificacao(List<TipoBonificacaoMaxima> tipoBonificacao)
        {
            return _tipoBonificacaoMaximaApi.Incluir(tipoBonificacao);
        }

        /// <summary>
        /// Envia uma lista de <see cref="TipoBonificacaoMaxima"/> para ser alterada na api máxima, se a <see cref="TipoBonificacaoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tipoBonificacao">Representação de uma lista de <see cref="TipoBonificacaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TipoBonificacaoMaxima>> AlterarTipoBonificacao(List<TipoBonificacaoMaxima> tipoBonificacao)
        {
            return _tipoBonificacaoMaximaApi.Alterar(tipoBonificacao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="TipoBonificacaoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="tipoBonificacao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTipoBonificacao(string[] tipoBonificacao)
        {
            return _tipoBonificacaoMaximaApi.Deletar(tipoBonificacao);
        }
    }
}

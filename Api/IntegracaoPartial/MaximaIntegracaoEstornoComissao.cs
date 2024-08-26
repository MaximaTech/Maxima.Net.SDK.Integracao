using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="EstornoComissaoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="estornoComissao">Representação de uma lista de <see cref="EstornoComissaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<EstornoComissaoMaxima>> IncluirEstornosComissao(List<EstornoComissaoMaxima> estornoComissao)
        {
            return _estornoComissaoMaximaApi.Incluir(estornoComissao);
        }

        /// <summary>
        /// Envia uma lista de <see cref="EstornoComissaoMaxima"/> para ser alterada na api máxima, se a <see cref="EstornoComissaoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="estornoComissao">Representação de uma lista de <see cref="EstornoComissaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstornoComissaoMaxima>> AlterarEstornosComissao(List<EstornoComissaoMaxima> estornoComissao)
        {
            return _estornoComissaoMaximaApi.Alterar(estornoComissao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="EstornoComissaoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="estornoComissao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEstornosComissao(string[] estornoComissao)
        {
            return _estornoComissaoMaximaApi.Deletar(estornoComissao);
        }
    }
}

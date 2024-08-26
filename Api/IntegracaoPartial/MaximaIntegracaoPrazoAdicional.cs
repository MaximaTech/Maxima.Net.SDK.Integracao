using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PrazoAdicionalMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="prazosAdicionais">Representação de uma lista de <see cref="PrazoAdicionalMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrazoAdicionalMaxima>> IncluirPrazosAdicionais(List<PrazoAdicionalMaxima> prazosAdicionais)
        {
            return _prazoAdicionalMaximaApi.Incluir(prazosAdicionais);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PrazoAdicionalMaxima"/> para ser alterada na api máxima, se a <see cref="PrazoAdicionalMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="prazosAdicionais">Representação de uma lista de <see cref="PrazoAdicionalMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrazoAdicionalMaxima>> AlterarPrazosAdicionais(List<PrazoAdicionalMaxima> prazosAdicionais)
        {
            return _prazoAdicionalMaximaApi.Alterar(prazosAdicionais);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PrazoAdicionalMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="prazosAdicionais">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrazosAdicionais(string[] prazosAdicionais)
        {
            return _prazoAdicionalMaximaApi.Deletar(prazosAdicionais);
        }
    }
}

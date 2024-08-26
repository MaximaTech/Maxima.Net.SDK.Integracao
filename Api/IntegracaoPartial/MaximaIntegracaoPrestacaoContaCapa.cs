using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PrestacaoContaCapaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="prestacaoContas">Representação de uma lista de <see cref="PrestacaoContaCapaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrestacaoContaCapaMaxima>> IncluirPrestacaoContas(List<PrestacaoContaCapaMaxima> prestacaoContas)
        {
            return _prestacaoContaCapaMaximaApi.Incluir(prestacaoContas);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PrestacaoContaCapaMaxima"/> para ser alterada na api máxima, se a <see cref="PrestacaoContaCapaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="prestacaoContas">Representação de uma lista de <see cref="PrestacaoContaCapaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrestacaoContaCapaMaxima>> AlterarPrestacaoContas(List<PrestacaoContaCapaMaxima> prestacaoContas)
        {
            return _prestacaoContaCapaMaximaApi.Alterar(prestacaoContas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PrestacaoContaCapaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="prestacaoContas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrestacaoContas(string[] prestacaoContas)
        {
            return _prestacaoContaCapaMaximaApi.Deletar(prestacaoContas);
        }
    }
}

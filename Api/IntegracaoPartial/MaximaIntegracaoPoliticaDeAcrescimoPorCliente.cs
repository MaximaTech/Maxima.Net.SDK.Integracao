using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PoliticaDeAcrescimoPorClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="politicasDeAcrescimoPorClientes">Representação de uma lista de <see cref="PoliticaDeAcrescimoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PoliticaDeAcrescimoPorClienteMaxima>> IncluirPoliticasDeAcrescimoPorClientes(List<PoliticaDeAcrescimoPorClienteMaxima> politicasDeAcrescimoPorClientes)
        {
            return _politicaDeAcrescimoPorClienteMaximaApi.Incluir(politicasDeAcrescimoPorClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PoliticaDeAcrescimoPorClienteMaxima"/> para ser alterada na api máxima, se a <see cref="PoliticaDeAcrescimoPorClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="politicasDeAcrescimoPorClientes">Representação de uma lista de <see cref="PoliticaDeAcrescimoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PoliticaDeAcrescimoPorClienteMaxima>> AlterarPoliticasDeAcrescimoPorClientes(List<PoliticaDeAcrescimoPorClienteMaxima> politicasDeAcrescimoPorClientes)
        {
            return _politicaDeAcrescimoPorClienteMaximaApi.Alterar(politicasDeAcrescimoPorClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PoliticaDeAcrescimoPorClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="politicasDeAcrescimoPorClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPoliticasDeAcrescimoPorClientes(string[] politicasDeAcrescimoPorClientes)
        {
            return _politicaDeAcrescimoPorClienteMaximaApi.Deletar(politicasDeAcrescimoPorClientes);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cotação capa para ser incluida na api máxima.
        /// </summary>
        /// <param name="cotacaoCapas">Representação de uma lista de Cotação capa</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotacaoCapaMaxima>> IncluirCotacoesCapa(List<CotacaoCapaMaxima> cotacaoCapas)
        {
            return _cotacaoCapaMaximaApi.Incluir(cotacaoCapas);
        }

        /// <summary>
        /// Envia uma lista de Cotação capa para ser alterada na api máxima, se a Cotação não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cotacaoCapas">Representação de uma lista de Cotação capa</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotacaoCapaMaxima>> AlterarCotacoesCapa(List<CotacaoCapaMaxima> cotacaoCapas)
        {
            return _cotacaoCapaMaximaApi.Alterar(cotacaoCapas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cotação capa para ser excluida.
        /// </summary>
        /// <param name="cotacaoCapas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCotacoesCapa(string[] cotacaoCapas)
        {
            return _cotacaoCapaMaximaApi.Deletar(cotacaoCapas);
        }
    }
}

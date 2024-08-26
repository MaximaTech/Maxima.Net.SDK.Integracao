using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Seções para ser incluida na api máxima.
        /// </summary>
        /// <param name="secoes">Representação de uma lista de Seções</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SecaoMaxima>> IncluirSecoes(List<SecaoMaxima> secoes)
        {
            return _secaoMaximaApi.Incluir(secoes);
        }

        /// <summary>
        /// Envia uma lista de Seções para ser alterada na api máxima, se a seção não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="secoes">Representação de uma lista de Seções</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SecaoMaxima>> AlterarSecoes(List<SecaoMaxima> secoes)
        {
            return _secaoMaximaApi.Alterar(secoes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Seções para ser excluida.
        /// </summary>
        /// <param name="secoes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarSecoes(string[] secoes)
        {
            return _secaoMaximaApi.Deletar(secoes);
        }
    }
}

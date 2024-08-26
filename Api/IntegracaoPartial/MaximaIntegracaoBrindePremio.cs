using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Brinde Premios para ser incluida na api máxima.
        /// </summary>
        /// <param name="brindePremios">Representação de uma lista de Brinde Premios</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindePremioMaxima>> IncluirBrindePremios(List<BrindePremioMaxima> brindePremios)
        {
            return _brindePremioMaximaApi.Incluir(brindePremios);
        }

        /// <summary>
        /// Envia uma lista de Brinde Premios para ser alterada na api máxima, se o brinde não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="brindePremios">Representação de uma lista de Brinde Premios</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindePremioMaxima>> AlterarBrindePremios(List<BrindePremioMaxima> brindePremios)
        {
            return _brindePremioMaximaApi.Alterar(brindePremios);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Brinde Premios para ser excluida.
        /// </summary>
        /// <param name="brindePremios">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarBrindePremios(string[] brindePremios)
        {
            return _brindePremioMaximaApi.Deletar(brindePremios);
        }
    }
}

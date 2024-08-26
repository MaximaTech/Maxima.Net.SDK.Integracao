using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Brinde Restricoes para ser incluida na api máxima.
        /// </summary>
        /// <param name="brindeRestricoes">Representação de uma lista de Brinde Restricoes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeRestricaoMaxima>> IncluirBrindeRestricoes(List<BrindeRestricaoMaxima> brindeRestricoes)
        {
            return _brindeRestricaoMaximaApi.Incluir(brindeRestricoes);
        }

        /// <summary>
        /// Envia uma lista de Brinde Restricoes para ser alterada na api máxima, se o brinde não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="brindeRestricoes">Representação de uma lista de Brinde Restricoes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeRestricaoMaxima>> AlterarBrindeRestricoes(List<BrindeRestricaoMaxima> brindeRestricoes)
        {
            return _brindeRestricaoMaximaApi.Alterar(brindeRestricoes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Brinde Restricoes para ser excluida.
        /// </summary>
        /// <param name="brindeRestricoes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarBrindeRestricoes(string[] brindeRestricoes)
        {
            return _brindeRestricaoMaximaApi.Deletar(brindeRestricoes);
        }
    }
}

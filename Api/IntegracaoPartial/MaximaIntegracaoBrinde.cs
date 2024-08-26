using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Brindes para ser incluida na api máxima.
        /// </summary>
        /// <param name="brinde">Representação de uma lista de Brindes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeMaxima>> IncluirBrindes(List<BrindeMaxima> brinde)
        {
            return _brindeMaximaApi.Incluir(brinde);
        }

        /// <summary>
        /// Envia uma lista de Brindes para ser alterada na api máxima, se o Brinde não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="brinde">Representação de uma lista de Brindes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeMaxima>> AlterarBrindes(List<BrindeMaxima> brinde)
        {
            return _brindeMaximaApi.Alterar(brinde);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Brindes para ser excluida.
        /// </summary>
        /// <param name="brinde">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarBrindes(string[] brinde)
        {
            return _brindeMaximaApi.Deletar(brinde);
        }
    }
}

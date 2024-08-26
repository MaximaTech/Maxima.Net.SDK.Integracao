using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Estados para ser incluida na api máxima.
        /// </summary>
        /// <param name="estados">Representação de uma lista de Estados</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstadoMaxima>> IncluirEstados(List<EstadoMaxima> estados)
        {
            return _estadoMaximaApi.Incluir(estados);
        }

        /// <summary>
        /// Envia uma lista de Estados para ser alterada na api máxima, se o estado não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="estados">Representação de uma lista de Estados</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EstadoMaxima>> AlterarEstados(List<EstadoMaxima> estados)
        {
            return _estadoMaximaApi.Alterar(estados);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Estados para ser excluida.
        /// </summary>
        /// <param name="estados">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEstados(string[] estados)
        {
            return _estadoMaximaApi.Deletar(estados);
        }
    }
}

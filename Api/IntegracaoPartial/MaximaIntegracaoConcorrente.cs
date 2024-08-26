using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Concorrentes para ser incluida na api máxima.
        /// </summary>
        /// <param name="concorrentes">Representação de uma lista de Concorrentes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ConcorrenteMaxima>> IncluirConcorrentes(List<ConcorrenteMaxima> concorrentes)
        {
            return _concorrenteMaximaApi.Incluir(concorrentes);
        }

        /// <summary>
        /// Envia uma lista de Concorrentes para ser alterada na api máxima, se a Concorrentes não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="concorrentes">Representação de uma lista de Concorrentes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ConcorrenteMaxima>> AlterarConcorrentes(List<ConcorrenteMaxima> concorrentes)
        {
            return _concorrenteMaximaApi.Alterar(concorrentes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Concorrentes para ser excluida.
        /// </summary>
        /// <param name="concorrentes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarConcorrentes(string[] concorrentes)
        {
            return _concorrenteMaximaApi.Deletar(concorrentes);
        }
    }
}

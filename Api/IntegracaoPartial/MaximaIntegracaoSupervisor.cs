using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Supervisor para ser incluida na api máxima.
        /// </summary>
        /// <param name="supervisores">Representação de uma lista de Supervisor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SupervisorMaxima>> IncluirSupervisor(List<SupervisorMaxima> supervisores)
        {
            return _supervisorMaximaApi.Incluir(supervisores);
        }

        /// <summary>
        /// Envia uma lista de Supervisor para ser alterada na api máxima, se o supervisor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="supervisores">Representação de uma lista de Supervisor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SupervisorMaxima>> AlterarSupervisor(List<SupervisorMaxima> supervisores)
        {
            return _supervisorMaximaApi.Alterar(supervisores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Supervisor para ser excluida.
        /// </summary>
        /// <param name="supervisores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarSupervisor(string[] supervisores)
        {
            return _supervisorMaximaApi.Deletar(supervisores);
        }
    }
}

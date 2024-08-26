using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Motivo de devolução da NF para ser incluida na api máxima.
        /// </summary>
        /// <param name="motivoDevolucao">Representação de uma lista de Motivo de devolução da NF</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoDevolucaoMaxima>> IncluirMotivoDevolucao(List<MotivoDevolucaoMaxima> motivoDevolucao)
        {
            return _motivoDevolucaoMaximaApi.Incluir(motivoDevolucao);
        }

        /// <summary>
        /// Envia uma lista de Motivo de devolução da NF para ser alterada na api máxima, se a Motivo de devolução da NF não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="motivoDevolucao">Representação de uma lista de Motivo de devolução da NF</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoDevolucaoMaxima>> AlterarMotivoDevolucao(List<MotivoDevolucaoMaxima> motivoDevolucao)
        {
            return _motivoDevolucaoMaximaApi.Alterar(motivoDevolucao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Motivo de devolução da NF para ser excluida.
        /// </summary>
        /// <param name="motivoDevolucao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMotivoDevolucao(string[] motivoDevolucao)
        {
            return _motivoDevolucaoMaximaApi.Deletar(motivoDevolucao);
        }
    }
}

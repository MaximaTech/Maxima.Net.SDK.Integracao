using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Transportadora para ser incluida na api máxima.
        /// </summary>
        /// <param name="transportadoras">Representação de uma lista de Transportadora</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TransportadoraMaxima>> IncluirTransportadora(List<TransportadoraMaxima> transportadoras)
        {
            return _transportadoraMaximaApi.Incluir(transportadoras);
        }

        /// <summary>
        /// Envia uma lista de Transportadora para ser alterada na api máxima, se a transportadora não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="transportadoras">Representação de uma lista de Transportadora</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TransportadoraMaxima>> AlterarTransportadora(List<TransportadoraMaxima> transportadoras)
        {
            return _transportadoraMaximaApi.Alterar(transportadoras);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Transportadora para ser excluida.
        /// </summary>
        /// <param name="transportadoras">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTransportadoras(string[] transportadoras)
        {
            return _transportadoraMaximaApi.Deletar(transportadoras);
        }
    }
}

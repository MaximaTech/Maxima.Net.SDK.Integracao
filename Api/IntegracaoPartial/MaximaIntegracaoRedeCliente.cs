using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Redes para ser incluida na api máxima.
        /// </summary>
        /// <param name="redes">Representação de uma lista de Redes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RedeClienteMaxima>> IncluirRedesClientes(List<RedeClienteMaxima> redes)
        {
            return _redeMaximaApi.Incluir(redes);
        }

        /// <summary>
        /// Envia uma lista de Redes para ser alterada na api máxima, se a rede não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="redes">Representação de uma lista de Redes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RedeClienteMaxima>> AlterarRedesClientes(List<RedeClienteMaxima> redes)
        {
            return _redeMaximaApi.Alterar(redes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Redes para ser excluida.
        /// </summary>
        /// <param name="redes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRedesClientes(string[] redes)
        {
            return _redeMaximaApi.Deletar(redes);
        }
    }
}

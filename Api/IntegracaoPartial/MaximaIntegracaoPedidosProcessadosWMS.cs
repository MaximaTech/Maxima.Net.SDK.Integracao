using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Pedidos Processados pelo WMS para ser incluida na api máxima.
        /// </summary>
        /// <param name="pedidosProcessados">Representação de uma lista de Pedidos Processados pelo WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PedidosProcessadosWMSMaxima>> IncluirPedidosProcessadosWMS(List<PedidosProcessadosWMSMaxima> pedidosProcessados)
        {
            return _pedidosProcessadosWMSMaximaMaximaApi.Incluir(pedidosProcessados);
        }

        /// <summary>
        /// Envia uma lista de Pedidos Processados pelo WMS para ser alterada na api máxima, se a Pedidos Processados pelo WMS não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="pedidosProcessados">Representação de uma lista de Pedidos Processados pelo WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PedidosProcessadosWMSMaxima>> AlterarPedidosProcessadosWMS(List<PedidosProcessadosWMSMaxima> pedidosProcessados)
        {
            return _pedidosProcessadosWMSMaximaMaximaApi.Alterar(pedidosProcessados);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Pedidos Processados pelo WMS para ser excluida.
        /// </summary>
        /// <param name="pedidosProcessados">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPedidosProcessadosWMS(string[] pedidosProcessados)
        {
            return _pedidosProcessadosWMSMaximaMaximaApi.Deletar(pedidosProcessados);
        }
    }
}

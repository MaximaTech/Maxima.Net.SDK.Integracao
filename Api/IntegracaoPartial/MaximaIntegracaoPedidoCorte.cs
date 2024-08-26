using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Histórico Pedido Corte para ser incluida na api máxima.
        /// </summary>
        /// <param name="historicoPedidoCortes">Representação de uma lista de Histórico Pedido Corte</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<HistoricoPedidoCorteMaxima>> IncluirHistoricosPedidoCorte(List<HistoricoPedidoCorteMaxima> historicoPedidoCortes)
        {
            return _historicoPedidoCorteMaximaApi.Incluir(historicoPedidoCortes);
        }

        /// <summary>
        /// Envia uma lista de Histórico Pedido Corte para ser alterada na api máxima, se o historicoPedidoCorte não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="historicoPedidoCortes">Representação de uma lista de Histórico Pedido Corte</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<HistoricoPedidoCorteMaxima>> AlterarHistoricosPedidoCorte(List<HistoricoPedidoCorteMaxima> historicoPedidoCortes)
        {
            return _historicoPedidoCorteMaximaApi.Alterar(historicoPedidoCortes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Histórico Pedido Corte para ser excluida.
        /// </summary>
        /// <param name="historicoPedidoCortes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarHistoricoPedidoCorte(string[] historicoPedidoCortes)
        {
            return _historicoPedidoCorteMaximaApi.Deletar(historicoPedidoCortes);
        }
    }
}

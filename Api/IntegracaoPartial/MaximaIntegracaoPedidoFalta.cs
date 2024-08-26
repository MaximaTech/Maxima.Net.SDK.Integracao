using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Histórico Pedido Falta para ser incluida na api máxima.
        /// </summary>
        /// <param name="historicoPedidoFaltas">Representação de uma lista de Histórico Pedido Falta</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<HistoricoPedidoFaltaMaxima>> IncluirHistoricosPedidoFalta(List<HistoricoPedidoFaltaMaxima> historicoPedidoFaltas)
        {
            return _historicoPedidoFaltaApi.Incluir(historicoPedidoFaltas);
        }

        /// <summary>
        /// Envia uma lista de HistoricoPedidoFalta para ser alterada na api máxima, se a Histórico Pedido Falta não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="historicoPedidoFaltas">Representação de uma lista de Histórico Pedido Falta</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<HistoricoPedidoFaltaMaxima>> AlterarHistoricosPedidoFalta(List<HistoricoPedidoFaltaMaxima> historicoPedidoFaltas)
        {
            return _historicoPedidoFaltaApi.Alterar(historicoPedidoFaltas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Histórico Pedido Falta para ser excluida.
        /// </summary>
        /// <param name="historicoPedidoFaltas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarHistoricoPedidoFalta(string[] historicoPedidoFaltas)
        {
            return _historicoPedidoFaltaApi.Deletar(historicoPedidoFaltas);
        }
    }
}

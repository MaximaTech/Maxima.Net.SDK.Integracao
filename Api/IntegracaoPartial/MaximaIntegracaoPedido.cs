using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Ao termino da importação de um pedido esse metodo deve ser chamado para que seja enviado o histórico de sucesso ou erro para máxima.
        /// </summary>
        /// <param name="pedidoMaxima">O pedido máxima que foi importado.</param>
        /// <param name="numeroPedidoErp">O número do pedido do ERP que foi importado.</param>
        /// <param name="descricaoCriticaPedido">Uma breve descrição de sucesso ou erro do pedido.</param>
        /// <param name="posicaoPedido">A posição do pedido na máxima.<see cref="EnumPosicaoPedido"/></param>
        public Task<RetornoApiMaxima> IncluirHistoricoPedidoImportado(
            PedidoMaxima pedidoMaxima,
            int numeroPedidoErp,
            string descricaoCriticaPedido,
            EnumPosicaoPedido posicaoPedido
        )
        {
            return _pedidoMaximaApi.IncluirHistoricoPedidoImportado(pedidoMaxima, numeroPedidoErp, descricaoCriticaPedido, posicaoPedido);
        }

        /// <summary>
        /// Envia uma lista de histórico de pedidos.
        /// </summary>
        /// <param name="historicoPedidos">Representação da capa e itens de um pedido</param>
        /// <param name="deletarItens">Informa se devemos deletar o itens antes de atualizar ou inserir</param>
        public Task<ResponseApiMaxima<HistoricoPedidoMaxima>> IncluirHistoricosPedido(List<HistoricoPedidoMaxima> historicoPedidos, bool deletarItens = false)
        {
            return _pedidoMaximaApi.IncluirHistoricoPedido(historicoPedidos, deletarItens);
        }

        public Task<ResponseApiMaxima<HistoricoPedidoMaxima>> IncluirHistoricosPedido(List<HistoricoPedidoMaxima> historicoPedidos)
        {
            return IncluirHistoricosPedido(historicoPedidos, false);
        }

        public Task<ResponseApiMaxima<HistoricoPedidoCapa>> AlterarHistoricosPedidoCapa(List<HistoricoPedidoCapa> historicoPedidos)
        {
            return _pedidoMaximaApi.AtualizarHistoricoCapaPedido(historicoPedidos);
        }

        public Task<ResponseApiMaxima<HistoricoPedidoItem>> AlterarHistoricosPedidoItem(List<HistoricoPedidoItem> historicoPedidosItens)
        {
            return _pedidoMaximaApi.AtualizarHistoricoItensPedido(historicoPedidosItens);
        }

        /// <summary>
        /// Envia uma lista de histório pedidos capa.
        /// </summary>
        /// <param name="historicoPedidos">Representação da capa e itens de um pedido</param>
        public Task<ResponseApiMaxima<HistoricoPedidoCapa>> AtualizarHistoricosPedido(List<HistoricoPedidoCapa> historicoPedidos)
        {
            return _pedidoMaximaApi.AtualizarHistoricoCapaPedido(historicoPedidos);
        }

        /// <summary>
        /// Envia uma lista de histórico de pedidos para serem roterizados.
        /// </summary>
        /// <param name="historicoPedidos">Representação da capa do pedido</param>
        public Task<ResponseApiMaxima<HistoricoPedidoCapa>> MarcarPedidosParaRoterizar(List<HistoricoPedidoCapa> historicoPedidos)
        {
            return _pedidoMaximaApi.MarcarPedidosParaRoterizar(historicoPedidos);
        }

        /// <summary>
        /// Atualiza o status do pedido.
        /// </summary>
        /// <param name="statusPedido"></param>
        /// <returns></returns>
        public Task<RetornoApiMaxima> AtualizarHistoricosPedido(RequestStatusPedido statusPedido)
        {
            return _pedidoMaximaApi.AtualizarHistoricoPedido(statusPedido);
        }

        /// <summary>
        /// Atualiza um status de pedido.
        /// </summary>
        /// <param name="requestStatusPedido">Valores usado para salvar um status.</param>
        /// <param name="isErro">Se o pedido esta com erro ou não.</param>
        /// <returns></returns>
        public Task<RetornoApiMaxima> AtualizarStatusPedido(RequestStatusPedido requestStatusPedido, bool isErro = false)
        {
            return _pedidoMaximaApi.AtualizarStatusPedido(requestStatusPedido, isErro);
        }

        /// <summary>
        /// Buscar histórico de pedido pelo num car
        /// </summary>
        /// <param name="numCar">Número do carregamento</param>
        /// <returns></returns>
        public Task<List<HistoricoPedidoCapa>> BuscarHistoricoPedidoCapaPeloNumCar(string numCar)
        {
            return _pedidoMaximaApi.BuscarHistoricoPedidoCapaPeloNunCar(numCar);
        }
    }
}

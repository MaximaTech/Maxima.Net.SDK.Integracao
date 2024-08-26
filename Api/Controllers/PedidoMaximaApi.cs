using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Entidades;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    public class PedidoMaximaApi
    {
        private readonly IApiMaxima _api;
        private readonly ApiBase<HistoricoPedidoCapa> apiHistorioCapa;
        private readonly ApiBase<HistoricoPedidoItem> apiHistorioItem;

        public PedidoMaximaApi(IApiMaxima apiMaxima, ApiBase<HistoricoPedidoCapa> apiHistoricoCapa, ApiBase<HistoricoPedidoItem> apiHistoricoItem)
        {
            this.apiHistorioCapa = apiHistoricoCapa;
            this.apiHistorioItem = apiHistoricoItem;
            _api = apiMaxima;
        }

        internal async Task<List<HistoricoPedidoCapa>> BuscarHistoricoPedidoCapaPeloNunCar(string numCar)
        {
            RetornoApiMaxima retornoApiMaxima = await _api.Get(
                HistoricoPedidoCapa.VersaoAPI,
                $"{HistoricoPedidoCapa.EndPoint}/PorNumeroDoCarregamento/{numCar}"
            );
            if (retornoApiMaxima != null && retornoApiMaxima.Data != null)
                return JsonConvert.DeserializeObject<List<HistoricoPedidoCapa>>(retornoApiMaxima.Data.ToString());
            else
                return new List<HistoricoPedidoCapa>();
        }

        internal async Task<ResponseApiMaxima<HistoricoPedidoMaxima>> IncluirHistoricoPedido(
            List<HistoricoPedidoMaxima> historicoPedidos,
            bool deletarItens = false
        )
        {
            ResponseApiMaxima<HistoricoPedidoMaxima> listRetorno = new ResponseApiMaxima<HistoricoPedidoMaxima>();

            foreach (var histPedido in historicoPedidos)
            {
                var itensPedidoOrdenado = histPedido.ItensPedido.OrderBy(p => p.CodigoProduto).ToList();
                for (int i = 0; i < itensPedidoOrdenado.Count; i++)
                {
                    itensPedidoOrdenado[i].NumeroPedido = histPedido.CapaPedido.NumeroPedido;
                    itensPedidoOrdenado[i].Data = histPedido.CapaPedido.Data;
                    itensPedidoOrdenado[i].SequenciaItem = i;
                }
                histPedido.ItensPedido = itensPedidoOrdenado;

                var retonroItens = new ResponseApiMaxima<HistoricoPedidoItem>();
                var retornoCapa = await apiHistorioCapa.Incluir(new List<HistoricoPedidoCapa> { histPedido.CapaPedido });

                if (retornoCapa.Sucesso)
                {
                    if (deletarItens)
                        await apiHistorioItem.DeletarComParametros(new string[] { histPedido.CapaPedido.NumeroPedido.ToString() }, "RemoverItens");

                    retonroItens = await apiHistorioItem.Incluir(histPedido.ItensPedido);
                }

                if (retornoCapa.Sucesso && retonroItens.Sucesso)
                {
                    listRetorno.ItensInserido.Add(histPedido);
                }
                else
                {
                    listRetorno.TotalItensNaoInserido++;
                    listRetorno.ErrosValidacao.AddRange(retornoCapa.ErrosValidacao);
                    listRetorno.ErrosValidacao.AddRange(retonroItens.ErrosValidacao);
                }
            }

            return listRetorno;
        }

        internal async Task<ResponseApiMaxima<HistoricoPedidoCapa>> MarcarPedidosParaRoterizar(List<HistoricoPedidoCapa> listNumerosPedidos)
        {
            List<HistoricoPedidoCapa> listaCapasEnvio = new List<HistoricoPedidoCapa>();
            foreach (var pedidoCapa in listNumerosPedidos)
            {
                listaCapasEnvio.Add(new HistoricoPedidoCapa() { NumeroPedido = pedidoCapa.NumeroPedido, PosicaoPedido = "R" });
            }

            var retornoCapa = await apiHistorioCapa.Alterar(listaCapasEnvio, ignoreValidacao: true);

            return retornoCapa;
        }

        internal async Task<ResponseApiMaxima<HistoricoPedidoCapa>> AtualizarHistoricoCapaPedido(List<HistoricoPedidoCapa> listCapaPedido)
        {
            var retornoCapa = await apiHistorioCapa.Alterar(listCapaPedido);

            return retornoCapa;
        }

        internal async Task<ResponseApiMaxima<HistoricoPedidoItem>> AtualizarHistoricoItensPedido(List<HistoricoPedidoItem> listItensPedido)
        {
            var retornoCapa = await apiHistorioItem.Alterar(listItensPedido);

            return retornoCapa;
        }

        internal async Task<RetornoApiMaxima> IncluirHistoricoPedidoImportado(
            PedidoMaxima pedidoMaxima,
            int numeroPedidoErp,
            string descricaoCriticaPedido,
            EnumPosicaoPedido posicaoPedido
        )
        {
            HistoricoPedidoCapa historicoPedidoCapa = MontarHistoricoCapa(numeroPedidoErp, pedidoMaxima);
            List<HistoricoPedidoItem> historicoPedidoItem = MontarHistoricoItem(numeroPedidoErp, pedidoMaxima);
            RequestStatusPedido statusPedido = new RequestStatusPedido();
            statusPedido.CodigoPedidoNuvemMaxima = pedidoMaxima.CodigoPedidoNuvem;
            statusPedido.CodigoUsuarioMaxima = pedidoMaxima.CodigoUsuarioMaxima;
            statusPedido.NumeroPedidoRcaMaxima = pedidoMaxima.NumPedido;
            StatusPedido statusPedidoMaxima = MontarCriticaPedido(statusPedido, numeroPedidoErp.ToString(), descricaoCriticaPedido, posicaoPedido);

            var retornoCapa = await _api.Put<List<HistoricoPedidoCapa>>(
                HistoricoPedidoCapa.VersaoAPI,
                HistoricoPedidoCapa.EndPoint,
                new List<HistoricoPedidoCapa> { historicoPedidoCapa }
            );
            var retonroItens = await _api.Put<List<HistoricoPedidoItem>>(HistoricoPedidoItem.VersaoAPI, HistoricoPedidoItem.Endpoint, historicoPedidoItem);
            var retornoStatus = await _api.Put<List<StatusPedido>>(
                StatusPedido.VersaoAPI,
                StatusPedido.EndPoint,
                new List<StatusPedido> { statusPedidoMaxima },
                true
            );

            if (retornoCapa.Sucesso && retonroItens.Sucesso && retornoStatus.Sucesso)
            {
                return new RetornoApiMaxima() { Data = "Historico de pedido salvo com sucesso" };
            }
            else
            {
                return new RetornoApiMaxima() { Error = retornoCapa.Error?.ToString() + retonroItens.Error?.ToString() + retornoStatus.Error?.ToString() };
            }
        }

        internal async Task<RetornoApiMaxima> AtualizarHistoricoPedido(RequestStatusPedido statusPedido)
        {
            HistoricoPedidoCapa historicoPedidoCapa = new HistoricoPedidoCapa()
            {
                NumeroPedido = statusPedido.NumeroPedidoERP,
                PosicaoPedido = RetornarPosicaoPedidoMaxima(statusPedido.PosicaoPedidoMaxima)
            };
            StatusPedido statusPedidoMaxima = MontarCriticaPedido(
                statusPedido,
                statusPedido.NumeroPedidoERP.ToString(),
                statusPedido.CriticaPedido,
                statusPedido.PosicaoPedidoMaxima
            );
            var retornoCapa = await _api.Put<List<HistoricoPedidoCapa>>(
                HistoricoPedidoCapa.VersaoAPI,
                HistoricoPedidoCapa.EndPoint,
                new List<HistoricoPedidoCapa> { historicoPedidoCapa }
            );
            var retornoStatus = await _api.Put<List<StatusPedido>>(
                StatusPedido.VersaoAPI,
                StatusPedido.EndPoint,
                new List<StatusPedido> { statusPedidoMaxima },
                true
            );

            if (retornoCapa.Sucesso && retornoStatus.Sucesso)
            {
                return new RetornoApiMaxima() { Data = "Historico de pedido salvo com sucesso" };
            }
            else
            {
                return new RetornoApiMaxima() { Error = retornoCapa.Error?.ToString() + retornoStatus.Error?.ToString() };
            }
        }

        internal async Task<RetornoApiMaxima> AtualizarStatusPedido(RequestStatusPedido requestStatusPedido, bool isErro = false)
        {
            StatusPedido statusPedidoMaxima = MontarCriticaPedido(
                requestStatusPedido,
                null,
                requestStatusPedido.CriticaPedido,
                requestStatusPedido.PosicaoPedidoMaxima,
                isErro
            );
            var retornoStatus = await _api.Put<List<StatusPedido>>(
                StatusPedido.VersaoAPI,
                StatusPedido.EndPoint,
                new List<StatusPedido> { statusPedidoMaxima },
                true
            );
            return retornoStatus;
        }

        internal StatusPedido MontarCriticaPedido(
            RequestStatusPedido pedidoMaxima,
            string numeroPedidoErp,
            string descricaoCriticaPedido,
            EnumPosicaoPedido posicaoPedido,
            bool isErro = false
        )
        {
            long numCritica = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
            var statusPedido = new StatusPedido
            {
                Id_pedido = pedidoMaxima.CodigoPedidoNuvemMaxima,
                Data = DateTime.Now,
                Status = isErro ? 5 : 4,
                Tipopedido = 1,
                Codusuario = pedidoMaxima.CodigoUsuarioMaxima,
                Numped = pedidoMaxima.NumeroPedidoRcaMaxima,
                Numcritica = numCritica,
                Tipocritica = 0,
                Condvenda = 1,
                Numpederp = numeroPedidoErp
            };

            var critica = new Critica
            {
                NumPedido = pedidoMaxima.NumeroPedidoRcaMaxima,
                CodigoPedidoNuvem = pedidoMaxima.CodigoPedidoNuvemMaxima,
                NumPedidoERP = numeroPedidoErp,
                NumCritica = numCritica,
                CodigoUsuario = pedidoMaxima.CodigoUsuarioMaxima,
                Data = DateTime.Now,
                Tipo = isErro ? EnumTipoCritica.Erro : EnumTipoCritica.Sucesso,
                Itens = new List<Critica.DetalheCritica>()
                {
                    new Critica.DetalheCritica()
                    {
                        Codigo = "0",
                        Ordem = 0,
                        Descricao = descricaoCriticaPedido
                    }
                },

                PosicaoPedidoERP = posicaoPedido,
                CodigoTipoVenda = 1,
                ExcluirPedido = false,
                SalvarCritica = true,
                AtualizacaoPosPedido = false,
                Cancelado = false,
                HouveExcessao = false,
                PackageValida = true
            };

            statusPedido.Critica = JsonConvert.SerializeObject(critica);

            return statusPedido;
        }

        internal HistoricoPedidoCapa MontarHistoricoCapa(int idPedido, PedidoMaxima pedidoMaxima, string posicao = "P")
        {
            HistoricoPedidoCapa historicoPedidoCapa =
                new()
                {
                    NumeroPedido = idPedido,
                    Data = pedidoMaxima.Data,
                    ValorTotal = pedidoMaxima.ValorTotal,
                    ValorTabela = pedidoMaxima.ValorTabela,
                    ValorAtendido = pedidoMaxima.ValorTotal,
                    CodigoCliente = pedidoMaxima.Cliente.Codigo,
                    CodigoVendedor = pedidoMaxima.CodUsuario,
                    CodigoFilial = pedidoMaxima.FilialPedido.Codigo,
                    PosicaoPedido = posicao,
                    TipoVenda = 1,
                    IdentificadorNotaFiscal = idPedido,
                    CodigoCobranca = pedidoMaxima.Cobranca.Codigo,
                    CodigoPlanoDePagamento = pedidoMaxima.PlanoPagamento.Codigo,
                    OrigemPedido = pedidoMaxima.OrigemPedido,
                    NumeroPedidoRca = int.Parse(pedidoMaxima.NumPedido),
                };

            return historicoPedidoCapa;
        }

        internal List<HistoricoPedidoItem> MontarHistoricoItem(int idPedido, PedidoMaxima pedidoMaxima)
        {
            return pedidoMaxima
                .Produtos.Select(produto => new HistoricoPedidoItem()
                {
                    NumeroPedido = idPedido,
                    CodigoProduto = produto.Codigo,
                    SequenciaItem = produto.Sequencia,
                    Quantidade = produto.Quantidade,
                    PrecoVenda = produto.PrecoVendaInformado,
                    PrecoTabela = produto.PrecoTabelaInformado,
                })
                .ToList();
        }

        internal string RetornarPosicaoPedidoMaxima(EnumPosicaoPedido posicaoPedido)
        {
            return posicaoPedido switch
            {
                EnumPosicaoPedido.Pendente => "P",
                EnumPosicaoPedido.Liberado => "L",
                EnumPosicaoPedido.Montado => "M",
                EnumPosicaoPedido.Faturado => "F",
                EnumPosicaoPedido.Cancelado => "C",
                _ => "P"
            };
        }
    }
}

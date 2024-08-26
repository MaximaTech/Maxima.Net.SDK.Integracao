using System;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que contém um movimento de venda pendente.
    /// </summary>
    public class MovimentoVendaPendenteWMSMaxima
    {

        /// <summary>
        /// Define o número da ordem de serviço.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Numos")]
        [PropriedadePK(1)]
        public string NumeroOrdemServico { get; set; }

        /// <summary>
        /// Define o número do pedido.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de Pedidos (<see cref="HistoricoPedidoCapa"/>)
        /// </value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numped")]
        [PropriedadePK(2)]
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        public string NumeroDoPedido { get; set; }

        /// <summary>
        /// Define o número do CodigoProduto.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(3)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define o número do carregamento. O preenchimento é obrigatório.
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Numcar")]
        [PropriedadeFK(CarregamentoMaxima.VersaoAPI, CarregamentoMaxima.EndPoint, CarregamentoMaxima.Tabela, typeof(CarregamentoMaxima))]
        public string NumCarregamento { get; set; }

        /// <summary>
        /// Define a data de estorno. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtestorno")]
        public DateTime? DataEstorno { get; set; }

        /// <summary>
        /// Define o número da sequência de entrega. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Numseqentrega")]
        public long? Numseqentrega { get; set; }

        /// <summary>
        /// Define o número da sequência de montagem. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999)]
        [JsonProperty("Numseqmontagem")]
        public int? NumeroSequenciaMontagem { get; set; }

        /// <summary>
        /// Define a posição. O preenchimento é obrigatório.
        /// </summary>
        /// <value>A - Aberto, C - Concluido, P - Pendente</value>
        [RangeString(new string[] { "A", "C", "P" })]
        public string Posicao { get; set; }

        /// <summary>
        /// Define o status no movimento. O preenchimento é obrigatório.
        /// </summary>
        /// <value>0 - Pendente, 1 - Recebido pelo extrator, 2 - Erro de importação, 3 - Em processo de importação, 4 - Importação concluída</value>
        [CampoObrigatorioAoInserir]
        [RangeNumber(0, 1, 2, 3, 4)]
        public int? Status { get; set; }


        [JsonProperty("CodBox")]
        public string CodigoBoxe { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "HistoricosWMS";
        internal const string Tabela = "ERP_MXSMOVENDPEND";
    }
}

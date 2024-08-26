using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o cabeçalho da cotação .
    /// </summary>
    public class CotacaoCapaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Cotacoes";
        internal const string Tabela = "MXSCOTACAO";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da cotação, com preenchimento obrigatório e limite máximo de 50 caracteres.
        /// </summary>
        [PropriedadePK]
        [TamanhoMaximo(50)]
        [JsonProperty("Numcotacao")]
        public string CodigoCotacao { get; set; }

        /// <summary>
        /// Número do pedido vinculado a cotação, com preenchimento obrigatório e limite máximo de 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Pedidos.</value>
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        [JsonProperty("Numped")]
        public int? NumeroPedido { get; set; }

        /// <summary>
        /// Data da cotação, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public DateTime? Data { get; set; }

        /// <summary>
        /// Status da cotação A – Aberta; F - Finalizada.
        /// </summary>
        /// <value>A – Aberta; F - Finalizada</value>
        [RangeString("A", "F")]
        [JsonProperty("Status")]
        public string Status { get; set; }

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do cliente do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

    }
}

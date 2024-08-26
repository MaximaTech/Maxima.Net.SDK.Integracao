using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as metas do Vendedor.
    /// </summary>
    public class MetaVendedorMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "MetaRCA";
        internal const string Tabela = "ERP_MXSMETARCA";

        /// <summary>
        /// Código da filial com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="FilialMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do vendedor. Com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de Vendedor.</value>
        [PropriedadePK(2)]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, type: typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data da meta cadastrada. Com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(3)]
        [JsonProperty("Data")]
        public DateTime? DataMeta { get; set; }

        /// <summary>
        /// Percentual de venda prevista.
        /// </summary>
        [ValorEntre(0, 999.99)]
        [JsonProperty("Pervendaprev")]
        public double? PercentualVendaPrevista { get; set; }

        /// <summary>
        /// Valor venda prevista da meta.
        /// </summary>
        [ValorEntre(0, 999999999999.99)]
        [JsonProperty("Vlvendaprev")]
        public decimal? ValorVendaPrevista { get; set; }

        /// <summary>
        /// Valor venda realizada.
        /// </summary>
        [ValorEntre(0, 999999999999.99)]
        [JsonProperty("Vlvenda")]
        public decimal? ValorVendaRealizada { get; set; }

        /// <summary>
        /// Valor do custo real.
        /// </summary>
        [ValorEntre(0, 999999999999.99)]
        [JsonProperty("Vlcustoreal")]
        public decimal? ValorCustoReal { get; set; }

        /// <summary>
        /// Valor do custo financeiro.
        /// </summary>
        [ValorEntre(0, 999999999999.99)]
        [JsonProperty("Vlcustofin")]
        public decimal? ValorCustoFinanceiro { get; set; }

        /// <summary>
        /// Valor da tabela do pedido.
        /// </summary>
        [ValorEntre(0, 999999999999.99)]
        [JsonProperty("Vltabela")]
        public decimal? ValorTabela { get; set; }

        /// <summary>
        /// Quantidade de itens previstos.
        /// </summary>
        [ValorEntre(0, 999999)]
        [JsonProperty("Qtitenspedprev")]
        public int? QuantidadeItensPrevisto { get; set; }

        /// <summary>
        /// Quantidade de pedidos previstos.
        /// </summary>
        [ValorEntre(0, 999999)]
        [JsonProperty("Qtpedprev")]
        public int? QuantidadePedidoPrevisto { get; set; }

        /// <summary>
        /// Distância prevista.
        /// </summary>
        [JsonProperty("qtmetroprev")]
        public decimal? DistanciaPrevista { get; set; }

        /// <summary>
        /// Número de clientes positivados.
        /// </summary>
        [JsonProperty("Numclipos")]
        public decimal? NumeroClientePositivado { get; set; }

    }
}

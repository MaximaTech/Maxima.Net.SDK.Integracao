using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os pedidos processados pelo WMS
    /// </summary>
    public class PedidosProcessadosWMSMaxima
    {
        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "GeracaoWMS";
        internal const string Tabela = "ERP_MXSWMS";

        /// <summary>
        /// Número do carragamento, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Numcar")]
        [PropriedadeFK(CarregamentoMaxima.VersaoAPI, CarregamentoMaxima.EndPoint, CarregamentoMaxima.Tabela, typeof(CarregamentoMaxima))]
        public string NumCarregamento { get; set; }

        /// <summary>
        /// Número do pedido, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Numped")]
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        public string NumeroDoPedido { get; set; }

        /// <summary>
        /// Mapa gerado, com preenchimento obrigatório  e limite de 1 caracter
        /// </summary>
        /// <value>NULL (Não foi gerado mapa ainda), S (Sim, foi Impresso), R (Reimpresso)</value>
        [RangeString(new string[] { "S", "R" })]
        [JsonProperty("Mapagerado")]
        public string MapaGerado { get; set; }
    }
}

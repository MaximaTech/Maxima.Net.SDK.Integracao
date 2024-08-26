using System.ComponentModel.DataAnnotations;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que contém os XML de NF de Saída dos pedidos realizados.
    /// Base para geração de impressão das Nfe na impressora.
    /// </summary>
    public class NotaFiscalEletronicaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Doceletronico";
        internal const string Tabela = "ERP_MXSDOCELETRONICO";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Numero da transação, sequencial único, que não se repete e que seja um
        /// identificador do cabeçalho da nota (Sequence, ROWID, ID e etc).
        /// O número máximo de caracteres permitidos é 50.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Numtransacao")]
        public string NumeroDaTransacao { get; set; }

        /// <summary>
        /// XML da nota fiscal. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Xmlnfe")]
        public string XmlNfe { get; set; }

        /// <summary>
        /// Número do pedido do ERP. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de Pedidos (<see cref="HistoricoPedidoCapa"/>)
        /// </value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(HistoricoPedidoCapa.VersaoAPI, HistoricoPedidoCapa.EndPoint, HistoricoPedidoCapa.Tabela, typeof(HistoricoPedidoCapa))]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int? NumeroDoPedido { get; set; }
    }
}

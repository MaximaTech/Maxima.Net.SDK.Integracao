using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a tabela de preço da cesta.
    /// </summary>
    public class TabelaPrecoCestaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TabelasPrecosCestas";
        internal const string Tabela = "MXSTABPRCESTA";

        /// <summary>
        /// Define o número da região, O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadePK(1)]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        [PropriedadePK(2)]
        public string Codprod { get; set; }

        /// <summary>
        /// Define o código do filial, O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no cadastro de Filial.</value>    
        [JsonProperty("Codfilial")]
        [PropriedadePK(3)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        public string Codfilial { get; set; }

        ///<summary>
        ///Preço de venda do produto sem impostos.
        ///</summary>
        [JsonProperty("Pvenda")]
        public double? PrecoVendaSemImpostos { get; set; }

        ///<summary>
        ///Preço de venda do produto bruto(c/todos os impostos) para a Região/praça de atendimento <br/>
        ///</summary>
        [JsonProperty("Pvenda1")]
        public double? PrecoVendaComImpostos { get; set; }

        /// <summary>
        /// Define o preço mínimo para venda do produto na região.
        /// </summary>
        [JsonProperty("Precominimovenda")]
        public double? PrecoMinimoVenda { get; set; }

        /// <summary>
        /// Percentual de desconto por Tipo de Frete FOB.
        /// </summary>
        /// <value></value>
        [JsonProperty("Perdescfob")]
        public double? PercentualDescontoFreteFOB { get; set; }

        /// <summary>
        /// Destinado ao valor de Substituição Tributária, caso seja aplicado.
        /// </summary>
        /// <value></value>
        [JsonProperty("Vlst")]
        public double? ValorST { get; set; }

        /// <summary>
        /// Define o maior desconto permitido para o produto.
        /// </summary>
        /// <value></value>
        [JsonProperty("Perdescmax")]
        public double? PercentualDescontoMaximo { get; set; }

        /// <summary>
        /// Quantidade do produto.
        /// </summary>
        /// <value></value>
        [JsonProperty("Qt_prod_cesta")]
        public long? QuantidadeProdutoCesta { get; set; }

        /// <summary>
        /// Código da Tributação aplicada ao produto.
        /// </summary>
        /// <value></value>
        [JsonProperty("Codst")]
        public string CodigoTributacaoProduto { get; set; }

        /// <summary>
        /// Indica se o frete será descontado.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Descontafrete")]
        public string DescontaFrete { get; set; }

    }
}

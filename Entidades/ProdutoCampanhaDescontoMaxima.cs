using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os itens relacionados a campanha que poderão ter desconto após a venda do combo inicial. 
    /// </summary>
    public class ProdutoCampanhaDescontoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "DescontosCapasProdRelac";
        internal const string Tabela = "MXSDESCONTOCPRODRELAC";

        /// <summary>
        /// Código de identificação do combo, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Codigocampanha")]
        public string CodigoCampanha { get; set; }

        /// <summary>
        /// Define o código do produto, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produto.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define o código do grupo das campanhas, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(3)]
        [JsonProperty("Codigogrupocombo")]
        public string CodigoGrupoCampanha { get; set; }

        /// <summary>
        /// Percentual de desconto do item adquirido no combo, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999999999.999999)]
        [JsonProperty("Perdesc")]
        public double? PercentualDesconto { get; set; }

        /// <summary>
        /// Código de barras (Obrigatório no caso de venda por embalagem), com limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarras { get; set; }
    }
}

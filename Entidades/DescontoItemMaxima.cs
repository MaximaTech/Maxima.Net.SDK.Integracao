using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar os itens que compõem o combo de desconto (Itens da campanha de combo).
    /// </summary>
    public class DescontoItemMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "DescontosItens";
        internal const string Tabela = "MXSDESCONTOI";

        /// <summary>
        /// Código do item de desconto, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(1)]
        [PropriedadeFK(DescontoCapaMaxima.VersaoAPI, DescontoCapaMaxima.EndPoint, DescontoCapaMaxima.Tabela, typeof(DescontoCapaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Sequência de inclusão, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [PropriedadePK(2)]
        [JsonProperty("Sequencia")]
        public long? NumeroSequencial { get; set; }

        /// <summary>
        /// Código do produto do desconto com preenchimento obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Quantidade mínima de itens no combo com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Qtminima")]
        public double? QuantidadeMinima { get; set; }

        /// <summary>
        /// Percentual de desconto do item adquirido no combo com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Perdesc")]
        public double? PercentualDesconto { get; set; }

        /// <summary>
        /// Quantidade máxima de itens no combo.
        /// </summary>
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Qtmaxima")]
        public double? QuantidadeMaxima { get; set; }

        /// <summary>
        /// Tipo de desconto com preenchimento obrigatório.
        /// </summary>
        /// <value>A – automático F – flexível</value>
        [RangeString("A", "F")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Tipodesconto")]
        public string TipoDeDesconto { get; set; }

        /// <summary>
        /// Código de barras da embalagem com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarrasEmbalagem { get; set; }
    }
}

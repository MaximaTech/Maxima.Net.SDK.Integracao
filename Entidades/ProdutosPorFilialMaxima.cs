using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os produtos por filial, podendo haver parametrizações distintas para as quantidades de filiais da empresa.
    /// </summary>
    public class ProdutosPorFilialMaxima
    {

        ///<summary>
        /// Código do produto, com preenchimento é obrigatório e com limite de até 50 caracteres.
        ///</summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [PropriedadePK(1)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código da filial do produto. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>
        /// Código usado deve estar no Cadastro de Filiais.
        /// </value>
        [TamanhoMaximo(4000)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        [PropriedadePK(2)]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// [Propriedade interna] Indica se deve ou não enviar para o Força de Vendas.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Enviarforcavendas")]
        internal string EnviarForcaVendas { get; set; }

        ///<summary>
        ///Indica qual é o múltiplo do produto, não poderá realizar operações se a quantidade não for múltipla ao informado nesse campo.
        ///</summary>
        [CampoObrigatorioAoInserir]
        public int? Multiplo { get; set; }

        /// <summary>
        /// Identifica se o produto é proibido para venda
        /// </summary>
        /// <value>
        /// NULL - Permite a venda / PV - Proibir a venda
        /// </value>
        [RangeString("PV", null)]
        [JsonProperty("Proibidavenda")]
        public string ProibidaVenda { get; set; }

        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ProdutosFiliais";
        internal const string Tabela = "MXSPRODFILIAL";

    }
}

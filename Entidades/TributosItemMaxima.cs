using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os cenários tributários utilizados na venda
    /// </summary>
    public class TributosItemMaxima
    {

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TabelasTributacoesERP";
        internal const string Tabela = "MXSTABTRIB";

        ///// <summary>
        ///// Hash para controle de integração, usado para excluir uma entidade.
        ///// </summary>
        //[TamanhoMaximo(128)]
        //public string Hash { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [PropriedadePK(1)]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código da filial de emissão da nota fiscal. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilialnf")]
        [PropriedadePK(2)]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Estado de entrega da mercadoria – UF do cliente. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Estados.</value>
        [TamanhoMaximo(2)]
        [PropriedadeFK(EstadoMaxima.VersaoAPI, EstadoMaxima.EndPoint, EstadoMaxima.Tabela, typeof(EstadoMaxima))]
        [JsonProperty("Ufdestino")]
        [PropriedadePK(3)]
        public string UfCliente { get; set; }

        /// <summary>
        /// Código do tipo de operação. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>1 – Venda Normal, 5 – Venda bonificada, 13 – Venda Manifesto, 14 – Pronta Entrega). Se Não usar, fixar 0.</value>
        [RangeNumber(0, 1, 5, 13, 14)]
        [JsonProperty("Codoper")]
        [PropriedadePK(4)]
        public int? CodigoOperacao { get; set; }

        /// <summary>
        /// Código do cliente do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        [PropriedadePK(5)]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do tributação. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Tributos.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(TributosCapaMaxima.VersaoAPI, TributosCapaMaxima.EndPoint, TributosCapaMaxima.Tabela, typeof(TributosCapaMaxima))]
        [JsonProperty("Codst")]
        public string CodigoTributacao { get; set; }
    }
}

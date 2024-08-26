using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as tabelas de preços por região.
    /// </summary>
    public class TabelaPrecoMaxima
    {
        /// <summary>
        /// Código da região para vincular ao produto na tabela de preço. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de Região
        /// </value>
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [PropriedadePK(2)]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Código do produto para vincular à tabela de preço. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de Produto
        /// </value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [PropriedadePK(1)]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        ///<summary>
        ///Preço de venda do produto sem impostos. O preenchimento é obrigatório.
        ///</summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Pvenda")]
        public decimal? PrecoVendaSemImpostos { get; set; }

        ///<summary>
        ///Preço de venda do produto bruto(c/todos os impostos) para a Região/praça de atendimento <br/>
        ///O preenchimento é obrigatório.
        ///</summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Pvenda1")]
        public decimal? PrecoVendaComImpostos { get; set; }

        ///<summary>
        ///Define o maior desconto permitido para o produto. O preenchimento é obrigatório.
        ///</summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 99999999.99)]
        [JsonProperty("Perdescmax")]
        public decimal? PercDescontoMaximo { get; set; }

        /// <summary>
        /// Preço tabela com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Ptabela")]
        public decimal? PrecoTabela { get; set; }

        [JsonProperty("Dtultaltpvenda")]
        public DateTime? DataUltimaAlteracaoPrecoVenda { get; set; }

        /// <summary>
        /// Código da tributação do produto. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro de Tributos.
        /// </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(TributosCapaMaxima.VersaoAPI, TributosCapaMaxima.EndPoint, TributosCapaMaxima.Tabela, typeof(TributosCapaMaxima))]
        [JsonProperty("Codst")]
        public string CodigoTributacaoProduto { get; set; }

        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TabelasPrecos";
        internal const string Tabela = "MXSTABPR";
    }
}

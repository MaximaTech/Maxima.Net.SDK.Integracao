using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os itens da cotação.
    /// </summary>
    public class CotacaoItensMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "CotacoesItens";
        internal const string Tabela = "MXSCOTACAOITENS";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da cotação, com preenchimento obrigatório e limite máximo de 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Capa de Cotação.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(CotacaoCapaMaxima.VersaoAPI, CotacaoCapaMaxima.EndPoint, CotacaoCapaMaxima.Tabela, typeof(CotacaoCapaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Numcotacao")]
        public string CodigoCotacao { get; set; }

        /// <summary>
        /// Código do produto da cotação. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        [PropriedadePK(2)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Sequência de inclusão, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [PropriedadePK(3)]
        [JsonProperty("Sequencia")]
        public double? NumeroSequencial { get; set; }

        /// <summary>
        /// Código do concorrente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Concorrente.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ConcorrenteMaxima.VersaoAPI, ConcorrenteMaxima.EndPoint, ConcorrenteMaxima.Tabela, typeof(ConcorrenteMaxima))]
        [JsonProperty("Codconc")]
        public string CodigoConcorrente { get; set; }

        /// <summary>
        /// Preço da cotação, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Preco")]
        public decimal? PrecoCotacao { get; set; }

        /// <summary>
        /// Preço unitário da embalagem – opcional em caso de venda por embalagem.
        /// </summary>
        [JsonProperty("PrecoUnitario")]
        public decimal? PrecoUnitarioEmbalagem { get; set; }

        /// <summary>
        /// Preço de tabela.
        /// </summary>
        [JsonProperty("PrecoTabela")]
        public decimal? PrecoDeTabela { get; set; }

        /// <summary>
        /// Código de barras da embalagem, com limite de até 50 caracteres. <br/>
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("CodigoBarras")]
        public string CodigoBarras { get; set; }

        /// <summary>
        /// Observação da cotação. <br/>
        /// </summary>
        [JsonProperty("Observacao")]
        public string Observacao { get; set; }
    }
}

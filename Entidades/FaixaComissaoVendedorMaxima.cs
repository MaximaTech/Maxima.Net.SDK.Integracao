using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar as faixas de comissão variáveis por vendedor
    /// </summary>
    public class FaixaComissaoVendedorMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "FaixaComissaoVendedor";
        internal const string Tabela = "MXSFAIXACOMISSAOUSUR";

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código da região com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RegiaoMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Código do vendedor do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima), true)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data início de vigência, com o preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtinicio")]
        public DateTime? DataInicial { get; set; }

        /// <summary>
        /// Data final de vigência, com o preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtfim")]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Faixa inicial da comissão com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Faixa_ini_comissao")]
        public decimal? FaixaInicial { get; set; }

        /// <summary>
        /// Faixa final da comissão com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Faixa_fim_comissao")]
        public decimal? FaixaFinal { get; set; }

        /// <summary>
        /// Comissão padrão do vendedor com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Comissao_padrao")]
        public decimal? ComissaoPadrao { get; set; }
    }
}

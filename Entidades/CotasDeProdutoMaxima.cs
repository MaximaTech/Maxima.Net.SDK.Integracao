using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a quantidade de cotas de produtos.
    /// Muito utilizado em cenários de promoção, podendo criar cadastro de cota por vendedor\produto ou cota de cliente\produto.
    /// </summary>
    public class CotasDeProdutoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ProdutosUsuarios";
        internal const string Tabela = "MXSPRODUSUR";

        /// <summary>
        /// Código identificador do cadastro.
        /// </summary>
        [PropriedadePK]
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Codigo")]
        public long IdentificadorCotaProduto { get; set; }

        /// <summary>
        /// Código do cliente do pedido. Caso seja por cliente este campo é obrigatório. Limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve exisitir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código do vendedor do pedido. Caso seja por vendedor este campo é obrigatório. Limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Define a data inicial da vigência, com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Datainicio")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Define a data final da vigência, com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Datafim")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Quantidade máxima de venda, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtmaxvenda")]
        public decimal? QuantidadeMaximaVenda { get; set; }

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o mix vendido pelo vendedor a determinado cliente. Existe uma tela específica no MaxPedido onde esses itens são visualizados.
    /// </summary>
    public class MixProdutoClienteMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "MixClientes";
        internal const string Tabela = "MXSMIXCLIENTES";

        /// <summary>
        /// Código que define o plano de pagamento do mix vendido, com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, type: typeof(PlanoPagamentoMaxima))]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Quantidade, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qt")]
        public decimal? Quantidade { get; set; }

        /// <summary>
        /// Código do produto do mix vendido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        [PropriedadePK(1)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Preço de tabela, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Ptabela")]
        public decimal? PrecoTabela { get; set; }

        /// <summary>
        /// Código do cliente do mix vendido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código da filial do mix vendido. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código de barras da embalagem (Obrigatório no caso de venda por embalagem), com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(4)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarrasEmbalagem { get; set; }

        /// <summary>
        /// Define o número da transação de vendas, com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="NotaSaidaCapaMaxima"/>.</value>
        [PropriedadePK(5)]
        [PropriedadeFK(NotaSaidaCapaMaxima.VersaoAPI, NotaSaidaCapaMaxima.EndPoint, NotaSaidaCapaMaxima.Tabela, typeof(NotaSaidaCapaMaxima))]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numtransvenda")]
        public int? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Define para qual cobrança o mix pedido foi feito. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de cobranças.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Define o preço unitário do item, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Punit")]
        public decimal? PrecoUnitario { get; set; }

        /// <summary>
        /// Data de Saída do mix vendido, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtsaida")]
        public DateTime? DataSaida { get; set; }

    }
}

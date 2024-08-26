using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os itens da nota fiscal de saída
    /// </summary>
    public class NotaSaidaItensMaxima
    {
        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "NotasSaidaItens";
        internal const string Tabela = "ERP_MXSMOV";

        /// <summary>
        /// Define o número do item da transação.
        /// </summary>
        /// <value>Sequencial único, que não se repete e que seja um  identificador dos itens de notas(Sequence, ROWID, ID e etc)</value>
        [PropriedadePK]
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("numtransitem")]
        public long NumeroTransacaoItem { get; set; }

        /// <summary>
        /// Define o número do pedido do ERP.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numped")]
        public int NumeroPedido { get; set; }

        /// <summary>
        /// Define o número da nota fiscal.
        /// </summary>
        /// <value></value>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numnota")]
        public int NumeroNota { get; set; }

        /// <summary>
        /// Define o número do carregamento, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [PropriedadeFK(CarregamentoMaxima.VersaoAPI, CarregamentoMaxima.EndPoint, CarregamentoMaxima.Tabela, typeof(CarregamentoMaxima))]
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Numcar")]
        public string NumeroCarregamento { get; set; }

        /// <summary>
        /// Define o número da sequencia do item da nota fiscal.
        /// </summary>
        /// <value></value>
        [JsonProperty("Numseq")]
        public decimal NumeroSequencia { get; set; }

        /// <summary>
        /// Define a operação da nota S-Saída ou ED-Entrada/Devolução, com preenchimento obrigatório e limite de até 1 caractere.
        /// </summary>
        /// <value>S - Saída</value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "ED" })]
        [JsonProperty("Codoper")]
        public string Operacao { get; set; }

        ///<summary>
        /// Código do produto, com preenchimento é obrigatório e com limite de até 50 caracteres.
        ///</summary>
        ///<value>CodigoProduto referente ao Cadastro de Produto </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define o número da transação da venda.
        /// </summary>
        /// <value>
        /// Sequencial único, que não se repete e que seja um identificador do cabeçalho do pedido que originou esta (Sequence, ROWID, ID e etc).
        /// </value>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("numtransvenda")]
        public int? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Código de barras do produto, obrigatório no caso de venda por embalagem e com limite de até 50 caracteres.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarras { get; set; }

        /// <summary>
        /// Define a quantidade do item
        /// </summary>
        /// <value></value>
        [JsonProperty("Qt")]
        public decimal Quantidade { get; set; }

        /// <summary>
        /// Define o valor do IPI
        /// </summary>
        /// <value></value>
        [JsonProperty("Vlipi")]
        public decimal Ipi { get; set; }

        /// <summary>
        /// Define o valor do custo financeiro
        /// </summary>
        /// <value></value>
        [JsonProperty("Custofin")]
        public decimal CustoFinanceiro { get; set; }

        /// <summary>
        /// Define o código do vendedor
        /// </summary>
        /// <value></value>
        [JsonProperty("Codusur")]
        public string CodigoUsuario { get; set; }

        /// <summary>
        /// Define a quantidade do item que foi devolvida
        /// </summary>
        /// <value></value>
        [JsonProperty("Qtdevol")]
        public decimal QuantidadeDevolvida { get; set; }

        /// <summary>
        /// Define o código da filial
        /// </summary>
        /// <value></value>
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define a quantidade do item
        /// </summary>
        /// <value> Replicar a informação do campo QT. </value>
        [JsonProperty("Qtcont")]
        public decimal QuantidadeCont { get; set; }

        /// <summary>
        /// Define o preço unitário do item
        /// </summary>
        /// <value> Replicar a informação do campo PUNITCONT </value>
        [JsonProperty("Punit")]
        public decimal PrecoUnitario { get; set; }

        /// <summary>
        /// Define o preço unitário do item
        /// </summary>
        /// <value></value>
        [JsonProperty("Punitcont")]
        public decimal PrecoUnitarioCont { get; set; }

        /// <summary>
        /// Define o preço de tabela do item
        /// </summary>
        /// <value></value>
        [JsonProperty("Ptabela")]
        public decimal PrecoDeTabela { get; set; }

        ///<summary>
        /// Código do cliente.
        ///</summary>
        ///<value> CodigoCliente referente ao Cadastro de Clientes </value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Sequencial único, que não se repete e que seja um identificador da nota de devolução (Sequence, ROWID,ID e etc).
        /// </summary>
        /// <value></value>
        [JsonProperty("Numtransent")]
        public string NumTransent { get; set; }
    }
}

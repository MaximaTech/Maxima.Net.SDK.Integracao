using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os combos de desconto (Cabeçalho da campanha).
    /// </summary>
    public class DescontoCapaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "DescontosCapas";
        internal const string Tabela = "MXSDESCONTOC";

        /// <summary>
        /// Código de identificação do combo, campo é obrigatório com limite de até 50 caracteres.
        /// </summary>
        [JsonProperty("Codigo")]
        [PropriedadePK]
        [TamanhoMaximo(50)]
        public string CodigoCombo { get; set; }

        /// <summary>
        /// Nome da camapnha/combo, campo é obrigatório.
        /// </summary>
        [JsonProperty("Descricao")]
        [CampoObrigatorioAoInserir]
        public string Descricao { get; set; }

        /// <summary>
        /// Data início da vigência do combo, campo é obrigatório.
        /// </summary>
        [JsonProperty("Dtinicio")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Data final da vigência do combo, campo é obrigatório.
        /// </summary>
        [JsonProperty("Dtfim")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataFim { get; set; }

        /// <summary>
        /// Patrocinador da campanha (Ex: Empresa).
        /// </summary>
        [JsonProperty("Tipopatrocinio")]
        public string TipoPatrocinio { get; set; }

        /// <summary>
        /// Tipo da campanha (MQT – Mix quantidade mínima; MIQ – Mix intervalo de quantidade; SQP – Sub-Categoria, Quantidade Pedido, FPU - Faixas Pedido Unificada)
        /// </summary>
        /// <value>MQT,MIQ , SQP, FPU</value>
        [RangeString("MQT", "MIQ", "SQP", "FPU")]
        [JsonProperty("Tipocampanha")]
        public string TipoCampanha { get; set; }

        /// <summary>
        /// Tipo de desconto. P – Percentual de desconto / Se tipo campanha for FPU, F – Flexível ou A – Automático.
        /// </summary>
        /// <value>P, F, A</value>
        [RangeString("P", "F", "A")]
        [JsonProperty("Tipodesconto")]
        public string TipoDesconto { get; set; }

        /// <summary>
        /// Tipo de validação.
        /// </summary>
        /// <value>P - Peso, D - Dosagem, V - Valor</value>
        [JsonProperty("Tipovalidacao")]
        public string TipoValidacao { get; set; }

        /// <summary>
        /// Indica se o combo irá validar família de produtos.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Utilizacodprodprinc")]
        public string UtilizaFamiliaProdutos { get; set; }

        /// <summary>
        /// Indica se o combo irá validar rede de clientes.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Utilizacodcliprinc")]
        public string UtilizaRedeCliente { get; set; }

        /// <summary>
        /// Descrição da mecânica/”o como” do combo.
        /// </summary>
        [JsonProperty("Metodologia")]
        public string Metodologia { get; set; }

        /// <summary>
        /// Indica se existe proporcionalidade de desconto.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Proporcional")]
        public string Proporcional { get; set; }

        /// <summary>
        /// Código da filial do pedido, com limite de até 20 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [JsonProperty("Codfilial")]
        [TamanhoMaximo(20)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Utilizado para campanhas 'P&amp;G' com o conceito de combos acumulativos.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Combocontinuo")]
        public string UtilizaComboConituo { get; set; }

        /// <summary>
        /// Indica que não incide débito na conta corrente do vendedor.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Naodebitccrca")]
        public string NaoDebitaContaCorrenteVendedor { get; set; }

        /// <summary>
        /// Creditar a conta corrente do vendedor.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Creditapolitica")]
        public string CreditaContaCorrenteVendedor { get; set; }

        /// <summary>
        /// Limitar a quantidade de combos por cliente.
        /// </summary>
        [JsonProperty("Qtdecombocliente")]
        [RangeNumber(0, int.MaxValue)]
        public int? QuantidadeMaximaComboCliente { get; set; }

        /// <summary>
        /// Limitar a quantidade de combos por vendedor.
        /// </summary>
        [JsonProperty("Qtdecombousur")]
        [RangeNumber(0, int.MaxValue)]
        public int? QuantidadeMaximaComboVendedor { get; set; }

        /// <summary>
        /// Habilita se valida o peso do produto.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Validapeso")]
        public string ValidaPesoProduto { get; set; }

    }
}

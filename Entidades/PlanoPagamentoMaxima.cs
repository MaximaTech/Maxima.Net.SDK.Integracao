using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os planos de pagamentos, usado para as condições comerciais
    /// </summary>
    public class PlanoPagamentoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PlanosPagamentos";
        internal const string Tabela = "MXSPLPAG";

        /// <summary>
        /// Hash para controle de integração.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do Plano de pagamento com preenchimento obrigatório e limite de 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadePK]
        public string CodigoPlanoPagamento { get; set; }

        /// <summary>
        /// Prazo médio com preenchimento obrigatório e valor entre 0 e 9999.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999)]
        [JsonProperty("Numdias")]
        public int? PrazoMedio { get; set; }

        /// <summary>
        /// Valor mínimo do pedido com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999999999.99)]
        [JsonProperty("Vlminpedido")]
        public double? ValorMinimoPedido { get; set; }

        /// <summary>
        /// Referencia aos campos PrecoVenda, PrecoVenda1 ... da tabela de preço, default e 1.
        /// O preenchimento é obrigatório.
        ///</summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Numpr")]
        public double? NumColunaTabelaPreco { get; set; }

        /// <summary>
        ///Qauntidade de parcelas que o plano de pagamento aceita.
        ///</summary>
        [JsonProperty("Numparcelas")]
        [ValorEntre(0, 99999)]
        public int? QuantidadeParcelas { get; set; }

        /// <summary>
        /// Descrição do plano de pagamento com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Descricao { get; set; }

        /// <summary>
        /// Define qual o tipo do prazo do plano. <br/>
        /// O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (N) para normal, (B) para bonificado
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "N", "B" })]
        [JsonProperty("Tipoprazo")]
        public string TipoPrazo { get; set; }

        /// <summary>
        /// Define se o plano aceita venda com boleto. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Sim, (N) Não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Vendabk")]
        public string AceitaVendaBoleto { get; set; }

        /// <summary>
        /// Acréscimo para a tabela de preço.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Pertxfim")]
        public double AcrescimoTabelaDePreco { get; set; }

        /// <summary>
        /// Prazo para a primeira parcela em Dias
        /// </summary>
        [ValorEntre(0, 9999)]
        [JsonProperty("Prazo1")]
        public int PrazoPrimeiraParcela { get; set; }

        /// <summary>
        /// Tipo de entrada do pagamento.
        /// </summary>
        /// <value>
        /// 3 – Aceita entrada na condição de pagamento.
        /// 10 – (Recebimento) Se Pronta Entrega e utiliza prestação de conta.
        /// </value>
        [RangeNumber(3, 10)]
        [JsonProperty("Tipoentrada")]
        public int? TipoDeEntrada { get; set; }

        /// <summary>
        /// Tipo de venda realizada.
        /// </summary>
        /// <value>
        /// Informar VP- Venda a prazo, VV – Venda a vista
        /// </value>
        [RangeString("VP", "VV")]
        [JsonProperty("Tipovenda")]
        public string TipoDeVenda { get; set; }

        /// <summary>
        /// Usa o plano em multi-filiais (S ou N) – Caso S, irá verificar no endPoint PlanosPagamentosClientes
        /// se tem permissão na filial. Caso N, irá considerar o plano para todas as filiais da empresa.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Usamultifilial")]
        public string UsarPlanoMultiFiliais { get; set; }
    }
}

using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar os itens referentes ao controle de caixa
    /// que é responsável pela totalização e controle do saldo na prestação de contas.
    /// </summary>
    public class PrestacaoContaItemMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrestacaoContasItens";
        internal const string Tabela = "MXSPRESTACAOCONTASI";

        /// <summary>
        /// Código do item da prestação de contas, com preenchimento obrigatório e limite de até 40 caracteres
        /// </summary>
        [PropriedadePK]
        [TamanhoMaximo(40)]
        [JsonProperty("Codprestacaocontai")]
        public string CodigoPrestacaoContaItem { get; set; }

        /// <summary>
        /// Código da categoria de despesa com preenchimento obrigatório.
        /// </summary>
        /// <value>O valor deve estar presente no cadastro de <see cref="CategoriaDespesaMaxima"/></value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(CategoriaDespesaMaxima.VersaoAPI, CategoriaDespesaMaxima.EndPoint, CategoriaDespesaMaxima.Tabela, typeof(CategoriaDespesaMaxima))]
        [ValorEntre(0, 9999999999)]
        [JsonProperty("CodCategoriaDespesa")]
        public long? CodigoCategoriaDespesa { get; set; }

        /// <summary>
        /// Código da prestação de contas, com preenchimento obrigatório e limite de até 40 caracteres
        /// </summary>
        /// <value>O valor deve estar presente no cadastro de <see cref="PrestacaoContaCapaMaxima"/></value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(PrestacaoContaCapaMaxima.VersaoAPI, PrestacaoContaCapaMaxima.EndPoint, PrestacaoContaCapaMaxima.Tabela, typeof(PrestacaoContaCapaMaxima))]
        [TamanhoMaximo(40)]
        [JsonProperty("Codprestacaocontac")]
        public string CodigoPrestacaoContaCapa { get; set; }

        /// <summary>
        /// Data do lançamento com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datalancamento")]
        public DateTime? DataLancamento { get; set; }

        /// <summary>
        /// Tipo de lançamento com preenchimento obrigatório.
        /// </summary>
        /// <value>Valores: 1 – Despesa, 2 – Recebimento, 3 – Deposito e 4 – Ajuste e 5 – Malote</value>
        [CampoObrigatorioAoInserir]
        [RangeNumber(1, 2, 3, 4, 5)]
        public int? Tipo { get; set; }

        /// <summary>
        /// Código da conta bancária com limite de até 50 caracteres.
        /// </summary>
        /// <value>O valor deve estar presente no cadastro de <see cref="ContaBancariaMaxima"/></value>
        [PropriedadeFK(ContaBancariaMaxima.VersaoAPI, ContaBancariaMaxima.EndPoint, ContaBancariaMaxima.Tabela, typeof(ContaBancariaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codconta")]
        public string CodigoContaBancaria { get; set; }

        /// <summary>
        /// Forma de pagamento com preenchimento obrigatório.
        /// </summary>
        /// <value>Valores: 1 – Dinheiro, 2 – Cheque ou 3 – Cartão</value>
        [RangeString("1", "2", "3")]
        [CampoObrigatorioAoInserir]
        public string FormaPagamento { get; set; }

        /// <summary>
        /// Observação da prestação de conta.
        /// </summary>
        public string Observacao { get; set; }

        /// <summary>
        /// Número de transação da venda, indentificador unico, pode ser o mesmo número do pedido caso não tenha essa numeração.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="NotaSaidaCapaMaxima"/>.</value>
        [PropriedadeFK(NotaSaidaCapaMaxima.VersaoAPI, NotaSaidaCapaMaxima.EndPoint, NotaSaidaCapaMaxima.Tabela, typeof(NotaSaidaCapaMaxima))]
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Numtransvenda")]
        public long? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Duplicata da prestação de conta.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Duplic")]
        public long? Duplicata { get; set; }

        /// <summary>
        /// Prestação do Título Recebido com limite de até 100 caracteres.
        /// </summary>
        [TamanhoMaximo(100)]
        [JsonProperty("Prest")]
        public string PrestacaoTitulo { get; set; }

        /// <summary>
        /// Valor da despesa com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public decimal? Valor { get; set; }

        /// <summary>
        /// Valor do desconto.
        /// </summary>
        [JsonProperty("Vldesconto")]
        public decimal? ValorDesconto { get; set; }

        /// <summary>
        /// Valor dos juros.
        /// </summary>
        [JsonProperty("Vljuros")]
        public decimal? ValorJuros { get; set; }

        /// <summary>
        /// Número do pedido do vendedor (controle interno).
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numpedrca")]
        public int? NumeroPedidoRca { get; set; }

        /// <summary>
        /// Identificador Único do Título no ERP com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Id_erp")]
        public string IdentificadorERP { get; set; }
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o controle de caixa, responsável pela totalização e controle do saldo na prestação de contas.
    /// </summary>
    public class PrestacaoContaCapaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrestacaoContasCapas";
        internal const string Tabela = "MXSPRESTACAOCONTASC";

        /// <summary>
        /// Código da prestação de contas, com preenchimento obrigatório e limite de até 40 caracteres
        /// </summary>
        [TamanhoMaximo(40)]
        [PropriedadePK]
        [JsonProperty("Codprestacaocontac")]
        public string CodigoPrestacaoConta { get; set; }

        /// <summary>
        /// Status da Prestação de contas, com preenchimento obrigatório.
        /// </summary>
        /// <value> 1 – Aberto e 2 – Fechado </value>
        [RangeNumber(1, 2)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Status")]
        public int? Status { get; set; }

        /// <summary>
        /// Número do carregamento, com preenchimento obriatório e limite de até 50 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Numcarmanif")]
        public string NumeroCarregamento { get; set; }

        /// <summary>
        /// Código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data de abertura da prestação de contas, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dataabertura")]
        public DateTime? DataAbertura { get; set; }

        /// <summary>
        /// Data de fechamento da prestação de contas, com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Datafechamento")]
        public DateTime? DataFechamento { get; set; }

        /// <summary>
        /// Número do lacre do malote.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Numlacre")]
        public string NumeroLacreMalote { get; set; }

        /// <summary>
        /// Observação da Prestação de Contas. *
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Observacao")]
        public string Observacao { get; set; }

        /// <summary>
        /// Valor total da prestação de contas.
        /// </summary>
        [JsonProperty("Total")]
        public decimal? ValorTotal { get; set; }

        /// <summary>
        /// Valor total de despesas da prestação de contas.
        /// </summary>
        [JsonProperty("Totaldespesas")]
        public decimal? ValorTotalDespesas { get; set; }

        /// <summary>
        /// Valor total de recebimentos da prestação de contas.
        /// </summary>
        [JsonProperty("Totalrecebimentos")]
        public decimal? ValorTotalRecebimentos { get; set; }

        /// <summary>
        /// Valor total de depositos da prestação de contas.
        /// </summary>
        [JsonProperty("Totaldepositos")]
        public decimal? ValorTotalDepositos { get; set; }
    }
}

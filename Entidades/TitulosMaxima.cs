using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os títulos
    /// </summary>
    public class TitulosMaxima
    {
        ///<summary>
        ///Número da prestação em caso de parcelamento. O preenchimento é obrigatório e o limite de até 4 caracteres.
        ///</summary>
        [TamanhoMaximo(4)]
        [JsonProperty("Prest")]
        [PropriedadePK(2)]
        public string NumeroPrestacao { get; set; }

        /// <summary>
        /// Define o número da transação das vendas, com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(1)]
        [ValorEntre(0, long.MaxValue)]
        [JsonProperty("Numtransvenda")]
        public long? IdentificadorNotaFiscal { get; set; }

        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Duplic")]
        public long NumeroDuplicata { get; set; }

        /// <summary>
        /// Data de emissão com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtemissao")]
        public DateTime? DataEmissao { get; set; }

        /// <summary>
        /// Data de vencimento com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtvenc")]
        public DateTime? DataVencimento { get; set; }

        /// <summary>
        /// Valor com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public decimal? Valor { get; set; }

        [JsonProperty("Vpago")]
        public decimal? ValorPago { get; set; }

        /// <summary>
        /// Data de vencimento original com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtvencorig")]
        public DateTime? DataVencimentoOriginal { get; set; }

        /// <summary>
        /// Valor original com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Valororig")]
        public decimal? ValorOriginal { get; set; }

        [JsonProperty("Dtpag")]
        public DateTime? DataPagamento { get; set; }

        [JsonProperty("Dtbaixa")]
        public DateTime? DataDaBaixa { get; set; }

        ///<summary>
        ///Situação do título.
        ///</summary>
        ///<value>
        ///A – Aberto ou P – Pago C - Cancelado
        ///</value>
        [RangeString("A", "P", "C")]
        public string Status { get; set; }

        /// <summary>
        /// Flag para informar se o título está em cartório.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Cartorio")]
        public string EnviadoCartorio { get; set; }

        ///<summary>
        ///Flag para indicar se o título pode ser recebido pelo vendedor (Se Pronta Entrega)
        ///</summary>
        ///<value>
        ///S - Sim / N (ou NULL) - Não
        ///</value>
        [RangeString("S", "N")]
        public string Recebivel { get; set; }

        /// <summary>
        /// Flag para informar se o título está protestado.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Protesto")]
        public string EnviadoProtesto { get; set; }

        /// <summary>
        /// Código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro de Clientes.
        /// </value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código de cobrança. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// Esse código usado deve estar no Cadastro de Cobrança.
        /// </value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Código de filial. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// Esse código usado deve estar no Cadastro de Filial.
        /// </value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define o código do vendedor. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        [TamanhoMaximo(100)]
        [JsonProperty("Linhadig")]
        public string LinhaDigitavel { get; set; }

        [TamanhoMaximo(100)]
        [JsonProperty("Codbarra")]
        public string CodigoDeBarras { get; set; }

        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Flag para informar se tem boleto.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [RangeString("S", "N")]
        public string Boleto { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrestacoesTitulos";
        internal const string Tabela = "ERP_MXSPREST";
    }
}

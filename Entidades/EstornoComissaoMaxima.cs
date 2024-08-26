using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar os detalhes de estorno de comissão e o vínculo
    /// entre de NF de Devolução e Saída. Obrigatório se maxGestão.
    /// </summary>
    public class EstornoComissaoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "EstornoComissao";
        internal const string Tabela = "ERP_MXSESTCOM";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Numero da transação com preenchimento obrigatório e limite máximo de caracteres 50 caracteres.
        /// </summary>
        /// <value>Sequencial único, que não se repete e que seja um identificador do cabeçalho da nota (Sequence, ROWID, ID e etc)</value>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Numtransent")]
        public string NumeroDaTransacao { get; set; }

        /// <summary>
        /// Define o número da transação, com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="NotaSaidaCapaMaxima"/>.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(NotaSaidaCapaMaxima.VersaoAPI, NotaSaidaCapaMaxima.EndPoint, NotaSaidaCapaMaxima.Tabela, typeof(NotaSaidaCapaMaxima))]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numtransvenda")]
        public int? IdentificadorNotaFiscal { get; set; }

        /// <summary>
        /// Data do estorno/entrada da NF de Devolução com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtestorno")]
        public DateTime? DataDeEstorno { get; set; }

        /// <summary>
        /// Código do Vendedor emissor da NF de Saída com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="VendedorMaxima"/>.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Valor do estorno de comissão com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlestorno")]
        public decimal? ValorEstorno { get; set; }

        /// <summary>
        /// Valor da devolução com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vldevolucao")]
        public decimal? ValorDevolucao { get; set; }
    }
}

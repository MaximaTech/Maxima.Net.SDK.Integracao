using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar os tipos de bonificação (Brinde, Doação, Degustação, Troca, Bonificação etc.)
    /// </summary>
    public class TipoBonificacaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TiposBonificacoes";
        internal const string Tabela = "MXSTIPOBONIFIC";

        /// <summary>
        /// Código do tipo da bonificação, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codbnf")]
        public string CodigoBonificacao { get; set; }

        /// <summary>
        /// Movimenta a conta corrente do vendedor, default "N"
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Movimentaccrca")]
        [RangeString("S", "N")]
        public string MovimentarContaCorrenteVendedor { get; set; }

        /// <summary>
        /// Calcula o IPI para o tipo de bonificação, default "N"
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [JsonProperty("Calculaipi")]
        [RangeString("S", "N")]
        public string CalcularIpi { get; set; }

        /// <summary>
        /// Descrição do tipo bonificação.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public string Descricao { get; set; }

    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os ramos de atividades do cliente.
    /// </summary>
    public class RamoAtividadeMaxima
    {
        /// <summary>
        /// Código do Ramo de Atividade com preenchimento obrigatório e limite até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codativ")]
        public string CodigoRamoAtividadeEconomica { get; set; }

        /// <summary>
        /// Percentual de desconto com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999.99)]
        [JsonProperty("Percdesc")]
        public double? PercentualDescontoTabelaPreco { get; set; }

        /// <summary>
        ///Hash para controle de integração.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Nome do Ramo de Atividade com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Ramo")]
        public string NomeRamoAtividadeEconomica { get; set; }

        /// <summary>
        /// CalcularST define se irá calcular a situação tributária (S ou N). O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Calculast")]
        public string CalcularST { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Atividades";
        internal const string Tabela = "MXSATIVI";

    }
}

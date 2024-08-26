using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar os tipos de operação de venda
    /// (1 – Venda Normal, 5 – Venda bonificada, 13 – Venda Manifesto, 14 – Pronta Entrega).
    /// </summary>
    public class TipoOperacaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TipoOperacao";
        internal const string Tabela = "MXSTIPOOPERACAO";

        /// <summary>
        /// Código da operação com preenchimento obrigatório.
        /// </summary>
        /// <value>1 – Venda Normal, 5 – Venda bonificada, 13 – Venda Manifesto, 14 – Pronta Entrega</value>
        [PropriedadePK]
        [RangeNumber(1, 5, 13, 14)]
        [JsonProperty("Codoper")]
        public int? CodigoOperacao { get; set; }

        /// <summary>
        /// Descrição da operação com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Operacao")]
        public string Operacao { get; set; }
    }
}

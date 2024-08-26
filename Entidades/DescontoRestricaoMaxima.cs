using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar as restrições da campanha.
    /// </summary>
    public class DescontoRestricaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "DescontosRestricoes";
        internal const string Tabela = "MXSDESCONTORESTRICAO";

        /// <summary>
        /// Código de identificação do combo, campo é obrigatório com limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(1)]
        [PropriedadeFK(DescontoCapaMaxima.VersaoAPI, DescontoCapaMaxima.EndPoint, DescontoCapaMaxima.Tabela, typeof(DescontoCapaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codigo")]
        public string CodigoCombo { get; set; }

        /// <summary>
        /// Tipo de restrição de desconto com preenchimento obrigatório
        /// </summary>
        /// <value>
        /// 1 - Filial, 2 - Região, 3 - Ramo de atividade, 4 - Supervisor,
        /// 5 - Vendedor, 6 - Cliente, 7 - Distribuição, 8 - Plano de Pagamento
        /// </value>
        [RangeNumber(1, 2, 3, 4, 5, 6, 7, 8)]
        [PropriedadePK(2)]
        [JsonProperty("Tipo")]
        public int? TipoRestricao { get; set; }

        /// <summary>
        /// Código alfanumérico da restrição de desconto com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(3)]
        [JsonProperty("Codigoa")]
        public string CodigoAlfanumerico { get; set; }

        /// <summary>
        /// Código numérico da restrição de desconto com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(4)]
        [JsonProperty("Codigon")]
        public long? CodigoNumerico { get; set; }
    }
}

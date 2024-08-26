using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os itens que serão concedidos como brinde dentro da campanha.
    /// </summary>
    public class BrindePremioMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "BrindesPremios";
        internal const string Tabela = "MXSBRINDEEXPREMIO";

        /// <summary>
        /// Código de identificação da campanha, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Brinde.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Codbrex")]
        [PropriedadeFK(BrindeMaxima.VersaoAPI, BrindeMaxima.EndPoint, BrindeMaxima.Tabela, typeof(BrindeMaxima))]
        public string CodigoBrinde{ get; set; }

        /// <summary>
        /// Define o código do produto, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produto.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Identificador do grupo de regra, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 999999)]
        [PropriedadePK(3)]
        [JsonProperty("Gruporegra")]
        public int? CodigoGrupoRegra { get; set; }

        /// <summary>
        /// Quantidade a ser concedida como brinde, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qt")]
        public decimal? Quantidade { get; set; }

        /// <summary>
        /// Quantidade máxima do brinde gerado na campanha (nível geral).
        /// </summary>
        [JsonProperty("Qtmaxbrindes")]
        public decimal? QuantidadeMaximaGeral { get; set; }

        /// <summary>
        /// Quantidade máxima do brinde gerado na campanha (nível vendedor).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtmaxbrindesrca")]
        public decimal? QuantidadeMaximaPorVendedor { get; set; }

        /// <summary>
        /// Quantidade máxima do brinde gerado na campanha (nível cliente).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtmaxbrindescli")]
        public decimal? QuantidadeMaximaPorCliente { get; set; }

        /// <summary>
        /// Quantidade máxima do brinde gerado na campanha (nível supervisão).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtmaxbrindessuperv")]
        public decimal? QuantidadeMaximaPorSupervisao { get; set; }


    }
}

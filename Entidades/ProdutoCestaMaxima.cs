using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por detalhar a cesta básica.
    /// </summary>
    public class ProdutoCestaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "FormProds";
        internal const string Tabela = "MXSFORMPROD";

        /// <summary>
        /// Código do produto acabado, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Codprodacab")]
        public string CodigoProdutoAcabado { get; set; }

        /// <summary>
        /// Código do produto matéria prima, com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Codprodmp")]
        public string CodigoProdutoMateriaPrima { get; set; }

        /// <summary>
        /// Código da filial. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [TamanhoMaximo(2)]
        [PropriedadePK(3)]
        [JsonProperty("Codfilial")]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FamiliaMaxima.EndPoint, FamiliaMaxima.Tabela, typeof(FamiliaMaxima))]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Quantidade produto acabado.
        /// </summary>
        [JsonProperty("Qtprodacab")]
        [ValorEntre(0,999999.999999)]
        public decimal? QuantidadeProdutoAcabado { get; set; }

        /// <summary>
        /// Quantidade produto MP, com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Qtprodmp")]
        [CampoObrigatorioAoInserir]
        public decimal? QuantidadeProdutoMp { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável pelo detalhamento dos itens de preço fixo.
    /// </summary>
    public class PrecoCestaItemMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrecosCestasItens";
        internal const string Tabela = "MXSPRECOCESTAI";

        /// <summary>
        /// Código do preço da cesta, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [PropriedadeFK(PrecoCestaMaxima.VersaoAPI, PrecoCestaMaxima.EndPoint, PrecoCestaMaxima.Tabela, typeof(PrecoCestaMaxima))]
        [JsonProperty("Codprecocesta")]
        public string CodigoPrecoCesta { get; set; }

        /// <summary>
        /// Código do produto acabado com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(1)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codprodacab")]
        public string CodigoProdutoAcabado { get; set; }

        /// <summary>
        /// Preço fixo.
        /// </summary>
        public decimal? PrecoFixo { get; set; }
    }
}

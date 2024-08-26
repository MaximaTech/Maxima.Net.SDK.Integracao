using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a relação das filias de retirada de estoque com a filial de venda. 
    /// </summary>
    public class FilialRetiradaEstoqueMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "FiliaisRetira";
        internal const string Tabela = "MXSFILIALRETIRA";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da filial de retirada de estoque. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilialretira")]
        public string CodigoFilialRetirada { get; set; }

        /// <summary>
        /// Código da filial de venda. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilialvenda")]
        public string CodigoFilialVenda { get; set; }
    }
}

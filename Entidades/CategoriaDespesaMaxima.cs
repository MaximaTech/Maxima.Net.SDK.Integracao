using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar as categorias cadastradas de DESPESAS no lançamento de
    /// despesas. No escopo da proposta de solução desta melhoria, trataremos somente DESPESAS
    /// </summary>
    public class CategoriaDespesaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Categoriadespesas";
        internal const string Tabela = "MXSCATEGORIADESPESAS";

        /// <summary>
        /// Código da categoria de despesa com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK]
        [ValorEntre(0, 9999999999)]
        [JsonProperty("CodCategoriaDespesa")]
        public long? CodigoCategoriaDespesa { get; set; }

        /// <summary>
        /// Descrição da categoria de despesa com preenchimento obrigatório e limite de até 300 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(300)]
        public string Descricao { get; set; }

        /// <summary>
        /// Flag que indica se a categoria está ativa ou não, o preenchimento é obrigatório.
        /// </summary>
        /// <value>S - Sim, N - Não</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        public string Ativo { get; set; }
    }
}

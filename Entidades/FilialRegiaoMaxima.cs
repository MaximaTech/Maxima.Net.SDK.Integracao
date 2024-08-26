using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena referências entre filiais e regiões/tabelas de preço. 
    /// </summary>
    public class FilialRegiaoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "FilialRegiao";
        internal const string Tabela = "MXSFILIALREGIAO";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define o número da região, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [PropriedadePK(2)]
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }


        /// <summary>
        /// É prioritário, com preenchimento obrigatório.
        /// </summary>
        /// <value>S-Sim, N-Não</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Prioritaria")]
        public string EhPrioritaria { get; set; }
    }
}

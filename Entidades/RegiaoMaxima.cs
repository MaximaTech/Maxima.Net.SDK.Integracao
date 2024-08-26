using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as regiões para vincular com a tabela de preço
    /// </summary>
    public class RegiaoMaxima
    {
        /// <summary>
        /// Código da região com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadePK]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Nome da regisão com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("regiao")]
        public string NomeRegiao { get; set; }

        ///<summary>
        ///Habilita ou desabilita a região.
        ///</summary>
        ///<value>
        ///(A) Para ativo, (I) Para inativo.
        ///</value>
        [RangeString("A", "I")]
        [JsonProperty("Status")]
        public string Ativo { get; set; }

        /// <summary>
        /// Código da filial da região. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// Código usado deve estar no Cadastro de Filiais.
        /// </value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Regioes";
        internal const string Tabela = "MXSREGIAO";

    }
}

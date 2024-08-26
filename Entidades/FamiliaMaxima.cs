using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    public class FamiliaMaxima
    {
        /// <summary>
        /// Código da família com preenchimento obrigatório
        /// </summary>
        [JsonProperty("Codigo")]
        [PropriedadePK]
        public int CodigoFamilia { get; set; }

        [TamanhoMaximo(10)]
        public string Filtro { get; set; }

        /// <summary>
        /// Código da filial responsável pela família. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>
        /// Código referente ao Cadastro de Filiais.
        /// </value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Descrição da família com preenchimento obrigatório e limite de até 80 caracteres.
        /// </summary>
        [TamanhoMaximo(80)]
        [CampoObrigatorioAoInserir]
        public string Descricao { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Mxsfamilia";
        internal const string Tabela = "MXSFAMILIA";
    }
}

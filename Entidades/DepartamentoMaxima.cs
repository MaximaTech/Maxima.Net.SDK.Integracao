using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os departamentos relacionados ao cadastro de
    /// produto, podendo ser utilizado também como grupo de produtos.
    /// </summary>
    public class DepartamentoMaxima
    {
        /// <summary>
        /// Código do departamento com preenchimento obrigatório
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codepto")]
        [PropriedadePK]
        public string CodigoDepartamento { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Descrição do departamento com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("DESCRICAO")]
        public string Descricao { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Departamentos";
        internal const string Tabela = "MXSDEPTO";

    }
}

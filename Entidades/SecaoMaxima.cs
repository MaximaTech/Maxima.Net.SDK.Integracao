using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as seções relacionados ao cadastro de
    /// produto, podendo ser utilizado também como agrupador de produtos.
    /// </summary>
    public class SecaoMaxima
    {
        /// <summary>
        /// Define o código da seção com preenchimento obrigatório
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codsec")]
        [PropriedadePK]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Define o código do departamento com preenchimento obrigatório
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Departamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codepto")]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(DepartamentoMaxima.VersaoAPI, DepartamentoMaxima.EndPoint, DepartamentoMaxima.Tabela, typeof(DepartamentoMaxima))]
        public string CodigoDepartamento { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Define a descrição da seção com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Descricao { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Secoes";
        internal const string Tabela = "MXSSECAO";

    }
}

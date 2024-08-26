using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar as informações de supervisores do sistema.
    /// Possui ligação com a tabela de supervisores.
    /// </summary>
    public class GerenteMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Gerentes";
        internal const string Tabela = "ERP_MXSGERENTE";

        /// <summary>
        /// Código do gerente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK]
        [TamanhoMaximo(50)]
        [JsonProperty("Codgerente")]
        public string CodigoGerente { get; set; }

        /// <summary>
        /// Código do vendedor com preenchimento obrigatório e limite de até 50 caracteres.
        /// Obrigatório se maxGestao.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de <see cref="VendedorMaxima"/>
        /// </value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Cod_cadrca")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Nome do gerente com preenchimento obrigatório e limite de até 40 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(40)]
        [JsonProperty("Nomegerente")]
        public string Nome { get; set; }
    }
}

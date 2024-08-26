using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar a tabela de preço por região e filial.
    /// Destina-se pra quando tem um preço diferenciado para o processo de filial NF.
    /// </summary>
    public class TabelasDePrecoPorClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "TabelasPrecosClientes";
        internal const string Tabela = "MXSTABPRCLI";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ClienteMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código da Filial com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="FilialMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codfilialnf")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código da região com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RegiaoMaxima"/>.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        public string CodigoRegiao { get; set; }
    }
}

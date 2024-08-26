using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar o posicionamento de GPS dos clientes.
    /// </summary>
    public class LocalizacaoClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ClientesLocalizacoes";
        internal const string Tabela = "MXMP_LOCALIZACAO_CLIENTE";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da localização do cliente com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK]
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Id")]
        public long? CodigoLocalizacaoCliente { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ClienteMaxima"/> </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Id_cliente")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Latitude da localização do cliente com preenchimento obrigatório e limite de até 22 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(22)]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude da localização do cliente com preenchimento obrigatório e limite de até 22 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(22)]
        public string Longitude { get; set; }

        /// <summary>
        /// Precisão da localização do cliente com preenchimento obrigatório.
        /// </summary>
        [TamanhoMaximo(20)]
        public string Precisao { get; set; }

        /// <summary>
        /// Indica se a localização é por cep ou não.
        /// </summary>
        /// <value> S - Sim / N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Por_cep")]
        public string EhPorCep { get; set; }

        /// <summary>
        /// Indica se a localização é por coordenada fixa ou não.
        /// </summary>
        /// <value> S - Sim / N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Coord_fixa")]
        public string EhCoordenadaFixa { get; set; }
    }
}

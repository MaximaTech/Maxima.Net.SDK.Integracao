using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar políticas de acréscimos por cliente.
    /// </summary>
    public class PoliticaDeAcrescimoPorClienteMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "AcrescimosClientes";
        internal const string Tabela = "MXSACRESCIMOSCLIENTES";

        /// <summary>
        /// Código do cliente referente a política de acréscimos.
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de <see cref="ClienteMaxima"/>
        /// </value>
        [PropriedadePK]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Data inicial da vigência.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dataini")]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Data final da vigência.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datafim")]
        public DateTime? DataFim { get; set; }

        /// <summary>
        /// Percentual de acréscimo sobre a tabela de preço.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Percacrescimo")]
        public decimal? PercentualDeAcrescimo { get; set; }
    }
}

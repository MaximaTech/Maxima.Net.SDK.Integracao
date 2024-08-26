using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o cabeçalho das campanhas de brinde.
    /// </summary>
    public class BrindeMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Brindes";
        internal const string Tabela = "MXSBRINDEEX";

        /// <summary>
        /// Código de identificação da campanha, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codbrex")]
        public string CodigoBrinde { get; set; }

        /// <summary>
        /// Descrição da campanha, com preenchimento obrigatório e limite de até 200 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(200)]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        /// <summary>
        /// Data início de vigência, com o preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtinicio")]
        public DateTime? DataInicial { get; set; }

        /// <summary>
        /// Data final de vigência, com o preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtfim")]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Movimenta o conta corrente do vendedor. S ou N, com preenchimento obrigatório e limite de até 200 caracteres.
        /// </summary>
        /// <value>S - Sim, N - Não</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Movccrca")]
        public string MovimentaContaCorrente { get; set; }

        /// <summary>
        /// Quantidade máxima de brindes, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtmaxbrindes")]
        public decimal? QuantidadeMaximaBrindes { get; set; }
    }
}

using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar as informações de visita dos vendedores aos clientes.
    /// </summary>
    public class VisitaVendedorMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "RotaCliente";
        internal const string Tabela = "ERP_MXSROTACLI";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código identificador do compromisso de visita
        /// com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK(1)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcompromisso")]
        public string CodigoCompromisso { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="ClienteMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do vendedor com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="VendedorMaxima"/>.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data da próxima visitia. <br/>
        /// OBS: Existe dois formatos de geração de compromissos: <br/>
        /// - 1º Forma: As próximas visitas são geradas pelo ERP e informadas na coluna DTPROXVISITA.
        /// Nesse cenário a coluna NUMSEMANA precisa estar igual a 1 para que a job da Máxima não recalcule a data, pois ela já está correta. <br/>
        /// - 2º Forma: As próximas visitas são geradas pela MÁXIMA. A coluna DTPROXVISITA deve ser enviada com o
        /// primeiro dia do mês, e a job utiliza as informações em DIASEMANA e NUMSEMANA para calcular a data da próxima visita.
        /// </summary>
        [JsonProperty("Dtproxvisita")]
        public DateTime? DataProximaVisita { get; set; }

        /// <summary>
        /// Hora em que a visita foi realizada.
        /// </summary>
        [ValorEntre(0, 23)]
        public int? HoraVisita { get; set; }

        /// <summary>
        /// Minuto em que a visita foi realizada.
        /// </summary>
        [ValorEntre(0, 59)]
        public int? MinutoVisita { get; set; }

        /// <summary>
        /// Valor que representa a periodicidade para novos compromissos com preenchimento obrigatório.
        /// OBS: A coluna PERIODICIDADE é obrigatória, mas funciona apenas como
        /// informativo para ser apresentada no aplicativo.
        /// </summary>
        /// <value>
        /// Valores possíveis: 1, 7, 14, 15, 21, 28, 30, 35, 42, 45
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("1", "7", "14", "15", "21", "28", "30", "35", "42", "45")]
        public string Periodicidade { get; set; }

        /// <summary>
        /// Sequenciamento para ordenação das visitas com preenchiomento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999)]
        public int? Sequencia { get; set; }

        /// <summary>
        /// Representa o número da semana no mês com preenchimento obrigatório.
        /// </summary>
        /// <value>
        /// Valores possíveis: 1, 2, 3, 4
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeNumber(1, 2, 3, 4)]
        [JsonProperty("Numsemana")]
        public long? NumeroDaSemanaDoMes { get; set; }

        /// <summary>
        /// Representa o dia da semana com preenchimento obrigatório.
        /// </summary>
        /// <value>
        /// Valores possíveis: SEGUNDA, TERCA, QUARTA, QUINTA, SEXTA, SABADO, DOMINGO
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("SEGUNDA", "TERCA", "QUARTA", "QUINTA", "SEXTA", "SABADO", "DOMINGO")]
        [JsonProperty("Diasemana")]
        public string DiaDaSemana { get; set; }

        /// <summary>
        /// Data inicial de vigência da visita.
        /// </summary>
        [JsonProperty("Dtinicio")]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Data final de vigência da visita.
        /// </summary>
        [JsonProperty("Dtfinal")]
        public DateTime? DataFim { get; set; }
    }
}

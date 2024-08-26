using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena um status de entrega referente a nota fiscal
    /// </summary>
    public class NotaFiscalStatusEntregaMaxima
    {
        /// <summary>
        /// Número da nota fiscal. Obrigatório se maxRoteirizador ou maxMotorista.
        /// </summary>
        /// <value>Um valor inteiro maior que zero.</value>
        [JsonProperty("numNota")]
        public int NumNota { get; set; }

        /// <summary>
        /// Número de transação da venda, indentificador unico, pode ser o mesmo número do pedido caso não tenha essa numeração.
        /// </summary>
        [JsonProperty("numTransVenda")]
        public int NumTransVenda { get; set; }

        /// <summary>
        /// Número do carregamento do pedido.
        /// </summary>
        /// <value>O número do carregamento refere ao cadastro de Carregamento</value>
        [JsonProperty("numCar")]
        public string NumCar { get; set; }

        /// <summary>
        /// Código do funcionário motorista da carga. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Funcionários.</value>
        [JsonProperty("codMotorista")]
        public string CodMotorista { get; set; }

        /// <summary>
        /// Devine o status atual da entrega.
        /// </summary>
        [JsonProperty("situacaoEntrega")]
        public string SituacaoEntrega { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "EntregaCarreg";
        internal const string Tabela = "MXMP_NOTAS_FISCAIS";
    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// - Grava as informações relacionadas as rotas de entregas.
    /// - A informação de rota é usada para se realizar filtragem e agrupamentos de pedidos de acordo com a rota do cliente.
    /// - Mesmo de tratando de uma das principais informações que o maxRoteirizador utiliza as informações não são obrigatórias.
    /// - Será utilizada somente caso o cliente trabalhe com o processo de organizar os clientes por rota.
    /// - Caso seja alimentada, é necessário o vínculo do “código rota” na tabela de clientes.
    /// </summary>
    public class RotaClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "RotasExps";
        internal const string Tabela = "MXSROTAEXP";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código da Rota com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codrota")]
        public string CodigoRota { get; set; }

        /// <summary>
        /// Descrição da Rota com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        /// <summary>
        /// Dias de entrega da rota.
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Diasentrega")]
        public int DiasEntrega { get; set; }

        /// <summary>
        /// Tipo de comissão com tamanho máximo de 3 caracteres.
        /// </summary>
        ///<value>'P' = padrão / 'P/L' = por lucratividade</value>
        [RangeString("P", "P/L")]
        [JsonProperty("Tipocomissao")]
        public string TipoDeComissao { get; set; }

        /// <summary>
        /// KM Máximo da rota.
        /// </summary>
        [ValorEntre(0, 99999999.99)]
        [JsonProperty("Kmrota")]
        public double KmMaximoRota { get; set; }

        /// <summary>
        /// Valor da diária.
        /// </summary>
        [ValorEntre(0, 999999.9999)]
        [JsonProperty("Vldiaria")]
        public double ValorDaDiaria { get; set; }

        /// <summary>
        /// Sequência de entrega da rota
        /// </summary>
        [ValorEntre(0, 9999)]
        [JsonProperty("Seqentrega")]
        public int SequenciaDeEntrega { get; set; }

        /// <summary>
        /// Valor mínimo de carregamento da rota
        /// </summary>
        [ValorEntre(0, 99999999.99)]
        [JsonProperty("Vlmincarreg")]
        public double ValorMinimoCarregamento { get; set; }

        /// <summary>
        /// Quantidade máxima de entregas
        /// </summary>
        [ValorEntre(0, 9999)]
        [JsonProperty("Qtentrega")]
        public int QuantidadeMaximaEntrega { get; set; }

        /// <summary>
        /// Situacao da Rota.
        /// </summary>
        /// <value>
        /// A - Ativo / I - Inativo
        /// </value>
        [RangeString("A", "I")]
        [JsonProperty("Situacao")]
        public string Situacao { get; set; }
    }
}

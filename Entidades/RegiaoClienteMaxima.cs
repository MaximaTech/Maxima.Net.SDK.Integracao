using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar referências entre clientes e regiões/tabelas de preço
    /// </summary>
    public class RegiaoClienteMaxima
    {
        /// <summary>
        /// Código da região com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RegiaoMaxima"/></value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadePK(1)]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }

        ///<summary>
        /// Código do cliente, com preenchimento obrigatório e com limite de até 50 caracteres.
        ///</summary>
        ///<value>CodigoCliente referente ao Cadastro de Clientes</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        [PropriedadePK(2)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Percentual de Desconto máximo da tabela de preço
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Perdescmax")]
        public double? PercentualMaximoDeDesconto { get; set; }

        /// <summary>
        /// Flag indicando se é regisão padrão do cliente.
        /// </summary>
        /// <value>"S" - Sim, "N" - Não</value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Vdefault")]
        public string EhValorPadrao { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ClientesRegioes";
        internal const string Tabela = "MXSCLIENTREGIAO";

    }
}

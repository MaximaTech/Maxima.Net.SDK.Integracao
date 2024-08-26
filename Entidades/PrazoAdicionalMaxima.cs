using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar os prazos adicionais com prazo de vigência por
    /// cliente e condição de pagamento.
    /// </summary>
    public class PrazoAdicionalMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrazosAdicionais";
        internal const string Tabela = "MXSPRAZOADICIONAL";

        /// <summary>
        /// Código do prazo adicional com preenchimento obrigatório
        /// </summary>
        [PropriedadePK(1)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codigo")]
        public string CodigoPrazoAdicional { get; set; }

        /// <summary>
        /// Código do plano de pagamento com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="PlanoPagamentoMaxima"/>.</value>
        [PropriedadePK(2)]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código do Ramo de Atividade com preenchimento obrigatório e limite até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RamoAtividadeMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RamoAtividadeMaxima.VersaoAPI, RamoAtividadeMaxima.EndPoint, RamoAtividadeMaxima.Tabela, typeof(RamoAtividadeMaxima))]
        [JsonProperty("Codativ")]
        public string CodigoRamoAtividadeEconomica { get; set; }

        /// <summary>
        /// Código do cliente do pedido com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve exisitir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código que define o vínculo da tabela de preço com o cliente com limite de até 50 caracteres
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro da Praça
        /// </value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codpraca")]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, type: typeof(PracaMaxima))]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Define o código do supervidor.
        /// </summary>
        /// <value>Código referente ao cadastro de Supervisor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(SupervisorMaxima.VersaoAPI, SupervisorMaxima.EndPoint, SupervisorMaxima.Tabela, typeof(SupervisorMaxima))]
        [JsonProperty("Codsupervisor")]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Define o código do vendedor. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data do cadastro do prazo adicinal.
        /// </summary>
        [JsonProperty("Datalanc")]
        public DateTime? DataCadastro { get; set; }

        /// <summary>
        /// Data da última alteração do prazo adicinal.
        /// </summary>
        [JsonProperty("Dataultalter")]
        public DateTime? DataUltimaAlteracao { get; set; }

        /// <summary>
        /// Data inicial da vigência com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtinicio")]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Data final da vigência com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtfim")]
        public DateTime? DataFim { get; set; }

        /// <summary>
        /// Número de dias com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999)]
        [JsonProperty("Numdias")]
        public int? NumeroDeDias { get; set; }

        /// <summary>
        /// Define o número da região com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string NumeroRegiao { get; set; }

        /// <summary>
        /// Define qual a origem do pedido.
        /// </summary>
        /// <value>F – Forca Venda, R – Balcão Reserva, B – Balcão </value>
        [RangeString("F", "R", "B")]
        [JsonProperty("Origemped")]
        public string OrigemPedido { get; set; }

        /// <summary>
        /// Flag que determina se será enviado para o FV.
        /// </summary>
        /// <value>S- Sim / N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Syncfv")]
        public string EnviaForcaDeVenda { get; set; }

        /// <summary>
        /// Flag que determina se utiliza desconto na rede de clientes.
        /// </summary>
        /// <value>S- Sim / N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Utilizadescrede")]
        public string UtilizaDescontoRede { get; set; }

        /// <summary>
        /// Valor mínimo de venda.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlminvenda")]
        public decimal? ValorMinimoVenda { get; set; }
    }
}

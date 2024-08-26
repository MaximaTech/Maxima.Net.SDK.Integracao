using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as políticas de preços promocionais.
    /// </summary>
    public class PrecoPromocaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrecosPromocoes";
        internal const string Tabela = "MXSPRECOPROM";

        /// <summary>
        /// Código indentificador da promoção, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codprecoprom")]
        public string CodigoPrecoPromocao { get; set; }

        /// <summary>
        /// Aceita acrescimo sobre o preço fixo (Observação: Caso os impostos já estejam agregados ao preço fixo, este campo deverá ser enviado como "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [JsonProperty("Aceitaacrescimoprecofixo")]
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        public string AceitaAcrescimoPrecoFixo { get; set; }

        /// <summary>
        /// Aceita desconto sobre o preço fixo (Observação: Caso os impostos já estejam agregados ao preço fixo, este campo deverá ser enviado como "N".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [JsonProperty("Aceitadescprecofixo")]
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        public string AceitaDescPrecofixo { get; set; }

        /// <summary>
        /// Agregar o valor de ST.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        public string AgregarST { get; set; }

        /// <summary>
        /// Aplica desconto de preço fixo apenas no plano de pagamento especificado na coluna "CODPLPAG".
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Apenasplpagmax")]
        public string ApenasPlanoPagamentoMax { get; set; }

        /// <summary>
        /// Aplica desconto do simples nacional
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Aplicadescontosimples")]
        public string AplicaDescontoSimplesNacional { get; set; }

        /// <summary>
        /// Filtro relacionado ao cadastro do cliente.
        /// </summary>
        [TamanhoMaximo(1)]
        [JsonProperty("Classevenda")]
        public string ClasseVenda { get; set; }

        /// <summary>
        /// Código do ramo de atividade do cliente, utilizado como filtro, campo com limite de até 50 caracteres.
        /// </summary>
        [JsonProperty("Codativ")]
        [PropriedadeFK(RamoAtividadeMaxima.VersaoAPI, RamoAtividadeMaxima.EndPoint, RamoAtividadeMaxima.Tabela, typeof(RamoAtividadeMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoAtividade { get; set; }

        /// <summary>
        /// Código de barras da embalagem do produto, utilizado quando deseja restringir o preço fixo por embalagem, campo com limite de até 50 caracteres.
        /// </summary>
        [JsonProperty("Codauxiliar")]
        [TamanhoMaximo(50)]
        public string CodigoDeBarras { get; set; }
        /// <summary>
        /// Código do cliente, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [JsonProperty("Codcli")]
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código da filial, campo é obrigatório com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de filiais.</value>
        [JsonProperty("Codfilial")]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do plano de pagamento, utilizado como filtro, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de planos de pagamento.</value>
        [JsonProperty("Codplpagmax")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoPlanoPagamentoMax { get; set; }

        /// <summary>
        /// Código da praça de atendimento – Filtro relacionado ao cadastro do cliente, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de praças.</value>
        [JsonProperty("Codpraca")]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, typeof(PracaMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Código do produto, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de produto.</value>
        [JsonProperty("Codprod")]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código da rede do cliente – Filtro relacionado ao cadastro do cliente, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de rede de clientes.</value>
        [JsonProperty("Codrede")]
        [PropriedadeFK(RedeClienteMaxima.VersaoAPI, RedeClienteMaxima.EndPoint, RedeClienteMaxima.Tabela, typeof(RedeClienteMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoRedeCliente { get; set; }

        /// <summary>
        /// Código do Supervisor – Filtro relacionado ao cadastro do supervisor, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de supervisores.</value>
        [JsonProperty("Codsupervisor")]
        [PropriedadeFK(SupervisorMaxima.VersaoAPI, SupervisorMaxima.EndPoint, SupervisorMaxima.Tabela, typeof(SupervisorMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Código do vendedor, campo com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de vendedores.</value>
        [JsonProperty("Codusur")]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [TamanhoMaximo(50)]
        public string CodigoVendedor { get; set; }

        /// <summary>
        ///<br>Ao marcar a está flag como “S”, o preço informado no campo “PrecoFixo” será considerado sem imposto, ou seja, </br>
        ///<br>na inclusão do item será calculado os impostos de acordo com a tributação vigente, </br>
        ///<br> e o preço será considerado como base para os impostos.</br>
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Consideraprecosemimposto")]
        [CampoObrigatorioAoInserir]
        public string ConsideraPrecoSemImposto { get; set; }

        /// <summary>
        /// Data inicial da vigência.
        /// </summary>
        [JsonProperty("Dtiniciovigencia")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataInicioVigencia { get; set; }

        /// <summary>
        /// Data final da vigência.
        /// </summary>
        [JsonProperty("Dtfimvigencia")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataFimVigencia { get; set; }

        /// <summary>
        /// Código região / Tabela de preço, campo é obrigatório com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de regiões.</value>
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Origem do pedido. Sé o campo não for informado irar ser setado com F.
        /// </summary>
        /// <value>F – Força de Vendas , R – Balcão Reserva, B – Balcão</value>
        [JsonProperty("Origemped")]
        [RangeString("F", "R", "B")]
        public string OrigemPedido { get; set; }

        /// <summary>
        /// Preço fixo.
        /// </summary>
        [JsonProperty("Precofixo")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999999999.999999)]
        public double? Precofixo { get; set; }

        /// <summary>
        /// Define se utiliza preço fixo por família de produto.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Utilizaprecofixofamilia")]
        public string UtilizaPrecoFixoFamilia { get; set; }

        /// <summary>
        /// Utiliza preço fixo na rede de cliente. Filtro relacionado ao cadastro do cliente.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Utilizaprecofixorede")]
        public string UtilizaPrecoFixoRede { get; set; }

        /// <summary>
        /// <br>Valor de ST – Caso este esteja informado, os seguintes campos deverão estar marcados</br>
        /// <br>(consideraPrecoSemImposto = “N”, aceitaDescPrecoFixo = “N”, aceitaAcrescimoPrecoFixo = “N”, AgregarSt = “S”).</br>
        /// </summary>
        [JsonProperty("Vlst")]
        [ValorEntre(0, 999999999999.999999)]
        public double? ValorSt { get; set; }

        /// <summary>
        /// Enviar para o froça de vendas.
        /// </summary>
        /// <value>
        /// S - Sim / N - Não
        /// </value> 
        [RangeString("S", "N")]
        [JsonProperty("Enviafv")]
        [CampoObrigatorioAoInserir]
        public string EnviaForcaVenda { get; set; }
    }
}

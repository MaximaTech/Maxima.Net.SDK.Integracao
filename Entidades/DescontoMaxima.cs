using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os descontos extra flexível da tabela de preço,
    /// pode ser utilizado como campanha de desconto, desconto por quantidade
    /// ou desconto por faixa de valor.Pode definir se o desconto aplicado irá
    /// ter um % de comissão específica para o vendedor, poderá ser definido
    /// se o desconto movimenta ou não o conta corrente do vendedor.
    /// É possível aplicar um desconto alterando o preço de tabela entre outros.
    /// </summary>
    public class DescontoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Descontos";
        internal const string Tabela = "MXSDESCONTO";

        /// <summary>
        /// Código do desconto, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Coddesconto")]
        public string CodigoDesconto { get; set; }

        /// <summary>
        /// Alterar o preço de tabela.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S","N")]
        [JsonProperty("Alteraptabela")]
        public string AlterarPrecoTabela { get; set; }

        /// <summary>
        /// Flag para definir se é apenas plano de pagamento Max.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S", "N")]
        [JsonProperty("Apenasplpagmax")]
        public string EhApenasPlanoPagamentoMax { get; set; }

        /// <summary>
        /// Aplicar desconto automaticamente.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S", "N")]
        [JsonProperty("Aplicadesconto")]
        public string AplicarDescontoAutomatico { get; set; }

        /// <summary>
        /// Aplicar desconto do simples nacional.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S", "N")]
        [JsonProperty("Aplicadescsimplesnacional")]
        public string AplicarDescontoSimplesNacional{ get; set; }

        /// <summary>
        /// Área de atuação.
        /// </summary>
        [JsonProperty("Areaatuacao")]
        public string AreaAtuacao { get; set; }

        /// <summary>
        /// Altera base para cálculo de débito/crédito de RCA, com preenchimento obrigatório.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Basecreddebrca")]
        public string BaseCreditoDebitoRca { get; set; }

        /// <summary>
        /// Classe de venda.
        /// </summary>
        [JsonProperty("Classevenda")]
        public string ClasseVenda { get; set; }

        /// <summary>
        /// Código do Ramo de Atividade, com limite até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RamoAtividadeMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RamoAtividadeMaxima.VersaoAPI, RamoAtividadeMaxima.EndPoint, RamoAtividadeMaxima.Tabela, typeof(RamoAtividadeMaxima))]
        [JsonProperty("Codativ")]
        public string CodigoRamoAtividadeEconomica { get; set; }

        /// <summary>
        /// Categoria do produto, com limite até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro <see cref="CategoriaMaxima"/></value>
        [PropriedadeFK(CategoriaMaxima.VersaoAPI, CategoriaMaxima.EndPoint, CategoriaMaxima.Tabela, typeof(CategoriaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcategoria")]
        public string CodigoCategoria { get; set; }

        /// <summary>
        /// Código do cliente. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Define o código do departamento. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Departamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codepto")]
        [PropriedadeFK(DepartamentoMaxima.VersaoAPI, DepartamentoMaxima.EndPoint, DepartamentoMaxima.Tabela, typeof(DepartamentoMaxima))]
        public string CodigoDepartamento { get; set; }

        /// <summary>
        /// Código da filial do pedido. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do fornecedor. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de fornecedores.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(FornecedorMaxima.VersaoAPI, FornecedorMaxima.EndPoint, FornecedorMaxima.Tabela, typeof(FornecedorMaxima))]
        [JsonProperty("Codfornec")]
        public string CodigoFornecedor { get; set; }

        /// <summary>
        /// Código do grupo. Com limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codgruporest")]
        public string CodigoGrupo { get; set; }

        /// <summary>
        /// Código da linha e produto, com limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codlinhaprod")]
        public string CodigoLinhaProduto { get; set; }

        /// <summary>
        /// Marca do produto, com limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="MarcaMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(MarcaMaxima.VersaoAPI, MarcaMaxima.EndPoint, MarcaMaxima.Tabela, typeof(MarcaMaxima))]
        [JsonProperty("Codmarca")]
        public string CodigoMarca { get; set; }

        /// <summary>
        /// Código que define o plano de pagamento, com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, type: typeof(PlanoPagamentoMaxima))]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código que define o vínculo da tabela de preço com o cliente, com limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve estar no Cadastro da Praça.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codpraca")]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, type: typeof(PracaMaxima))]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Código do produto do pedido. Com limite de até 50 caracteres. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código do produto principal do pedido. Com limite de até 50 caracteres. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprodprinc")]
        public string CodigoProdutoPrincipal { get; set; }

        /// <summary>
        /// Código da rede do cliente. Com limite de até 50 caracteres. 
        /// </summary>
        ///<value>CodigoRede referente ao Cadastro de Redes</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RedeClienteMaxima.VersaoAPI, RedeClienteMaxima.EndPoint, RedeClienteMaxima.Tabela, type: typeof(RedeClienteMaxima))]
        [JsonProperty("Codrede")]
        public string CodigoRede { get; set; }

        /// <summary>
        /// Código da seção da categoria, com limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="SecaoMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(SecaoMaxima.VersaoAPI, SecaoMaxima.EndPoint, SecaoMaxima.Tabela, typeof(SecaoMaxima))]
        [JsonProperty("Codsec")]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Define o código do supervidor.
        /// </summary>
        /// <value>Código referente ao cadastro de Supervisor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(SupervisorMaxima.VersaoAPI, SupervisorMaxima.EndPoint, SupervisorMaxima.Tabela, typeof(SupervisorMaxima))]
        [JsonProperty("Codsupervisor")]
        public string CodigoSupervisor { get; set; }

        /// <summary>
        /// Define a qual vendedor esse desconto pode ser aplicado. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de Vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, type: typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Creditar RCA na venda com preço maior que política de desconto.
        /// </summary>
        /// <value>S - Sim, N - Não </value>
        [RangeString("S", "N")]
        [JsonProperty("Creditasobrepolitica")]
        public string CreditarPoliticaDesconto { get; set; }

        /// <summary>
        /// Data de início, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("DtInicio")]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Data de fim, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtfim")]
        public DateTime? DataFim { get; set; }

        /// <summary>
        /// Define o número da região. Com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Define qual a origem do pedido com preenchimento obrigatório.
        /// </summary>
        /// <value>F – Forca Venda, R – Balcão Reserva, B – Balcão , O - Outros</value>
        [RangeString("F", "R", "B", "O")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Origemped")]
        public string OrigemPedido { get; set; }

        /// <summary>
        /// Define o percentual comercial de desconto, com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Percdesc")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.9999)]
        public double? PercentualDescontoComercial { get; set; }

        /// <summary>
        /// Define o percentual financeiro de desconto.
        /// </summary>
        [JsonProperty("Percdescfin")]
        [ValorEntre(0, 999999.9999)]
        public double? PercentualDescontoFinanceiro { get; set; }

        /// <summary>
        /// Define o percentual comissão externa.
        /// </summary>
        [JsonProperty("Percomext")]
        [ValorEntre(0, 999999.9999)]
        public double? PercentualComissaoExterna { get; set; }

        /// <summary>
        /// Define o percentual comissão interna.
        /// </summary>
        [JsonProperty("Percommint")]
        [ValorEntre(0, 999999.9999)]
        public double? PercentualComissaoInterna { get; set; }

        /// <summary>
        /// Define o percentual comissão para representante.
        /// </summary>
        [JsonProperty("Percomrep")]
        [ValorEntre(0, 999999.9999)]
        public double? PercentualComissaoRepresentante { get; set; }

        /// <summary>
        /// Flag que identifica se esse desconto vai ser prioritária, com preenchimento obrigatório.
        /// </summary>
        /// <value>S-Sim, N-Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Prioritaria")]
        public string EhPrioritaria { get; set; }

        /// <summary>
        /// Flag que identifica se esse desconto vai ser prioritária geral, com preenchimento obrigatório.
        /// </summary>
        /// <value>S-Sim, N-Não</value>
        [RangeString("S", "N")]
        [JsonProperty("PrioritariaGeral")]
        public string EhPrioritariaGeral { get; set; }

        /// <summary>
        /// Define a quantidade inicial.
        /// </summary>
        [JsonProperty("Qtini")]
        [ValorEntre(0, 999999.9999)]
        public double? QuantidadeInicial { get; set; }


        /// <summary>
        /// Define a quantidade final.
        /// </summary>
        [JsonProperty("Qtfim")]
        [ValorEntre(0, 999999.9999)]
        public double? QuantidadeFinal { get; set; }

        /// <summary>
        /// Tipo de desconto, com preenchimento obrigatório.
        /// </summary>
        /// <value>C – Comercial, F – Financeiro</value>
        [RangeString("C", "F")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Tipo")]
        public string TipoDesconto { get; set; }

        /// <summary>
        /// Tipo de Cadastro do Cliente com limite de 1 caracter.
        /// </summary>
        /// <value> F (Pessoa fisica) / J (Pessoa juridica)</value>
        [RangeString("F", "J")]
        [JsonProperty("Tipofj")]
        public string TipoCadastroCliente { get; set; }

        /// <summary>
        /// Flag que determina se utiliza desconto na rede de clientes.
        /// </summary>
        /// <value>S- Sim / N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Utilizadescrede")]
        public string UtilizaDescontoRede { get; set; }

        /// <summary>
        /// Define o valor mínimo.
        /// </summary>
        [JsonProperty("Vlrminimo")]
        public double? ValorMinimo { get; set; }

        /// <summary>
        /// Define o valor máximo.
        /// </summary>
        [JsonProperty("Vlrmaximo")]
        public double? ValorMaximo { get; set; }
    }
}

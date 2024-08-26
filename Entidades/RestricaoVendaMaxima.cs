using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as restrições de venda do sistema. Exemplo: Vendedor não pode vender produto X na região S. 
    /// </summary>
    public class RestricaoVendaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "RestricoesVendas";
        internal const string Tabela = "MXSRESTRICAOVENDA";

        /// <summary>
        /// Código da restrição da venda, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codrestricao")]
        public string CodigoRestricaoVenda { get; set; }

        /// <summary>
        /// Classe do produto e limite de 1 caracter. 
        /// </summary>
        [TamanhoMaximo(1)]
        [JsonProperty("Classeproduto")]
        public string ClasseProduto { get; set; }

        /// <summary>
        /// Código do Ramo de Atividade e limite até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="RamoAtividadeMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RamoAtividadeMaxima.VersaoAPI, RamoAtividadeMaxima.EndPoint, RamoAtividadeMaxima.Tabela, typeof(RamoAtividadeMaxima))]
        [JsonProperty("Codativ")]
        public string CodigoRamoAtividadeEconomica { get; set; }

        /// <summary>
        /// Código de barras da embalagem e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarrasEmbalagem { get; set; }

        /// <summary>
        /// Código do cliente. Limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve exisitir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Define para qual cobrança o pedido foi feito.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de cobranças.</value>
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        /// <summary>
        /// Define o código do departamento.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Departamento.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(DepartamentoMaxima.VersaoAPI, DepartamentoMaxima.EndPoint, DepartamentoMaxima.Tabela, typeof(DepartamentoMaxima))]
        [JsonProperty("Codepto")]
        public string CodigoDepartamento { get; set; }

        /// <summary>
        /// Código da filial.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do cliente da devolução.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de fornecedores.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(FornecedorMaxima.VersaoAPI, FornecedorMaxima.EndPoint, FornecedorMaxima.Tabela, typeof(FornecedorMaxima))]
        [JsonProperty("Codfornec")]
        public string CodigoFornecedor { get; set; }

        /// <summary>
        /// Marca do produto
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="MarcaMaxima"/></value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(MarcaMaxima.VersaoAPI, MarcaMaxima.EndPoint, MarcaMaxima.Tabela, typeof(MarcaMaxima))]
        [JsonProperty("Codmarca")]
        public string CodigoMarca { get; set; }

        /// <summary>
        /// Código do plano de pagamento do pedido.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código que define o vínculo da tabela de preço com o cliente. 
        /// </summary>
        /// <value>O código usado deve estar no Cadastro da Praça.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codpraca")]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, type: typeof(PracaMaxima))]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Código do produto do pedido.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Código da seção da categoria com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="SecaoMaxima"/>.</value>
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
        /// Código do vendedor do pedido. Limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Define qual foi o tipo de venda do pedido.
        /// </summary>
        /// <value>1 – Venda Normal, 5 – Bonificação, 7 - Venda Futura, 11 – Troca, 13 – NF Manifesto (Saída), 14 – Venda Manifesto (Pronta-Entrega), 24 – Bonificação (Pronta-Entrega)</value>
        [RangeNumber(1, 5, 7, 11, 13, 14, 24)]
        [JsonProperty("Condvenda")]
        public int? TipoVenda { get; set; }

        /// <summary>
        /// Frete de despacho 
        /// </summary>
        /// <value> S - Sim ou N - Não </value>
        [RangeString("S", "N")]
        [TamanhoMaximo(1)]
        [JsonProperty("Fretedespacho")]
        public string FreteDespacho { get; set; }

        /// <summary>
        /// Define o número da região.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string NumeroRegiao { get; set; }

        /// <summary>
        /// Define qual a origem do pedido com preenchimento obrigatório.
        /// </summary>
        /// <value>F – Força de Vendas </value>
        [RangeString("F")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Origemped")]
        public string OrigemPedido { get; set; }

        /// <summary>
        /// Tipo de Cadastro do Cliente com limite de 1 caracter.
        /// </summary>
        /// <value> F (Pessoa fisica) / J (Pessoa juridica)</value>
        [RangeString("F", "J")]
        [JsonProperty("Tipofj")]
        public string TipoCadastroCliente { get; set; }

        /// <summary>
        /// Valor mínimo de venda.
        /// </summary>
        [JsonProperty("Valorminimovenda")]
        public decimal? ValorMinimoVenda { get; set; }

        /// <summary>
        /// Código do cliente principal. Limite de até 50 caracteres.
        /// </summary>
        /// <value>O código usado deve exisitir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcliprinc")]
        public string CodigoClientePrincipal { get; set; }

        /// <summary>
        /// Código da rede do cliente.
        /// </summary>
        ///<value>CodigoRede referente ao Cadastro de Redes</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RedeClienteMaxima.VersaoAPI, RedeClienteMaxima.EndPoint, RedeClienteMaxima.Tabela, type: typeof(RedeClienteMaxima))]
        [JsonProperty("Codrede")]
        public string CodigoRede { get; set; }

        /// <summary>
        /// Código da cidade do endereço comercial. Limite de até 50 caracteres 
        /// </summary>
        /// <value>O código usado deve estar no Cadastro de Cidades.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(CidadeMaxima.VersaoAPI, CidadeMaxima.EndPoint, CidadeMaxima.Tabela, type: typeof(CidadeMaxima))]
        [JsonProperty("Codcidade")]
        public string CodigoCidade { get; set; }

    }
}

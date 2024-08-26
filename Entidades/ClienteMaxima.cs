using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os dados dos clientes
    /// </summary>
    public class ClienteMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Clientes";
        internal const string Tabela = "MXSCLIENT";

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do cliente com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        [JsonProperty("Dtultcomp")]
        public DateTime? DataUltimaCompra { get; set; }

        [JsonProperty("Dtcadastro")]
        public DateTime? DataCadastro { get; set; }

        [JsonProperty("Limcred")]
        [ValorEntre(0, 9999999999.99)]
        public double? LimiteCredito { get; set; }

        /// <summary>
        /// Código que define o plano de pagamento principal do cliente com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, type: typeof(PlanoPagamentoMaxima))]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código que define o vínculo da tabela de preço com o cliente. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro da Praça
        /// </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codpraca")]
        [PropriedadeFK(PracaMaxima.VersaoAPI, PracaMaxima.EndPoint, PracaMaxima.Tabela, type: typeof(PracaMaxima))]
        public string CodigoPraca { get; set; }

        /// <summary>
        /// Código do ramo de atividade econôminca do cliente com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro do Ramo de Atividade
        /// </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(RamoAtividadeMaxima.VersaoAPI, RamoAtividadeMaxima.EndPoint, RamoAtividadeMaxima.Tabela, type: typeof(RamoAtividadeMaxima))]
        [JsonProperty("Codatv1")]
        public string CodigoRamoAtividade { get; set; }

        /// <summary>
        /// [Propriedade interna] Código do Último funcionário a alterar o cadastro com <br/>
        /// preenchimento obrigatório e limite de 50 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codfuncultalter")]
        internal string Codfuncultalter { get; set; }

        /// <summary>
        /// Define a qual vendedor pertence esse cliente. O preenchimento é obrigatório e limite de até 50 caracteres <br/>
        /// Esse código usado deve estar no Cadastro de Vendedores
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, type: typeof(VendedorMaxima))]
        [JsonProperty("Codusur1")]
        public string CodigoVendedor1 { get; set; }

        [TamanhoMaximo(50)]
        [JsonProperty("Codusur2")]
        public string CodigoVendedor2 { get; set; }

        [TamanhoMaximo(50)]
        [JsonProperty("Codusur3")]
        public string CodigoVendedor3 { get; set; }

        #region Endereco Comercial

        /// <summary>
        /// Código da cidade do endereço comercial. O preenchimento é obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>
        /// O código usado deve estar no Cadastro de Cidades
        /// </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(CidadeMaxima.VersaoAPI, CidadeMaxima.EndPoint, CidadeMaxima.Tabela, type: typeof(CidadeMaxima))]
        [JsonProperty("Codcidade")]
        public string CodigoCidadeEndereco { get; set; }

        /// <summary>
        /// Bairro do endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Bairroent")]
        public string BairroEnderecoComercial { get; set; }

        /// <summary>
        /// CEP do endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [TamanhoMaximo(4000)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Cepent")]
        public string CEPEnderecoComercial { get; set; }

        /// <summary>
        /// Município do endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Municent")]
        public string MunicipioEnderecoComercial { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Complementoent")]
        public string ComplementoEnderecoComercial { get; set; }

        /// <summary>
        /// Endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Enderent")]
        public string EnderecoComercial { get; set; }

        /// <summary>
        /// Número do endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Numeroent")]
        public string NumeroEnderecoComercial { get; set; }

        /// <summary>
        /// Estado do endereço comercial do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Estent")]
        public string EstadoEnderecoComercial { get; set; }

        #endregion

        #region Endereco Entrega

        /// <summary>
        /// Bairro do endereço de entrega do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Bairrocom")]
        public string BairroEnderecoEntrega { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Cepcom")]
        public string CEPEnderecoEntrega { get; set; }

        /// <summary>
        /// Município do endereço de entrega do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Municcom")]
        public string MunicipioEnderecoEntrega { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Complementocom")]
        public string ComplementoEnderecoEntrega { get; set; }

        /// <summary>
        /// Endereço de entrega do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Endercom")]
        public string EnderecoEntrega { get; set; }

        /// <summary>
        /// Número do endereço de entrega do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Numerocom")]
        public string NumeroEnderecoEntrega { get; set; }

        /// <summary>
        /// Estado do endereço de entrega do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Estcom")]
        public string EstadoEnderecoEntrega { get; set; }

        #endregion

        #region Endereco Cobranca

        [TamanhoMaximo(4000)]
        [JsonProperty("Paisent")]
        public string PaisEnderecoCliente { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Bairrocob")]
        public string BairroEnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Cepcob")]
        public string CEPEnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Municcob")]
        public string MunicipioEnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Complementocob")]
        public string ComplementoEnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Endercob")]
        public string EnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Numerocob")]
        public string NumeroEnderecoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Estcob")]
        public string EstadoEnderecoCobranca { get; set; }

        #endregion

        /// <summary>
        /// Nome do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Cliente")]
        public string NomeCliente { get; set; }

        /// <summary>
        /// Nome Fantasia do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Fantasia")]
        public string NomeFantasia { get; set; }

        /// <summary>
        /// CPF/CNPJ do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Cgcent")]
        public string CpfCnpj { get; set; }

        /// <summary>
        /// Código da cobrança principal para o cliente. O preenchimento é obrigatório <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de cobranças.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [PropriedadeFK(CobrancaMaxima.VersaoAPI, CobrancaMaxima.EndPoint, CobrancaMaxima.Tabela, type: typeof(CobrancaMaxima))]
        [JsonProperty("Codcob")]
        public string CodigoCobranca { get; set; }

        [TamanhoMaximo(4000)]
        public string Email { get; set; }

        /// <summary>
        /// Inscricao Estadual do cliente com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Ieent")]
        public string InscricaoEstadual { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Iment")]
        public string InscricaoMunicipal { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Telent")]
        public string Telefone { get; set; }

        /// <summary>
        /// Tipo de Cadastro do Cliente com preenchimento obrigatório e limite 1 caractere.
        /// </summary>
        /// <value>
        ///  F (Pessoa fisica) / J (Pessoa juridica)
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "F", "J" })]
        [JsonProperty("Tipofj")]
        public string TipoCadastroCliente { get; set; }

        /// <summary>
        /// Habilita ou desabilita o cliente para contribuinte. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        public string Contribuinte { get; set; }

        /// <summary>
        /// Habilita ou desabilita o cliente para consumidor final. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Consumidorfinal")]
        public string ConsumidorFinal { get; set; }

        /// <summary>
        /// Habilita ou desabilita o cliente para venda, pode ser usado como bloqueio financeiro. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para bloqueado, (N) Para desbloqueado
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Bloqueio")]
        public string BloqueioVenda { get; set; }

        /// <summary>
        /// Habilita ou desabilita o cliente para calcular ST. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Calculast")]
        public string CalcularST { get; set; }

        [TamanhoMaximo(4000)]
        public string Obs { get; set; }

        /// <summary>
        /// Validar Múltiplo de Venda para o Cliente. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Validarmultiplovenda")]
        public string ValidarMultiploVenda { get; set; }

        /// <summary>
        /// Habilita ou desabilita o cliente validar campanhas de brinde. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Validarcampanhabrinde")]
        public string ValidarCampanhaBrinde { get; set; }

        /// <summary>
        /// Habilita ou desabilita a venda fracionada para o cliente. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Aceitavendafracao")]
        public string AceitaVendaFracionada { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda padrão. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda1")]
        public string UsaVendaPadrao { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda bonificada. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda5")]
        public string UsaVendaBonificada { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda para entrega futura. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda7")]
        public string UsaVendaEntregaFutura { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda simples entrega. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda8")]
        public string UsaVendaSimplesEntrega { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda normal, parecido com venda padrão mas possibilita a configuração do CFOP diferenciado.
        /// O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda9")]
        public string UsaVendaNormal { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda com troca bonificada. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda11")]
        public string UsaVendaComTroca { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda simples remessa. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda13")]
        public string UsaVendaSimplesRemessa { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda manifesto. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda14")]
        public string UsaVendaManifesto { get; set; }

        /// <summary>
        /// Habilita ou desabilita venda consignada. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Condvenda20")]
        public string UsaVendaConsignada { get; set; }

        /// <summary>
        /// Define se o cliente e do regime Simples Nacional. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Simplesnacional")]
        public string SimplesNacional { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Rg")]
        public string RG { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Orgaorg")]
        public string OrgaoEmissorRG { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Telcob")]
        public string TelefoneDeCobranca { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Telcom")]
        public string TelefoneComercial { get; set; }

        [TamanhoMaximo(4000)]
        public string Latitude { get; set; }

        [TamanhoMaximo(4000)]
        public string Longitude { get; set; }

        [TamanhoMaximo(4000)]
        [JsonProperty("Emailnfe")]
        public string EmailNfe { get; set; }

        /// <summary>
        /// Habilita ou desabilita o bloqueio no sefaz para o cleinte. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Bloqueiosefaz")]
        public string BloqueioSefaz { get; set; }

        /// <summary>
        /// Flag que informa se o cliente está com bloqueio definitivo. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Bloqueiodefinitivo")]
        public string Inativo { get; set; }

        /// <summary>
        /// Habilita ou desabilita a utilização de crédito e débito do conta corrente do RCA. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// (S) Para sim, (N) Para não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "S", "N" })]
        [JsonProperty("Usadebcredrca")]
        public string UsaDebitoECreditoDoContaCorrente { get; set; }

        /// <summary>
        /// Fixar Coordenada do cliente.
        /// </summary>
        [JsonProperty("Fixarcoordenada")]
        [RangeNumber(0, 1)]
        public int FixarCoordenada { get; set; }

        /// <summary>
        /// Ponto de Referência do endereço do cliente.
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Pontorefer")]
        public string PontoDeReferencia { get; set; }

        /// <summary>
        /// Código da rede do cliente.
        /// </summary>
        ///<value>CodigoRede referente ao Cadastro de Redes</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RedeClienteMaxima.VersaoAPI, RedeClienteMaxima.EndPoint, RedeClienteMaxima.Tabela, type: typeof(RedeClienteMaxima))]
        [JsonProperty("Codrede")]
        public string CodigoRede { get; set; }

        /// <summary>
        /// Código da rota do cliente.
        /// </summary>
        ///<value>CodigoRota referente ao Cadastro de Rotas</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(RotaClienteMaxima.VersaoAPI, RotaClienteMaxima.EndPoint, RotaClienteMaxima.Tabela, type: typeof(RotaClienteMaxima))]
        [JsonProperty("Codrota")]
        public string CodigoRota { get; set; }
    }
}

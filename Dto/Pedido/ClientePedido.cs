using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class ClienteMaximaCadastro
    {
        #region Fields
        public long Id_cliente { get; set; }
        private List<ContatoCliente> contatos;
        private List<EnderecoEntrega> enderecosEntrega;
        private List<ReferenciaCliente> refrenciasComerciais;
        private Endereco endereco, enderecoComercial, enderecoCobranca;
        private StatusCliente status;
        private ConfiguracoesCliente configuracoes;
        private InformacoesBancarias infBancarias1, infBancarias2;

        #endregion

        public override bool Equals(object obj)
        {
            return (obj is ClienteMaximaCadastro) && (obj as ClienteMaximaCadastro).Codigo.Equals(Codigo);
        }

        public override int GetHashCode()
        {
            return Codigo.GetHashCode();
        }

        #region Classes


        public class EnderecoEntrega
        {

            public string CodCliente { get; set; }

            public string Codigo { get; set; }

            public string CodBairro { get; set; }

            public string Endereco { get; set; }

            public string Cep { get; set; }

            public string Complemento { get; set; }

            public string Bairro { get; set; }

            public string Municipio { get; set; }

            public string Estado { get; set; }

            public string CodPraca { get; set; }


            public string Numero { get; set; }


            public string Telefone { get; set; }

            public string ApelidoUnidade { get; set; }

            public override string ToString()
            {
                return this.Endereco;
            }

            public string EnderecoApelido
            {
                get
                {
                    if (!Endereco.Equals("[NENHUM]") && !string.IsNullOrEmpty(ApelidoUnidade))
                        return Endereco + " - " + ApelidoUnidade;
                    return this.Endereco;
                }
            }
        }


        [Serializable]
        public class StatusCliente
        {

            public bool Bloqueado
            { get; set; }

            public DateTime? DataBloqueio
            { get; set; }

        }


        public class RoteiroVisitaCliente
        {

            public string CodUsur { get; set; }


            public string DiaSemana { get; set; }


            public int NumSemana { get; set; }


            public int Sequencia { get; set; }


            public string Periodicidade { get; set; }


            public DateTime DataProximaVisita { get; set; }


            public DateTime DataInicio { get; set; }


            public DateTime DataFinal { get; set; }
        }


        public class ConfiguracoesCliente
        {


            public bool IsentoICMS
            { get; set; }


            public bool IsentoIPI
            { get; set; }


            public bool Contribuinte
            { get; set; }


            public bool AceitaVendaFracionada
            { get; set; }


            public bool CalculaST
            { get; set; }


            public bool AtualizaSaldoDescontoFinanceiro
            { get; set; }


            public bool ValidarCampanhaBrinde
            { get; set; }


            public bool ValidarMultiploVenda
            { get; set; }


            public string TipoDescontoIsencao
            { get; set; }


            public decimal PercDescontoIsentoICMS
            { get; set; }

            /// <summary>
            /// Percentual de Comissao atribuido ao cliente
            /// </summary>

            public decimal? PercComissao
            { get; set; }


            public decimal PercDesconto
            { get; set; }

            /// <summary>
            /// Informa se o cliente possui plano de pagamento negociado
            /// </summary>

            public bool PlanoPagamentoNegociado
            { get; set; }


            public string Sulframa
            { get; set; }


            public DateTime? SulframaDtVenc
            { get; set; }


            public bool IsentoDiferencaAliquotas
            { get; set; }


            public bool SimplesNacional
            { get; set; }


            public bool UtilizaIESimplificada
            { get; set; }


            public bool FonteST
            { get; set; }


            public string TipoEmpresa
            { get; set; }


            public string UsaIVAFonteDiferenciado
            { get; set; }


            public decimal PercIVAFonte
            { get; set; }


            public bool OrgaoPublico
            { get; set; }


            public bool OrgaoPublicoFederal
            { get; set; }


            public bool Monitorado
            { get; set; }


            public string TipoDocumento
            { get; set; }


            public bool ConsumidorFinal
            { get; set; }


            public string IsencaoSulframa
            { get; set; }


            public bool UtilizaDescontoIcms
            { get; set; }


            public string TipoFJ
            { get; set; }


            public bool BloqueioSefaz { get; set; }


            public DateTime? ValidadeIbama
            { get; set; }


            public string RegistroIbama
            { get; set; }


            public bool BloqueioDefinitivo
            { get; set; }


            public bool ClienteRecemCadastrado
            { get; set; }


            public int PrazoAdicional { get; set; }


            public bool RegiaoAtiva { get; set; }


            public bool UsaCalculoStMt { get; set; }


            public bool clienteCadastroNovo { get; set; }

            public string HorarioInicioRoteiro { get; set; }

            public string HorarioFimRoteiro { get; set; }
        }


        public class ContatoCliente
        {


            public string Nome
            { get; set; }


            public string Tipo
            { get; set; }


            public string CNPJ
            { get; set; }


            public DateTime? DataNascimento
            { get; set; }


            public string Telefone
            { get; set; }


            public string Celular
            { get; set; }


            public string Email
            { get; set; }


            public string TipoOperacao
            { get; set; }


            public int? RetornoImportacao
            { get; set; }


            public string CriticaImportacao
            { get; set; }


            public string Codigo
            { get; set; }


            public string Cargo { get; set; }


            public string Hobbie { get; set; }


            public string Time { get; set; }


            public string NomeConjuge { get; set; }


            public DateTime? DataNascimentoConjuge
            { get; set; }


            public string Observacao { get; set; }

            public bool ContatoSalvo { get; set; }
        }


        public class ReferenciaCliente
        {


            public string Cnpj
            { get; set; }


            public int Sequencia
            { get; set; }


            public string Empresa
            { get; set; }


            public string Telefone
            { get; set; }


            public string Contato
            { get; set; }


            public string CriticaImportacao
            { get; set; }


            public int? RetornoImportacao
            { get; set; }


            public string TipoOperacao
            { get; set; }

        }

        [Serializable]
        public class MetasCliente
        {

            public string Codigo { get; set; }

            public int Ano { get; set; }

            public decimal MetaMes01 { get; set; }

            public decimal MetaMes02 { get; set; }

            public decimal MetaMes03 { get; set; }

            public decimal MetaMes04 { get; set; }

            public decimal MetaMes05 { get; set; }

            public decimal MetaMes06 { get; set; }

            public decimal MetaMes07 { get; set; }

            public decimal MetaMes08 { get; set; }

            public decimal MetaMes09 { get; set; }

            public decimal MetaMes10 { get; set; }

            public decimal MetaMes11 { get; set; }

            public decimal MetaMes12 { get; set; }
        }


        public class Alvara
        {

            public string Numero { get; set; }


            public DateTime? DataVencimento { get; set; }
        }

        [Serializable]
        public class MixCliente
        {
            private ProdutoPedido produtoVenda;

            public ProdutoPedido ProdutoVenda
            {
                get { return produtoVenda; }
                set { produtoVenda = value; }
            }
            private FilialPedido filialVenda;

            public FilialPedido FilialVenda
            {
                get { return filialVenda; }
                set { filialVenda = value; }
            }
            private DateTime dataVenda;

            public DateTime DataVenda
            {
                get { return dataVenda; }
                set { dataVenda = value; }
            }
            private PlanoPagamentoPedido planoPagamentoVenda;

            public PlanoPagamentoPedido PlanoPagamentoVenda
            {
                get { return planoPagamentoVenda; }
                set { planoPagamentoVenda = value; }
            }
            private Cobranca cobrancaVenda;

            public Cobranca CobrancaVenda
            {
                get { return cobrancaVenda; }
                set { cobrancaVenda = value; }
            }
            private decimal precoTabela;

            public decimal PrecoTabela
            {
                get { return precoTabela; }
                set { precoTabela = value; }
            }
            private decimal precoVenda;

            public decimal PrecoVenda
            {
                get { return precoVenda; }
                set { precoVenda = value; }
            }
            private decimal quantidade;

            public decimal Quantidade
            {
                get { return quantidade; }
                set { quantidade = value; }
            }
            private decimal estoqueDisponivel;

            public decimal EstoqueDisponivel
            {
                get { return estoqueDisponivel; }
                set { estoqueDisponivel = value; }
            }

            public decimal PercDesconto
            {
                get { return precoTabela == 0 ? 0 : (precoTabela - precoVenda) / precoTabela; }
            }

        }


        #endregion

        #region Propriedades


        public long CodigoClienteNuvem { get; set; }


        public string Codigo
        { get; set; }


        public string CodigoPrincipal
        { get; set; }


        public bool StatusCodPrincipalBloqueado
        { get; set; }


        public string CodigoRede
        { get; set; }


        public string Nome
        { get; set; }


        public string Fantasia
        { get; set; }


        public string CNPJ
        { get; set; }


        public Credito Credito
        { get; set; }


        public string InscricaoEstadual
        { get; set; }


        public string InscricaoMunicipal
        { get; set; }


        public string FilialNF
        { get; set; }

        public DateTime? DtUltimaCompra
        { get; set; }


        public Endereco Endereco
        {
            get
            {
                if (endereco == null)
                    endereco = new Endereco();
                return endereco;
            }
            set { endereco = value; }
        }



        public string Telefone
        { get; set; }


        public Praca Praca
        { get; set; }


        public RamoAtividade RamoAtividade
        { get; set; }

        public string Classificacao
        { get; set; }


        public Cobranca Cobranca
        { get; set; }


        public PlanoPagamentoPedido PlanoPagamento
        { get; set; }


        public StatusCliente Status
        {
            get
            {

                if (status == null)
                    status = new StatusCliente();

                return status;
            }
            set { status = value; }
        }


        public ConfiguracoesCliente Configuracoes
        {
            get
            {

                if (configuracoes == null)
                    configuracoes = new ConfiguracoesCliente();

                return configuracoes;
            }
            set { configuracoes = value; }
        }


        public bool PessoaFisica
        { get; set; }

        public bool Bloqueado
        { get; set; }

        public string ClasseVenda
        { get; set; }

        public string VIP
        { get; set; }

        public string OrigemPreco
        { get; set; }

        public string FreteDespacho
        { get; set; }


        public TransportadoraPedido Transportadora
        { get; set; }

        public decimal? ValorFrete
        { get; set; }

        public decimal? ValorMaximoCobFrete
        { get; set; }

        public bool ValidarMaxVendaPf
        { get; set; }

        public string Contato
        { get; set; }


        public string Email
        { get; set; }


        public string Observacao
        { get; set; }


        public string ObservacaoEntrega
        { get; set; }


        public string ContatoFinanceiro { get; set; }


        public string Comprador { get; set; }


        public DateTime DataAniversarioComprador { get; set; }


        public bool DiasLigarSeg { get; set; }


        public bool DiasLigarTer { get; set; }


        public bool DiasLigarQua { get; set; }


        public bool DiasLigarQui { get; set; }


        public bool DiasLigarSex { get; set; }


        public bool DiasLigarSab { get; set; }


        public bool DiasVisitaSeg { get; set; }


        public bool DiasVisitaTer { get; set; }


        public bool DiasVisitaQua { get; set; }


        public bool DiasVisitaQui { get; set; }


        public bool DiasVisitaSex { get; set; }


        public bool DiasVisitaSab { get; set; }


        public string WhatsappComercial { get; set; }


        public string Mercado { get; set; }


        public int NumAssentos { get; set; }


        public decimal TicketMedio { get; set; }


        public int QtCheckoutVarejo { get; set; }

        public bool UtilizaNovosCampos { get; set; }

        #endregion

        /// <summary>
        /// Tipo de Operacao utilizado durante o processo de inclusao / alteracao de cadastro de clientes
        /// I = Inclusao, A = Alteracao
        /// </summary>

        public string TipoOperacao
        { get; set; }


        public string RG
        { get; set; }


        public string OrgaoRG
        { get; set; }


        public string PontoReferencia
        { get; set; }


        public string TelefoneCobranca
        { get; set; }


        public string TelefoneComercial
        { get; set; }


        public string FaxComercial
        { get; set; }


        public string Fax
        { get; set; }


        public bool PredioProprio
        { get; set; }


        public string ObservacaoCredito
        { get; set; }


        public string Telefone2
        { get; set; }


        public string CaixaPostal
        { get; set; }


        public InformacoesBancarias InfBancarias1
        {
            get
            {
                if (infBancarias1 == null)
                    infBancarias1 = new InformacoesBancarias();
                return infBancarias1;
            }
            set { infBancarias1 = value; }
        }


        public InformacoesBancarias InfBancarias2
        {
            get
            {
                if (infBancarias2 == null)
                    infBancarias2 = new InformacoesBancarias();
                return infBancarias2;
            }
            set { infBancarias2 = value; }
        }


        public string Site
        { get; set; }


        public string ObservacaoGerencial
        { get; set; }


        public GeoLocation Geolocalizacao
        { get; set; }


        public RoteiroVisitaCliente RoteiroVisita { get; set; }



        public string EmailNFE { get; set; }


        public string CriticaImportacao { get; set; }


        public uint? Checkouts { get; set; }


        public string CodigoFV { get; set; }


        public string CodigoRCA { get; set; }


        public Endereco EnderecoComercial
        {
            get
            {
                if (enderecoComercial == null)
                    enderecoComercial = new Endereco();
                return enderecoComercial;
            }
            set { enderecoComercial = value; }
        }


        public Endereco EnderecoCobranca
        {
            get
            {
                if (enderecoCobranca == null)
                    enderecoCobranca = new Endereco();
                return enderecoCobranca;
            }
            set { enderecoCobranca = value; }
        }


        public int? RetornoImportacao { get; set; }


        public List<ClienteMaximaCadastro.ContatoCliente> Contatos
        {
            get
            {
                if (contatos == null)
                    contatos = new List<ClienteMaximaCadastro.ContatoCliente>();
                return contatos;
            }
            set
            {
                contatos = value;
            }


        }


        public List<ReferenciaCliente> ReferenciasComerciais
        {
            get
            {
                if (this.refrenciasComerciais == null)
                    this.refrenciasComerciais = new List<ReferenciaCliente>();

                return this.refrenciasComerciais;
            }

            set
            {
                this.refrenciasComerciais = value;
            }
        }


        public Alvara AlvaraFuncionamento { get; set; }


        public Alvara AlvaraPsicotropico { get; set; }


        public Alvara AlvaraAnvisa { get; set; }


        public Alvara AlvaraSUS { get; set; }


        public Alvara AlvaraCRF { get; set; }


        public bool Repasse { get; set; }


        public bool DescontoFinanceiroSeparadoComercial { get; set; }

        public string ObservacaoPedido { get; set; }

        public bool Positivado { get; set; }


        public int StatusDoClienteIntegracao { get; set; }

        /// <summary>
        /// Informa se o Alvara de funcionamento desse cliente esta vencido
        /// </summary>
        public bool AlvaraFuncionamentoVencido
        {
            get
            {
                return (AlvaraFuncionamento != null && !string.IsNullOrEmpty(AlvaraFuncionamento.Numero) && (AlvaraFuncionamento.DataVencimento ?? DateTime.MinValue) < DateTime.Today);
            }

        }

        /// <summary>
        /// Informa se o Alvara Psicotropico desse cliente esta vencido
        /// </summary>
        public bool AlvaraPsicotropicoVencido
        {
            get
            {
                return (AlvaraPsicotropico != null && !string.IsNullOrEmpty(AlvaraPsicotropico.Numero) && (AlvaraPsicotropico.DataVencimento ?? DateTime.MinValue) < DateTime.Today);
            }

        }

        /// <summary>
        /// Informa se o Alvara Anvisa desse cliente esta vencido
        /// </summary>
        public bool AlvaraAnvisaVencido
        {
            get
            {
                return (AlvaraAnvisa != null && !string.IsNullOrEmpty(AlvaraAnvisa.Numero) && (AlvaraAnvisa.DataVencimento ?? DateTime.MinValue) < DateTime.Today);
            }

        }

        /// <summary>
        /// Informa se o Alvara do SUS desse cliente esta vencido
        /// </summary>
        public bool AlvaraSUSVencido
        {
            get
            {
                return (AlvaraSUS != null && !string.IsNullOrEmpty(AlvaraSUS.Numero) && (AlvaraSUS.DataVencimento ?? DateTime.MinValue) < DateTime.Today);
            }

        }


        public List<EnderecoEntrega> EnderecosEntrega
        {
            get
            {
                if (enderecosEntrega == null)
                    enderecosEntrega = new List<EnderecoEntrega>();

                return enderecosEntrega;
            }
            set { enderecosEntrega = value; }
        }


        public bool AlvaraCRFVencido
        {
            get
            {
                return (AlvaraCRF != null && !string.IsNullOrEmpty(AlvaraCRF.Numero) && (AlvaraCRF.DataVencimento ?? DateTime.MinValue) < DateTime.Today);

            }
        }

        public string NomeRca { get; set; }


        public bool TemCodigoDeConsumidorFinal
        {
            get
            {
                if (string.IsNullOrEmpty(Codigo))
                {
                    Codigo = string.Empty;
                }

                return (Codigo.Equals("1") || Codigo.Equals("2") || Codigo.Equals("3"));
            }
        }

        public bool PossuiInformacoesRegistroIbama
        {
            get
            {
                return Configuracoes.ValidadeIbama.HasValue &&
              !string.IsNullOrEmpty(Configuracoes.RegistroIbama);
            }
        }


        public Dictionary<string, object> DicionarioDeParametros { get; set; }


        public DateTime? DataCadastro { get; set; }


        public IList<Anexos> AnexoList { get; set; }
    }

    public class Endereco
    {

        public string Logradouro
        { get; set; }


        public string Numero
        { get; set; }


        public string Complemento
        { get; set; }


        public string Bairro
        { get; set; }


        public string Cidade
        { get; set; }


        public string Cep
        { get; set; }


        public string UF
        { get; set; }

        public string CodPais
        { get; set; }

        public string Pais { get; set; }
    }

    public class InformacoesBancarias
    {

        public uint? Banco
        { get; set; }

        public uint? Agencia
        { get; set; }

        public string ContaCorrente
        { get; set; }

    }

    public class Credito
    {

        public decimal Limite
        { get; set; }

        public decimal Disponivel
        { get; set; }

        public decimal Concedidos
        { get; set; }

        public decimal EmAberto
        { get; set; }

        public DateTime? DataVencimento
        { get; set; }

    }

    [Serializable, DataContract]
    public class Praca
    {

        #region Fields
        private Regiao regiao;
        #endregion


        public string Codigo
        { get; set; }

        public string Descricao
        { get; set; }


        public Regiao Regiao
        {
            get
            {
                if (regiao == null)
                    regiao = new Regiao();
                return regiao;
            }
            set { regiao = value; }

        }


        public string CodigoCidade { get; set; }

    }

    public class Regiao
    {

        public string Codigo
        { get; set; }

        public string Descricao
        { get; set; }


        public decimal PercFreteTerceiros
        { get; set; }


        public decimal PercFreteEspecial
        { get; set; }


        public decimal ValorFreteKgVenda
        { get; set; }


        public decimal PercFrete
        { get; set; }

        public bool ZonaFranca
        { get; set; }

        public bool Marcado { get; set; }
    }

    public class Anexos
    {
        public string Cgc { get; set; }

        public string CodigoTipo { get; set; }

        public string Tipo { get; set; }

        public string Hash { get; set; }

        public string Link { get; set; }

        public long CodUsuario { get; set; }
    }

    public class RamoAtividade
    {

        public string Codigo
        { get; set; }

        public string Descricao
        { get; set; }

        public decimal PercDesconto
        { get; set; }


        public Cnae Cnae { get; set; }

    }
    public class Cnae
    {

        public string Codigo { get; set; }


        public string Descricao { get; set; }


        public decimal PercCargaTributariaMedia { get; set; }


        public decimal Mva { get; set; }
    }

}

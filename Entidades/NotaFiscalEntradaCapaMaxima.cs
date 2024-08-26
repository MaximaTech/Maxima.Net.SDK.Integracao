using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a capa da nota fiscal de entrada.
    /// </summary>
    public class NotaFiscalEntradaCapaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Nfent";
        internal const string Tabela = "ERP_MXSNFENT";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Sequencial único, que não se repete e que seja um identificador da nota de devolução(Sequence, ROWID, ID e etc).
        /// </summary>
        [JsonProperty("Numtransent")]
        [PropriedadePK(1)]
        public string NumeroTransacao { get; set; }

        /// <summary>
        /// Código da conta contábil
        /// </summary>
        [JsonProperty("Codcont")]
        [PropriedadePK(2)]
        public string CodigoContaContabil { get; set; }

        /// <summary>
        /// Código do Motivo da Devolução. Se não existir enviar 1. Com preenchimento obrigatório.
        /// </summary>
        /// <value> Código do motivo de devolução referente ao cadastro de motivo de devolução. </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(MotivoDevolucaoMaxima.VersaoAPI, MotivoDevolucaoMaxima.EndPoint, MotivoDevolucaoMaxima.Tabela, typeof(MotivoDevolucaoMaxima))]
        [JsonProperty("Coddevol")]
        public string CodigoMotivoDevolucao { get; set; }

        /// <summary>
        /// Código da filial da nota fiscal de entrada. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código fiscal com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codfiscal")]
        public int? CodigoFiscal { get; set; }

        /// <summary>
        /// Data de entrada da nota fiscal, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtent")]
        public DateTime? DataEntrada { get; set; }

        /// <summary>
        /// Espécie da NF. Ex: NF. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(2)]
        [JsonProperty("Especie")]
        public string Especie { get; set; }

        /// <summary>
        /// Série da nota fiscal de entrada. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(3)]
        [JsonProperty("Serie")]
        public string Serie { get; set; }

        /// <summary>
        /// Define o número da nota fiscal de entrada.
        /// </summary>
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numnota")]
        public int? NumeroNota { get; set; }

        /// <summary>
        /// Observação. Se não existir enviar nulo/vazio.
        /// </summary>
        [JsonProperty("Obs")]
        public string Observacao { get; set; }

        /// <summary>
        /// Código/Matrícula do Motorista, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Funcionários.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(EmpregadoMaxima.VersaoAPI, EmpregadoMaxima.EndPoint, EmpregadoMaxima.Tabela, typeof(EmpregadoMaxima))]
        [JsonProperty("Codmotoristadevol")]
        public string CodigoMotorista { get; set; }

        /// <summary>
        ///  Código do vendedor emissor da NF de Saída. Com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Vendedor.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusurdevol")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Situação da Nfe/Sefaz. Se não existir enviar 0. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Situacaonfe")]
        public int? SituacaoNFe { get; set; }

        /// <summary>
        /// Estado, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Estados.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(EstadoMaxima.VersaoAPI, EstadoMaxima.EndPoint, EstadoMaxima.Tabela, typeof(EstadoMaxima))]
        [TamanhoMaximo(2)]
        [JsonProperty("Uf")]
        public string UF { get; set; }

        /// <summary>
        /// Peso. Se não existir enviar 0. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Totpeso")]
        public decimal? TotalPeso { get; set; }

        /// <summary>
        /// Valor do frete. Se não existir enviar 0. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlfrete")]
        public decimal? ValorFrete { get; set; }

        /// <summary>
        /// Valor da situação tributária. Se não existir enviar 0. Com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vlst")]
        public decimal? ValorSituacaoTributaria { get; set; }

        /// <summary>
        /// Indica por onde foi gerado a nota fiscal se pela empresa ou cliente. Com preenchimento obrigatório.
        /// </summary>
        /// <value>S – Sim (Gerado pela empresa) ou N – Não (Gerado pelo cliente)</value>
        [RangeString("S", "N")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Geranfdevcli")]
        public string GeradoPelaEmpresa { get; set; }

        /// <summary>
        /// Código do cliente da devolução. Com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de fornecedores.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codfornec")]
        public string CodigoFornecedor { get; set; }

        /// <summary>
        /// Tipo da nota fiscal
        /// </summary>
        /// <value> 6 – Devolução Normal, 7 – Dev. Simples Remessa, 8 – Dev.Simples Fatura, T – Dev.Troca </value>
        [RangeString("6", "7", "8", "T")]
        [JsonProperty("Tipodescarga")]
        public string TipoNota { get; set; }

    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena  os bancos cadastrados. No aplicativo será necessário para
    /// o vendedor apenas selecionar o banco, não sendo necessário ter detalhes da conta.
    /// </summary>
    public class ContaBancariaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ContasBancarias";
        internal const string Tabela = "MXSCONTASBANCARIAS";

        /// <summary>
        /// Código da conta bancária, com preenchimento obrigatório e limite de até 40 caracteres
        /// </summary>
        [TamanhoMaximo(40)]
        [PropriedadePK]
        [JsonProperty("Codconta")]
        public string CodigoContaBancaria { get; set; }

        /// <summary>
        /// Descrição da conta bancária, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        ///<value> O código referente ao Cadastro de bancos </value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codbanco")]
        [PropriedadeFK(BancoMaxima.VersaoAPI, BancoMaxima.EndPoint, BancoMaxima.Tabela, typeof(BancoMaxima))]
        public string CodigoBanco { get; set; }

        /// <summary>
        /// Agência bancária, com preenchimento obrigatório e limite de até 40 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(40)]
        [JsonProperty("Ag")]
        public string Agencia { get; set; }

        /// <summary>
        /// Número da Conta bancária, com preenchimento obrigatório e limite de até 40 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(40)]
        [JsonProperty("Numconta")]
        public string NumeroDaConta { get; set; }

        /// <summary>
        /// Código da filial da conta bancária. O preenchimento é obrigatório. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Descrição da conta bancária, com preenchimento obrigatório e limite de até 60 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(60)]
        [JsonProperty("Descricao")]
        public string Descricao { get; set; }

        /// <summary>
        /// Tipo da conta bancária, com preenchimento obrigatório.
        /// </summary>
        /// <value> A – Aplicacao, C – Conta Corrente, D – Adiantamento,
        /// E – Emprestimo, G – Garantida, M – Comissões, O – Outros,
        /// S – Sócios, X – Caixa/Tesouraria, Z – Caixa(PDV) </value>
        [RangeString("A", "C", "D", "E", "G", "M", "O", "S", "X", "Z")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Tipo")]
        public string Tipo { get; set; }
    }
}

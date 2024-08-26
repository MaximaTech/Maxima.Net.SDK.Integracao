using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as comissões progressivas por produto e vendedor
    /// </summary>
    public class ComissaoVendedorMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ComissoesUsuarios";
        internal const string Tabela = "MXSCOMISSAOUSUR";

        /// <summary>
        /// Define o código da faixa de comissão com preenchimento obrigatório.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codfaixa")]
        [PropriedadePK]
        public string CodigoFaixa { get; set; }

        /// <summary>
        /// Código do vendedor do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Define o percentual inicial de desconto com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Percdescini")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999999999.999999)]
        public double? PercentualDescontoInicial { get; set; }

        /// <summary>
        /// Define o percentual final de desconto com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Percdescfim")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999999999.999999)]
        public double? PercentualDescontoFinal { get; set; }

        /// <summary>
        /// Define o percentual de comissão, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Percom")]
        public double? PercentualComissao { get; set; }

        /// <summary>
        /// Define o código do produto, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produto.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define o código do departamento.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Departamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codepto")]
        [PropriedadeFK(DepartamentoMaxima.VersaoAPI, DepartamentoMaxima.EndPoint, DepartamentoMaxima.Tabela, typeof(DepartamentoMaxima))]
        public string CodigoDepartamento { get; set; }

        /// <summary>
        /// Define o código da seção.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Seções.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codsec")]
        [PropriedadeFK(SecaoMaxima.VersaoAPI, SecaoMaxima.EndPoint, SecaoMaxima.Tabela, typeof(SecaoMaxima))]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Define o tipo da comissão com preenchimento obrigatório.
        /// </summary>
        /// <value>Tipo de comissão (P – Produto, D – Departamento, S - Sessão)</value>
        [JsonProperty("Tipocomissao")]
        [CampoObrigatorioAoInserir]
        [RangeString("P", "D", "S")]
        public string TipoComissao { get; set; }

        /// <summary>
        /// Define se é pra fixar RP
        /// </summary>
        [JsonProperty("Tipo")]
        [TamanhoMaximo(2)]
        public string FixarRP { get; set; }

    }
}

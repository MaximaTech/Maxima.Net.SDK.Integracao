using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    public class ComissaoRegiaoMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ComissoesRegioes";
        internal const string Tabela = "MXSCOMISSAOREGIAO";

        /// <summary>
        /// Define o código da faixa de comissão com preenchimento obrigatório.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codfaixa")]
        [PropriedadePK]
        public string CodigoFaixa { get; set; }

        /// <summary>
        /// Define o percentual inicial de desconto com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Perdescini")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        public double? PercentualDescontoInicial { get; set; }

        /// <summary>
        /// Define o percentual final de desconto com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Perdescfim")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        public double? PercentualDescontoFinal { get; set; }

        /// <summary>
        /// Define o percentual de comissão.
        /// </summary>    
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percom")]
        public double? PercentualComissao { get; set; }

        /// <summary>
        /// Define a data inicial com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Dtinicio")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataInicio { get; set; }

        /// <summary>
        /// Define a data final com preenchimento obrigatório.
        /// </summary>
        [JsonProperty("Dtfim")]
        [CampoObrigatorioAoInserir]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Define o percentual de comissão externa.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percomext")]
        public double? PercentualComissaoExterna { get; set; }

        /// <summary>
        /// Define o percentual de comissão interna.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percomint")]
        public double? PercentualComissaoInterna { get; set; }

        /// <summary>
        /// Define o número da região.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }

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
        /// Define o código do produto.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produto.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Define o tipo da comissão com preenchimento obrigatório.
        /// </summary>
        /// <value>Tipo de comissão (P – Produto, R – Região, RS – Região Seção, RD – Região Departamento)</value>
        [JsonProperty("Tipo")]
        [CampoObrigatorioAoInserir]
        [RangeString("P", "R", "RS", "RD")]
        public string TipoComissao { get; set; }

        /// <summary>
        /// Define o código do filial.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filial.</value>    
        [TamanhoMaximo(20)]
        [JsonProperty("Codfilial")]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define o tipo de vendedor com preenchimento obrigatório.
        /// </summary>
        /// <value>Tipo de vendedor (I – Interno, E – Externo, R – Representante, P – Profissional)</value>
        [RangeString("I", "E", "R", "P")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Tipovendedor")]
        public string TipoVendedor { get; set; }

    }
}

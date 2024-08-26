using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as informações dos produtos
    /// </summary>
    public class ProdutoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Produtos";
        internal const string Tabela = "MXSPRODUT";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        [PropriedadePK]
        [JsonProperty("Codprod")]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Peso liquido do produto com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Pesoliq")]
        public double? PesoLiquido { get; set; }

        /// <summary>
        /// Peso bruto do produto com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.999999)]
        [JsonProperty("Pesobruto")]
        public double? PesoBruto { get; set; }

        /// <summary>
        /// Quantidade unitária do produto com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Qtunit")]
        public double? QtdUnitaria { get; set; }

        ///<summary>
        ///Define a porcentagem de comissão para o representante.
        ///</summary>
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Pcomrep1")]
        public double? ComissaoRepresentante { get; set; }

        ///<summary>
        ///Define a porcentagem de comissão para o vendedor.
        ///</summary>
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Pcomext1")]
        public double? ComissaoVendedor { get; set; }

        /// <summary>
        /// Quantidade unitária p/ caixa com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999.99)]
        [JsonProperty("Qtunitcx")]
        public double? QtdUnitariaCaixa { get; set; }

        [JsonProperty("Dtexclusao")]
        public DateTime? DataExclusao { get; set; }

        ///<summary>
        ///Indica qual é o múltiplo do produto, não poderá realizar operações se a quantidade não for múltipla ao informado nesse campo.
        ///</summary>
        [CampoObrigatorioAoInserir]
        public decimal? Multiplo { get; set; }

        ///<summary>
        ///Data Vencimento. Obrigatório se maxCatálogo.
        ///</summary>
        [JsonProperty("Dtvenc")]
        public DateTime? DataVencimento { get; set; }

        ///<summary>
        ///Percentual de bonificação para venda.
        ///</summary>
        [JsonProperty("Percbonificvenda")]
        [ValorEntre(0, 999.99)]
        public double? PercBonificacaoVenda { get; set; }

        ///<summary>
        ///Percentual máximo de acréscimo
        ///</summary>
        [JsonProperty("Peracrescmax")]
        public decimal? PercAcrescimoMaximo { get; set; }

        [JsonProperty("Dtcadastro")]
        public DateTime DataCadastro { get; set; }

        ///<summary>
        ///Indica o volume do produto m³.
        ///</summary>
        public decimal? Volume { get; set; }

        [ValorEntre(0, 9999.999999)]
        public double? Altura { get; set; }

        /// <summary>
        /// [Propriedade interna] Indica se deve ou não enviar para o Força de Vendas.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [JsonProperty("Enviarforcavendas")]
        [RangeString("S", "N")]
        public string Enviarforcavendas { get; set; }

        /// <summary>
        /// Restrição de transporte de produto
        /// </summary>
        /// <value>
        /// S - Inflamáveis, N - Normal, R - Refrigerado, C - Congelados
        /// </value>
        [JsonProperty("Restricaotransp")]
        [RangeString("S", "N", "R", "C")]
        public string RestricaoTransporte { get; set; }

        /// <summary>
        /// Código do departamento do produto com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// Código usado deve estar no Cadastro de Departamentos
        /// </value>
        [PropriedadeFK(DepartamentoMaxima.VersaoAPI, DepartamentoMaxima.EndPoint, DepartamentoMaxima.Tabela, typeof(DepartamentoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codepto")]
        public string CodigoDepartamento { get; set; }

        [PropriedadeFK(SecaoMaxima.VersaoAPI, SecaoMaxima.EndPoint, SecaoMaxima.Tabela, typeof(SecaoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsec")]
        public string CodigoSecao { get; set; }

        /// <summary>
        /// Código do fornecedor do produto. O preenchimento é obrigatório e com limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>
        /// Esse código usado deve estar no Cadastro de Fornecedores.
        /// </value>
        [PropriedadeFK(FornecedorMaxima.VersaoAPI, FornecedorMaxima.EndPoint, FornecedorMaxima.Tabela, typeof(FornecedorMaxima))]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codfornec")]
        public string CodigoFornecedor { get; set; }

        ///<summary>
        ///Define se o produto é master (mesmo código de produto) ou filho (código diferente)
        ///</summary>
        [JsonProperty("Codprodprinc")]
        public string CodigoProdutoPrincipal { get; set; }

        /// <summary>
        /// Categoria do produto.
        /// </summary>
        /// <value>Código referente ao cadastro <see cref="CategoriaMaxima"/></value>
        [PropriedadeFK(CategoriaMaxima.VersaoAPI, CategoriaMaxima.EndPoint, CategoriaMaxima.Tabela, typeof(CategoriaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codcategoria")]
        public string CodigoCategoria { get; set; }

        /// <summary>
        /// Marca do produto
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="MarcaMaxima"/></value>
        [PropriedadeFK(MarcaMaxima.VersaoAPI, MarcaMaxima.EndPoint, MarcaMaxima.Tabela, typeof(MarcaMaxima))]
        [JsonProperty("Codmarca")]
        public string CodigoMarca { get; set; }

        [JsonProperty("Codlinhaprod")]
        public string CodigoLinhaProduto { get; set; }

        ///<summary>
        ///Indica qual é o código de barras do produto na unidade de venda, no caso de venda por embalagem se torna obrigatório.
        ///</summary>
        [JsonProperty("Codauxiliar")]
        public string CodigoDeBarras { get; set; }

        /// <summary>
        /// Sub categoria do produto.
        /// </summary>
        /// <value>Código referente ao cadastro <see cref="SubCategoriaMaxima"/></value>
        [PropriedadeFK(SubCategoriaMaxima.VersaoAPI, SubCategoriaMaxima.EndPoint, SubCategoriaMaxima.Tabela, typeof(SubCategoriaMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codsubcategoria")]
        public string CodigoSubCategoria { get; set; }

        /// <summary>
        /// Descrição do produto com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Descricao { get; set; }

        ///<summary>
        ///Unidade da embalagem de venda do produto (Unidadede Venda)
        ///</summary>
        public string Embalagem { get; set; }

        ///<summary>
        ///Unidade de venda (controle do estoque). O preenchimento é obrigatório.
        ///</summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        public string Unidade { get; set; }

        [JsonProperty("Obs")]
        public string Observacao { get; set; }

        [JsonProperty("Revenda")]
        public string Revenda { get; set; }

        [JsonProperty("Codfab")]
        public string CodigoFabrica { get; set; }

        /// <summary>
        /// Código da filial do produto. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        ///<summary>
        ///Tipo de mercadoria. Preenchimento é obrigatório.
        ///</summary>
        ///<value>L – Liberado, PA – Produto Acabado, CB – Cesta Básica e MP – Matéria Prima</value>
        [RangeString("L", "PA", "CB", "MP")]
        [JsonProperty("Tipomerc")]
        [CampoObrigatorioAoInserir]
        public string TipoMercadoria { get; set; }

        /// <summary>
        /// Indica se o produto aceita venda fracionada. O preenchimento é obrigatório.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("S", "N")]
        [JsonProperty("Aceitavendafracao")]
        public string AceitavendaFracao { get; set; }

        [JsonProperty("Informacoestecnicas")]
        public string InformacoesTecnicas { get; set; }

        ///<summary>
        ///Define se o produto utiliza Comissão Padrão ou Comissão por Lucratividade.
        ///</summary>
        ///<value>'P' = padrão / 'P/L' = por lucratividade</value>
        [RangeString("P", "P/L")]
        [JsonProperty("Tipocomissao")]
        public string TipoComissao { get; set; }

        ///<summary>
        ///Indica se o produto é frio (FR) ou padrão (PA). O preenchimento é obrigatório.
        ///</summary>
        /// <value>
        /// FR (frio) ou PA (padrão)
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString("FR", "PA")]
        [JsonProperty("Tipoestoque")]
        public string TipoEstoque { get; set; }

        ///<summary>
        ///Unidade de compra junto ao fornecedor
        ///</summary>
        [JsonProperty("Unidademaster")]
        public string UnidadeMaster { get; set; }

        [JsonProperty("Dadostecnicos")]
        public string DadosTecnicos { get; set; }

        ///<summary>
        ///Classificação fiscal/NCM. Obrigatório se Pronta Entrega
        ///</summary>
        [JsonProperty("Classificfiscal")]
        public string Ncm { get; set; }

        [JsonProperty("Descricao2")]
        public string DescricaoSecundaria { get; set; }

        ///<summary>
        /// Código do cliente e com limite de até 50 caracteres.
        /// Atenção: O preenchimento deste campo é obrigatório caso utilize o Logística.
        ///</summary>
        ///<value>CodigoCliente referente ao Cadastro de Clientes</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Id_cliente")]
        public string CodigoCliente { get; set; }
    }
}

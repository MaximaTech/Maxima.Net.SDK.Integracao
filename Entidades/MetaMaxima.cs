using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Maxima.Net.SDK.Integracao.Utils;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena as metas mensais pelos níveis (C – Cliente; D – Departamento; S – Seção; P – Produto; F – Fornecedor; A – Categoria; FP – Fornecedor Principal; M – Mensal Geral). 
    /// </summary>
    public class MetaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Metas";
        internal const string Tabela = "ERP_MXSMETA";

        /// <summary> 
        /// Identificador da meta, com preenchimento obrigatório.
        /// </summary>
        [ValorEntre(typeof(decimal), "0", "99999999999999999999")]
        [PropriedadePK(1)]
        [JsonProperty("Codmeta")]
        public decimal? CodigoMeta { get; set; }

        /// <summary>
        /// Define o código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [PropriedadePK(2)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Tipo de meta. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>C – Cliente; D – Departamento; S – Seção; P – Produto; F – Fornecedor; A – Categoria; FP – Fornecedor Principal; M – Mensal Geral</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(3)]
        [RangeString("C", "D", "S", "P", "F", "A", "FP", "M")]
        [JsonProperty("Tipometa")]
        public string TipoMeta { get; set; }

        /// <summary>
        /// Código da filial com preenchimento obrigatório.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="FilialMaxima"/>.</value>
        [PropriedadePK(4)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Identificador do registro vinculado ao tipo de meta, com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(5)]
        [TamanhoMaximo(50)]
        [JsonProperty("Codigo")]
        public string Codigo { get; set; }

        /// <summary>
        /// Data inicial da meta mensal, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datainicial")]
        public DateTime? DataInicial { get; set; }

        /// <summary>
        /// Data final da meta mensal, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datafinal")]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Valor previsto de venda (Meta financeira de venda)
        /// </summary>
        [JsonProperty("Vlvendaprev")]
        public decimal? ValorPrevistoVenda { get; set; }

        /// <summary>
        /// Quantidade previsto de venda (Meta quantitativa de venda)
        /// </summary>
        [JsonProperty("Qtvendaprev")]
        public decimal? QuantidadePrevistaVenda { get; set; }

        /// <summary>
        /// Mix previsto de produtos para venda (Meta quantitativa do mix)
        /// </summary>
        [JsonProperty("Mixprev")]
        public decimal? MixProdutoPrevistoVenda { get; set; }

        /// <summary>
        /// Quantidade de clientes positivados (Meta quantitativa de clientes positivados)
        /// </summary>
        [JsonProperty("Cliposprev")]
        public decimal? QuantidadeClientePositivado { get; set; }

        /// <summary>
        /// Peso previsto de venda (Meta de peso)
        /// </summary>
        [JsonProperty("Qtpesoprev")]
        public decimal? PesoPrevistoVenda { get; set; }

        /// <summary>
        /// Quantidade de pedidos previstos
        /// </summary>
        [JsonProperty("Qtdepedidosprev")]
        public decimal? QuantidadePedidosPrevisto { get; set; }

        /// <summary>
        /// Volume previsto de venda (Meta de volume)
        /// </summary>
        [JsonProperty("Volumeprev")]
        public decimal? VolumePrevistoVenda { get; set; }
    }
}

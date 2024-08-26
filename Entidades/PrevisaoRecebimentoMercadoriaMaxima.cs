using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena os dados de Previsão de Recebimento de Mercadoria. 
    /// </summary>
    public class PrevisaoRecebimentoMercadoriaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrevisaoRecebimentoMercadoria";
        internal const string Tabela = "MXSESTPEND";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Define o código do produto, com preenchimento obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produto.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [JsonProperty("Codprod")]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Data da previsão de recebimento de mercadoria, com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(2)]
        [JsonProperty("Dtprevent")]
        public DateTime? DataPrevisao { get; set; }

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Quantidade pendente, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtpendente")]
        public decimal? QuantidadePendente { get; set; }

        /// <summary>
        /// Situação, com preenchimento obrigatório.
        /// </summary>
        /// <value>PN – Produto normal</value>
        [RangeString("PN")]
        [PropriedadePK(4)]
        [JsonProperty("Situacao")]
        public string Situacao { get; set; }        
    }
}

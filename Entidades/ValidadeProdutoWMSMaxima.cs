using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena a validade dos produtos do WMS. 
    /// </summary>
    public class ValidadeProdutoWMSMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "ValidadesWms";
        internal const string Tabela = "MXSVALIDADEWMS";

        /// <summary>
        /// Código da filial do pedido. O preenchimento é obrigatório. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do produto do pedido. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        [PropriedadePK(2)]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Data de validade, com preenchimento obrigatório.
        /// </summary>
        [PropriedadePK(3)]
        [JsonProperty("Data")]
        public DateTime? DataValidade { get; set; }

        /// <summary>
        /// Quantidade disponível, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Qtde")]
        public Decimal? QuantidadeDisponivel { get; set; }
    }
}

using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena lotes de produtos.
    /// </summary>
    public class LoteMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Lotes";
        internal const string Tabela = "MXSLOTE";

        /// <summary>
        /// Define o código do produto. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadePK(1)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprod")]
        public string Codprod { get; set; }

        /// <summary>
        /// Define o número do lote.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK(2)]
        [JsonProperty("Numlote")]
        public string NumeroLote { get; set; }

        /// <summary>
        /// Define o código da filial. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no cadastro de Filiais.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [PropriedadePK(3)]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define a quantiade do produto.
        /// </summary>
        [JsonProperty("Qt")]
        [ValorEntre(0, 99999999999999.99999999)]
        [CampoObrigatorioAoInserir]
        public double? Quantidade { get; set; }

        /// <summary>
        /// Define a data de fabricação do lote.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datafabricacao")]
        public DateTime? DataFabricacao { get; set; }

        /// <summary>
        /// Define a data de validade do lote.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtvalidade")]
        public DateTime? DataValidade { get; set; }

    }
}
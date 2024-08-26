using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para armazenar os planos de pagamentos por produto.
    /// </summary>
    public class PlanoPagamentoPorProdutoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PlanosPagamentosProdutos";
        internal const string Tabela = "MXSPLPAGPRODUT";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Código do plano de pagamento com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="PlanoPagamentoMaxima"/>.</value>
        [PropriedadePK(3)]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código do Filial com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="FilialMaxima"/>.</value>
        [PropriedadePK(1)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [TamanhoMaximo(50)]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Define o código do produto com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do produto referente ao cadastro de produto.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codprod")]
        [PropriedadePK(2)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        public string CodigoProduto { get; set; }

        /// <summary>
        /// Data inicial da relação entre plano de pagamento e produto com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtinicial")]
        public DateTime? DataInicial { get; set; }

        /// <summary>
        /// Data final da relação entre plano de pagamento e produto com preenchimento obrigatório
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Dtfinal")]
        public DateTime? DataFinal { get; set; }


    }
}

using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;
using System;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o preço fixo de item cesta.
    /// </summary>
    public class PrecoCestaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "PrecosCestasCapas";
        internal const string Tabela = "MXSPRECOCESTAC";

        /// <summary>
        /// Código do preço da cesta, com preenchimento obrigatório e limite de até 50 caracteres
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codprecocesta")]
        public string CodigoPrecoCesta { get; set; }

        /// <summary>
        /// Código do cliente. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Clientes.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        [JsonProperty("Codcli")]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código da filial.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Filiais.</value>
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Código do plano de pagamento do pedido. Com limite de até 50 caracteres. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Plano de Pagamento.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codplpag")]
        [PropriedadeFK(PlanoPagamentoMaxima.VersaoAPI, PlanoPagamentoMaxima.EndPoint, PlanoPagamentoMaxima.Tabela, typeof(PlanoPagamentoMaxima))]
        public string CodigoPlanoDePagamento { get; set; }

        /// <summary>
        /// Código do produto. Com limite de até 50 caracteres. 
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Produtos.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(ProdutoMaxima.VersaoAPI, ProdutoMaxima.EndPoint, ProdutoMaxima.Tabela, typeof(ProdutoMaxima))]
        [JsonProperty("Codprodacab")]
        public string CodigoProdutoAcabado { get; set; }

        /// <summary>
        /// Data início de vigência.
        /// </summary>
        [JsonProperty("Dtinicio")]
        public DateTime? DataInicial { get; set; }

        /// <summary>
        /// Data final de vigência.
        /// </summary>
        [JsonProperty("Dtfim")]
        public DateTime? DataFinal { get; set; }

        /// <summary>
        /// Define o número da região, com limite de até 50 caracteres.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Regiões.</value>
        [TamanhoMaximo(50)]
        [JsonProperty("Numregiao")]
        [PropriedadeFK(RegiaoMaxima.VersaoAPI, RegiaoMaxima.EndPoint, RegiaoMaxima.Tabela, typeof(RegiaoMaxima))]
        public string CodigoRegiao { get; set; }

        /// <summary>
        /// Utiliza preço fixo de rede.Recebe 'N' ou 'S'.
        /// </summary>
        /// <value>S - Sim, N - Não</value>
        [RangeString("S", "N")]
        [JsonProperty("Utilizaprecofixorede")]
        public string UtilizaPrecoFixoDeRede { get; set; }
    }
}

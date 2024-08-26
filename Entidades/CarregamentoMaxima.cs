using System;
using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{

    /// <summary>
    /// Entidade que armazena um carregamento.
    /// </summary>
    public class CarregamentoMaxima
    {
        /// <summary>
        /// Número do carregamento/Ordem de carga. Sequência Única, que é um agrupador de notas.
        /// O limite máximo de caracteres é 50.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Numcar")]
        public string NumeroCarregamento { get; set; }

        /// <summary>
        /// Origem do carregamento com preenchimento obrigatório e limite de até 3 caracteres.
        /// </summary>
        /// <value>
        /// Os valores aceitos são:
        /// ERP, PRO (Pronta Entega) ou ROT (maxRoteirizador)
        /// </value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "ERP", "PRO", "ROT" })]
        [JsonProperty("Origem_car")]
        public string OrigemCarregamento { get; set; }

        /// <summary>
        /// Data de Saída da Nota Fiscal.
        /// </summary>
        [JsonProperty("Dtsaida")]
        public DateTime? DataSaida { get; set; }

        /// <summary>
        /// Data de fechamento do carregamento, logo após acerto de carga é necessário atualização deste campo com a data do acerto.
        /// </summary>
        [JsonProperty("Dtfecha")]
        public DateTime? DataFechamento { get; set; }

        /// <summary>
        /// Data de montagem do carregamento, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Datamon")]
        public DateTime? DataMontagem { get; set; }

        /// <summary>
        /// Quantidade de NF’s do Carregamento/Ordem de Carga, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, int.MaxValue)]
        [JsonProperty("Numnotas")]
        public int? QuantidadeNotas { get; set; }

        /// <summary>
        /// Data saida veiculo.
        /// </summary>
        [JsonProperty("Dtsaidaveiculo")]
        public DateTime? DataSaidaVeiculo { get; set; }

        /// <summary>
        /// Total do Peso em Kg, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 99999999.99)]
        [JsonProperty("Totpeso")]
        public double? TotalPeso { get; set; }

        /// <summary>
        /// Total do Volume em m3, com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, double.MaxValue)]
        [JsonProperty("Totvolume")]
        public double? TotalVolume { get; set; }

        /// <summary>
        /// Valor total das notas fiscais no carregamento.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Vltotal")]
        public decimal? ValorTotal { get; set; }

        /// <summary>
        /// Data cancelamento do carregamento.
        /// </summary>
        [JsonProperty("Dt_cancel")]
        public DateTime? DataCancelamento { get; set; }

        /// <summary>
        /// Hora que foi montado a carga.
        /// </summary>
        [ValorEntre(0, 99)]
        [JsonProperty("Horamon")]
        public int? HoraMontadoCarga { get; set; }

        /// <summary>
        /// Minuto que foi montado a carga.
        /// </summary>
        [JsonProperty("Minutomon")]
        [ValorEntre(0, 99)]
        public int? MinutoMontadoCarga { get; set; }

        /// <summary>
        /// Segundo que foi montado a carga.
        /// </summary>
        [ValorEntre(0, 99)]
        [JsonProperty("Segundomon")]
        public int? SegundoMontadoCarga { get; set; }

        /// <summary>
        /// Total de itens do carregamento.
        /// </summary>
        [ValorEntre(0, 999999)]
        [JsonProperty("Qtitens")]
        public int? QuantidadeItens { get; set; }

        /// <summary>
        /// Data de Faturamento do Carregamento/Ordem de Carga.
        /// </summary>
        [JsonProperty("Dtfat")]
        public DateTime? DataFaturamento { get; set; }

        /// <summary>
        /// Destino da carga.
        /// </summary>
        [TamanhoMaximo(20)]
        public string Destino { get; set; }

        /// <summary>
        /// Código do veículo da carga. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Código veículo referente ao cadastro de veículos.</value>
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(VeiculoMaxima.VersaoAPI, VeiculoMaxima.EndPoint, VeiculoMaxima.Tabela, typeof(VeiculoMaxima))]
        [JsonProperty("Codveiculo")]
        public string CodigoVeiculo { get; set; }

        /// <summary>
        /// Código do funcionário motorista da carga. O preenchimento é obrigatório.
        /// </summary>
        /// <value>Esse código usado deve estar no Cadastro de Funcionários.</value>
        [PropriedadeFK(EmpregadoMaxima.VersaoAPI, EmpregadoMaxima.EndPoint, EmpregadoMaxima.Tabela, typeof(EmpregadoMaxima))]
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Codmotorista")]
        public string CodigoMotorista { get; set; }

        /// <summary>
        /// Observação do destino da carga.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(80)]
        [JsonProperty("Obsdestino")]
        public string ObservacaDestino { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Observacao geral da carga.
        /// </summary>
        /// <value></value>
        [TamanhoMaximo(4000)]
        public string Observacao { get; set; }

        /// <summary>
        /// Todos os pedidos referente ao carregamento
        /// </summary>
        /// <value>Array de longs</value>
        [JsonProperty("Pedidos",NullValueHandling=NullValueHandling.Ignore)]
        public List<long> PedidosCarregamento { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Carregamentos";
        internal const string Tabela = "ERP_MXSCARREG";
    }
}

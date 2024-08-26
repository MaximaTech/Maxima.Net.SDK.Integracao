using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena um veículo.
    /// </summary>
    public class VeiculoMaxima
    {
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codveiculo")]
        public string CodigoVeiculo { get; set; }

        /// <summary>
        /// Quantidade de paletes.
        /// </summary>
        [ValorEntre(0, 9999)]
        [JsonProperty("Qtpalete")]
        public int? QuantidadePalete { get; set; }

        /// <summary>
        /// Capacidade de volume do veículo. O preenchimento é obrigatório.
        /// </summary>
        [ValorEntre(0, 999999.9999)]
        [CampoObrigatorioAoInserir]
        public double? Volume { get; set; }

        /// <summary>
        /// Capacidade de peso do veículo em kg. O preenchimento é obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 99999999.99)]
        [JsonProperty("Pesocargakg")]
        public double? PesoCarga { get; set; }

        /// <summary>
        /// Altura do veículo.
        /// </summary>
        [ValorEntre(0, 9999999.999)]
        public double? Altura { get; set; }

        /// <summary>
        /// Largura do veículo.
        /// </summary>
        [ValorEntre(0, 9999999.999)]
        public double? Largura { get; set; }

        /// <summary>
        /// Comprimento do veículo.
        /// </summary>
        [ValorEntre(0, 9999999.999)]
        public double? Comprimento { get; set; }

        /// <summary>
        /// Situação do veículo.  O preenchimento é obrigatório.
        /// </summary>
        /// <value>V – Viagem, O – Oficina, B – Bloqueado, L – Livre ou I – Inativo</value>
        [RangeString("V", "O", "B", "L", "I")]
        [CampoObrigatorioAoInserir]
        public string Situacao { get; set; }

        /// <summary>
        /// Tipo Veículo
        /// </summary>
        /// <value>L – Leve, M – Médio, P – Pesado, E – Extra Pesado</value>
        [RangeString("L", "M", "P", "E")]
        public string Tipoveiculo { get; set; }

        /// <summary>
        /// Define se o veículo e próprio.
        /// </summary>
        /// <value>S – Sim ou N – Não</value>
        [RangeString("S", "N")]
        public string Proprio { get; set; }

        /// <summary>
        /// Define se o veículo e rastreado.
        /// </summary>
        /// <value>S – Sim ou N – Não</value>
        [RangeString("S", "N")]
        public string Rastreado { get; set; }

        /// <summary>
        /// Define se a UF do veículo.
        /// </summary>
        [TamanhoMaximo(2)]
        [JsonProperty("Ufplacaveiculo")]
        public string UfPlacaVeiculo { get; set; }

        /// <summary>
        /// Define a placa do veículo.
        /// </summary>
        [TamanhoMaximo(10)]
        [CampoObrigatorioAoInserir]
        public string Placa { get; set; }

        /// <summary>
        /// Define a marca do veículo.
        /// </summary>
        [TamanhoMaximo(40)]
        public string Marca { get; set; }

        /// <summary>
        /// Define a filial a qual o veículo pertence.
        /// </summary>
        /// <value>Código filial referente ao cadastro da filial.</value>
        [JsonProperty("Codfilial")]
        [TamanhoMaximo(50)]
        [CampoObrigatorioAoInserir]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        public string CodigoFilial { get; set; }

        [TamanhoMaximo(50)]
        [JsonProperty("Obs")]
        public string Observacao { get; set; }

        /// <summary>
        /// Define a cidade da placa do veículo.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Cidadeplacaveiculo")]
        public string CidadePlacaVeiculo { get; set; }

        /// <summary>
        /// Define a descrição do veículo.
        /// </summary>
        [TamanhoMaximo(80)]
        [CampoObrigatorioAoInserir]
        public string Descricao { get; set; }

        /// <summary>
        ///Hash para controle de integração, usado para excluir uma entidade.
        ///</summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Veiculos";
        internal const string Tabela = "ERP_MXSVEICUL";

    }
}

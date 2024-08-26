using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar os profissionais e suas comissões.
    /// </summary>
    public class ComissaoProfissionalMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "NomesProfissionais";
        internal const string Tabela = "MXSNOMEPROFISSIONAL";

        /// <summary>
        /// Define o código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres.
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [PropriedadePK]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Nome do profissional com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public string Nome { get; set; }

        /// <summary>
        /// Percentual de comissão.
        /// </summary>
        [JsonProperty("Percent")]
        public decimal? PercentualComissao { get; set; }

        /// <summary>
        /// Percentual de comissão secundário.
        /// </summary>
        [JsonProperty("Percent2")]
        public decimal? PercentualComissao2 { get; set; }

        /// <summary>
        /// Tipo do vendedor vindo do cadastro do usuário de <see cref="VendedorMaxima"/>, precisando ser do tipo P.
        /// </summary>
        /// <value>
        /// P – Profissional
        /// </value>
        [RangeString("P")]
        [JsonProperty("Tipovend")]
        public string TipoVendedor { get; set; }

        /// <summary>
        /// Data de término da validação da comissão do profissional.
        /// </summary>
        [JsonProperty("Dttermino")]
        public DateTime? DataTermino { get; set; }
    }
}

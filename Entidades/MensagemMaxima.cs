using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade utilizada para troca de mensagens entre os vendedores externos com a equipe interna que utiliza o ERP.
    /// </summary>
    public class MensagemMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Mensagens";
        internal const string Tabela = "PCMXSMENSAGENS";

        /// <summary>
        /// Código da mensagem com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [PropriedadePK]
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codmensagem")]
        public string CodigoMensagem { get; set; }

        /// <summary>
        /// O texto da mensagem com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public string Mensagem { get; set; }

        /// <summary>
        /// Status da mensagem.
        /// </summary>
        /// <value>0 - Enviado, 1 - Lido</value>
        [CampoObrigatorioAoInserir]
        [RangeString("0", "1")]
        public string Status { get; set; }

        /// <summary>
        /// Código do usuário do ERP que cadastrou a mensagem com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codremetente")]
        public string CodigoRemetente { get; set; }

        /// <summary>
        /// Código do vendedor.
        /// </summary>
        /// <value>Código referente ao cadastro de <see cref="VendedorMaxima"/></value>
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Data de registro da mensagem.
        /// </summary>
        [CampoObrigatorioAoInserir]
        public DateTime? Data { get; set; }
    }
}

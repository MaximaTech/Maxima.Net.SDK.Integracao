using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade responsável por armazenar informações de marca de produtos, existe o vínculo obrigatório pelo cadastro de produto.
    /// </summary>
    public class MarcaMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Marcas";
        internal const string Tabela = "MXSMARCA";

        /// <summary>
        /// Código da marca, com preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("Codmarca")]
        public string CodigoMarca { get; set; }

        /// <summary>
        /// Descrição da marca com preenchimento obrigatório.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Marca")]
        public string Descricao { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }
    }
}

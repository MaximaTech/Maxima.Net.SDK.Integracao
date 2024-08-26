using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de TributosCapa para ser incluida na api máxima.
        /// </summary>
        /// <param name="tributosCapa">Representação de uma lista de tributosCapa</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<TributosCapaMaxima>> IncluirTributosCapa(List<TributosCapaMaxima> tributosCapa)
        {
            return _tributosCapaApi.Incluir(tributosCapa);
        }

        /// <summary>
        /// Envia uma lista de TributosCapa para ser alterada na api máxima, se a cidade não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tributosCapa">Representação de uma lista de tributosCapa</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TributosCapaMaxima>> AlterarTributosCapa(List<TributosCapaMaxima> tributosCapa)
        {
            return _tributosCapaApi.Alterar(tributosCapa);
        }

        /// <summary>
        /// Envia uma array de strings com ids de tributosCapa para ser excluida.
        /// </summary>
        /// <param name="tributosCapa">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTributosCapa(string[] tributosCapa)
        {
            return _tributosCapaApi.Deletar(tributosCapa);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Região para ser incluida na api máxima.
        /// </summary>
        /// <param name="regioes">Representação de uma lista de Região</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<Entidades.RegiaoMaxima>> IncluirRegioes(List<Entidades.RegiaoMaxima> regioes)
        {
            return _regiaoMaximaApi.Incluir(regioes);
        }

        /// <summary>
        /// Envia uma lista de Região para ser alterada na api máxima, se a região não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="regioes">Representação de uma lista de Região</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<Entidades.RegiaoMaxima>> AlterarRegioes(List<Entidades.RegiaoMaxima> regioes)
        {
            return _regiaoMaximaApi.Alterar(regioes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Região para ser excluida.
        /// </summary>
        /// <param name="regioes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRegioes(string[] regioes)
        {
            return _regiaoMaximaApi.Deletar(regioes);
        }
    }
}

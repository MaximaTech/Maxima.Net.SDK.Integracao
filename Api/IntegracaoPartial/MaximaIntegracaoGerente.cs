using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="GerenteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="gerentes">Representação de uma lista de <see cref="GerenteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<GerenteMaxima>> IncluirGerentes(List<GerenteMaxima> gerentes)
        {
            return _gerenteMaximaApi.Incluir(gerentes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="GerenteMaxima"/> para ser alterada na api máxima, se a <see cref="GerenteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="gerentes">Representação de uma lista de <see cref="GerenteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<GerenteMaxima>> AlterarGerentes(List<GerenteMaxima> gerentes)
        {
            return _gerenteMaximaApi.Alterar(gerentes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="GerenteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="gerentes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarGerentes(string[] gerentes)
        {
            return _gerenteMaximaApi.Deletar(gerentes);
        }
    }
}

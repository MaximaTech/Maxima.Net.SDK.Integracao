using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Lotes para ser incluida na api máxima.
        /// </summary>
        /// <param name="lotes">Representação de uma lista de Lotes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<LoteMaxima>> IncluirLotes(List<LoteMaxima> lotes)
        {
            return _loteMaximaApi.Incluir(lotes);
        }

        /// <summary>
        /// Envia uma lista de Lotes para ser alterada na api máxima, se o Lote não existir no Banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="lotes">Representação de uma lista de Lotes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<LoteMaxima>> AlterarLotes(List<LoteMaxima> lotes)
        {
            return _loteMaximaApi.Alterar(lotes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Lotes para ser excluida.
        /// </summary>
        /// <param name="lotes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarLotes(string[] lotes)
        {
            return _loteMaximaApi.Deletar(lotes);
        }
    }
}

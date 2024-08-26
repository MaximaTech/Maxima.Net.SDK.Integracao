using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Embalagens para ser incluida na api máxima.
        /// </summary>
        /// <param name="embalagens">Representação de uma lista de Embalagens</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EmbalagemMaxima>> IncluirEmbalagens(List<EmbalagemMaxima> embalagens)
        {
            return _embalagemMaximaApi.Incluir(embalagens);
        }

        /// <summary>
        /// Envia uma lista de Embalagens para ser alterada na api máxima, se a embalagem não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="embalagens">Representação de uma lista de Embalagens</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EmbalagemMaxima>> AlterarEmbalagens(List<EmbalagemMaxima> embalagens)
        {
            return _embalagemMaximaApi.Alterar(embalagens);
        }
        /// <summary>
        /// Envia uma array de strings com ids de Embalagem para ser excluida.
        /// </summary>
        /// <param name="embalagens">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEmbalagens(string[] embalagens)
        {
            return _embalagemMaximaApi.Deletar(embalagens);
        }
    }
}

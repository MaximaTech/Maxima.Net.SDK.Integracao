using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Previsão de Recebimento de Mercadorias para ser incluida na api máxima.
        /// </summary>
        /// <param name="recebimentoMercadoria">Representação de uma lista de Previsão de Recebimento de Mercadorias</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrevisaoRecebimentoMercadoriaMaxima>> IncluirPrevisaoRecebimentoMercadorias(List<PrevisaoRecebimentoMercadoriaMaxima> recebimentoMercadoria)
        {
            return _previsaoRecebimentoMercadoriaMaximaApi.Incluir(recebimentoMercadoria);
        }

        /// <summary>
        /// Envia uma lista de Previsão de Recebimento de Mercadorias para ser alterada na api máxima, se a previsão de recebimento não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="recebimentoMercadoria">Representação de uma lista de Previsão de Recebimento de Mercadorias</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrevisaoRecebimentoMercadoriaMaxima>> AlterarPrevisaoRecebimentoMercadorias(List<PrevisaoRecebimentoMercadoriaMaxima> recebimentoMercadoria)
        {
            return _previsaoRecebimentoMercadoriaMaximaApi.Alterar(recebimentoMercadoria);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Previsão de Recebimento de Mercadorias para ser excluida.
        /// </summary>
        /// <param name="recebimentoMercadoria">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrevisaoRecebimentoMercadorias(string[] recebimentoMercadoria)
        {
            return _previsaoRecebimentoMercadoriaMaximaApi.Deletar(recebimentoMercadoria);
        }
    }
}

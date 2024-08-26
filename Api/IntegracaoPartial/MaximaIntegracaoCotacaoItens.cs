using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cotação itens para ser incluida na api máxima.
        /// </summary>
        /// <param name="cotacaoItens">Representação de uma lista de Cotação itens</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotacaoItensMaxima>> IncluirCotacoesItens(List<CotacaoItensMaxima> cotacaoItens)
        {
            return _cotacaoItensMaximaApi.Incluir(cotacaoItens);
        }

        /// <summary>
        /// Envia uma lista de Cotação itens para ser alterada na api máxima, se a Cotação não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cotacaoItens">Representação de uma lista de Cotação itens</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CotacaoItensMaxima>> AlterarCotacoesItens(List<CotacaoItensMaxima> cotacaoItens)
        {
            return _cotacaoItensMaximaApi.Alterar(cotacaoItens);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cotação itens para ser excluida.
        /// </summary>
        /// <param name="cotacaoItens">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCotacoesItens(string[] cotacaoItens)
        {
            return _cotacaoItensMaximaApi.Deletar(cotacaoItens);
        }
    }
}

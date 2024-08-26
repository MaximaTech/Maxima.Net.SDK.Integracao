using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Preço Promoção para ser incluida na api máxima.
        /// </summary>
        /// <param name="precoPromocao">Representação de uma lista de Preço Promoção</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrecoPromocaoMaxima>> IncluirPrecoPromocao(List<PrecoPromocaoMaxima> precoPromocao)
        {
            return _precoPromocaoMaximaApi.Incluir(precoPromocao);
        }

        /// <summary>
        /// Envia uma lista de Preço Promoção para ser alterada na api máxima, se o Preço Promoção não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="precoPromocao">Representação de uma lista de precoPromocao</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrecoPromocaoMaxima>> AlterarPrecoPromocao(List<PrecoPromocaoMaxima> precoPromocao)
        {
            return _precoPromocaoMaximaApi.Alterar(precoPromocao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Preço Promoção para ser excluida.
        /// </summary>
        /// <param name="precoPromocao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrecoPromocao(string[] precoPromocao)
        {
            return _precoPromocaoMaximaApi.Deletar(precoPromocao);
        }
    }
}

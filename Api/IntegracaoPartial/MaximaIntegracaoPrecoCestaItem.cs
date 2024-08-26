using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PrecoCestaItemMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="precosCestaItens">Representação de uma lista de <see cref="PrecoCestaItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PrecoCestaItemMaxima>> IncluirPrecosCestaItens(List<PrecoCestaItemMaxima> precosCestaItens)
        {
            return _precoCestaItemMaximaApi.Incluir(precosCestaItens);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PrecoCestaItemMaxima"/> para ser alterada na api máxima, se a <see cref="PrecoCestaItemMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="precosCestaItens">Representação de uma lista de <see cref="PrecoCestaItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PrecoCestaItemMaxima>> AlterarPrecosCestaItens(List<PrecoCestaItemMaxima> precosCestaItens)
        {
            return _precoCestaItemMaximaApi.Alterar(precosCestaItens);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PrecoCestaItemMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="precosCestaItens">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPrecosCestaItens(string[] precosCestaItens)
        {
            return _precoCestaItemMaximaApi.Deletar(precosCestaItens);
        }
    }
}

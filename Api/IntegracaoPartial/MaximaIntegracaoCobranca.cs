using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cobrança para ser incluida na api máxima.
        /// </summary>
        /// <param name="cobrancas">Representação de uma lista de Cobrança</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaMaxima>> IncluirCobranca(List<CobrancaMaxima> cobrancas)
        {
            return _cobrancaMaximaApi.Incluir(cobrancas);
        }

        /// <summary>
        /// Envia uma lista de Cobranca para ser alterada na api máxima, se a cobraça não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cobrancas">Representação de uma lista de Cobrança</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaMaxima>> AlterarCobranca(List<CobrancaMaxima> cobrancas)
        {
            return _cobrancaMaximaApi.Alterar(cobrancas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cobrança para ser excluida.
        /// </summary>
        /// <param name="cobrancas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCobranca(string[] cobrancas)
        {
            return _cobrancaMaximaApi.Deletar(cobrancas);
        }
    }
}

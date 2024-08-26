using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Brinde Validações para ser incluida na api máxima.
        /// </summary>
        /// <param name="brindeValidacoes">Representação de uma lista de Brinde Validações</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeValidacaoMaxima>> IncluirBrindeValidacoes(List<BrindeValidacaoMaxima> brindeValidacoes)
        {
            return _brindeValidacaoMaximaApi.Incluir(brindeValidacoes);
        }

        /// <summary>
        /// Envia uma lista de Brinde Validações para ser alterada na api máxima, se o brinde não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="brindeValidacoes">Representação de uma lista de Brinde Validações</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BrindeValidacaoMaxima>> AlterarBrindeValidacoes(List<BrindeValidacaoMaxima> brindeValidacoes)
        {
            return _brindeValidacaoMaximaApi.Alterar(brindeValidacoes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Brinde Validações para ser excluida.
        /// </summary>
        /// <param name="brindeValidacoes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarBrindeValidacoes(string[] brindeValidacoes)
        {
            return _brindeValidacaoMaximaApi.Deletar(brindeValidacoes);
        }
    }
}

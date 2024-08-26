using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cidades para ser incluida na api máxima.
        /// </summary>
        /// <param name="cidades">Representação de uma lista de cidades</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CidadeMaxima>> IncluirCidade(List<CidadeMaxima> cidades)
        {
            return _cidadeMaximaApi.Incluir(cidades);
        }

        /// <summary>
        /// Envia uma lista de Cidades para ser alterada na api máxima, se a cidade não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cidades">Representação de uma lista de cidades</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CidadeMaxima>> AlterarCidade(List<CidadeMaxima> cidades)
        {
            return _cidadeMaximaApi.Alterar(cidades);
        }

        /// <summary>
        /// Envia uma array de strings com ids de cidades para ser excluida.
        /// </summary>
        /// <param name="cidades">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCidades(string[] cidades)
        {
            return _cidadeMaximaApi.Deletar(cidades);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Praça para ser incluida na api máxima.
        /// </summary>
        /// <param name="pracas">Representação de uma lista de Praca</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PracaMaxima>> IncluirPracas(List<PracaMaxima> pracas)
        {
            return _pracaMaximaApi.Incluir(pracas);
        }

        /// <summary>
        /// Envia uma lista de Praça para ser alterada na api máxima, se a praça não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="pracas">Representação de uma lista de Praça</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PracaMaxima>> AlterarPracas(List<PracaMaxima> pracas)
        {
            return _pracaMaximaApi.Alterar(pracas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Praça para ser excluida.
        /// </summary>
        /// <param name="pracas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPracas(string[] pracas)
        {
            return _pracaMaximaApi.Deletar(pracas);
        }
    }
}

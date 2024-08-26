using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Titulos para ser incluida na api máxima.
        /// </summary>
        /// <param name="titulos">Representação de uma lista de Titulos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TitulosMaxima>> IncluirTitulos(List<TitulosMaxima> titulos)
        {
            return _erpPrestMaximaApi.Incluir(titulos);
        }

        /// <summary>
        /// Envia uma lista de Titulos para ser alterada na api máxima, se o titulo não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="titulos">Representação de uma lista de Titulos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TitulosMaxima>> AlterarTitulos(List<TitulosMaxima> titulos)
        {
            return _erpPrestMaximaApi.Alterar(titulos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Titulos para ser excluida.
        /// </summary>
        /// <param name="titulos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTitulos(string[] titulos)
        {
            return _erpPrestMaximaApi.Deletar(titulos);
        }
    }
}

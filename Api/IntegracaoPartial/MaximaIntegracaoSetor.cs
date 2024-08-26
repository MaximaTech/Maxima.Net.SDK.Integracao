using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Setores para ser incluida na api máxima.
        /// </summary>
        /// <param name="setores">Representação de uma lista de Setores</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SetorMaxima>> IncluirSetores(List<SetorMaxima> setores)
        {
            return _setorMaximaApi.Incluir(setores);
        }

        /// <summary>
        /// Envia uma lista de Setores para ser alterada na api máxima, se o setor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="setores">Representação de uma lista de Setores</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SetorMaxima>> AlterarSetores(List<SetorMaxima> setores)
        {
            return _setorMaximaApi.Alterar(setores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Setores para ser excluida.
        /// </summary>
        /// <param name="setores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarSetores(string[] setores)
        {
            return _setorMaximaApi.Deletar(setores);
        }
    }
}

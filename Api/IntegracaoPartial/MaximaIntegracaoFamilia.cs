using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Familia para ser incluida na api máxima.
        /// </summary>
        /// <param name="familias">Representação de uma lista de Familia</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>

        public Task<ResponseApiMaxima<FamiliaMaxima>> IncluirFamilias(List<FamiliaMaxima> familias)
        {
            return _familiaMaximaApi.Incluir(familias);
        }

        /// <summary>
        /// Envia uma lista de Familia para ser alterada na api máxima, se a familia não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="familias">Representação de uma lista de Familia</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FamiliaMaxima>> AlterarFamilias(List<FamiliaMaxima> familias)
        {
            return _familiaMaximaApi.Alterar(familias);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Familia para ser excluida.
        /// </summary>
        /// <param name="familias">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFamilias(string[] familias)
        {
            return _familiaMaximaApi.Deletar(familias);
        }
    }
}

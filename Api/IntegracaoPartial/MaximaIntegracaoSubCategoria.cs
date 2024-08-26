using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="SubCategoriaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="subCategorias">Representação de uma lista de <see cref="SubCategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<SubCategoriaMaxima>> IncluirSubCategorias(List<SubCategoriaMaxima> subCategorias)
        {
            return _subCategoriaMaximaApi.Incluir(subCategorias);
        }

        /// <summary>
        /// Envia uma lista de <see cref="SubCategoriaMaxima"/> para ser alterada na api máxima, se a <see cref="SubCategoriaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="subCategorias">Representação de uma lista de <see cref="SubCategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SubCategoriaMaxima>> AlterarSubCategorias(List<SubCategoriaMaxima> subCategorias)
        {
            return _subCategoriaMaximaApi.Alterar(subCategorias);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="SubCategoriaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="subCategorias">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarSubCategorias(string[] subCategorias)
        {
            return _subCategoriaMaximaApi.Deletar(subCategorias);
        }
    }
}

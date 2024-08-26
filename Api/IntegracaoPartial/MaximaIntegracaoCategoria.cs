using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="CategoriaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="categorias">Representação de uma lista de <see cref="CategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CategoriaMaxima>> IncluirCategorias(List<CategoriaMaxima> categorias)
        {
            return _categoriaMaximaApi.Incluir(categorias);
        }

        /// <summary>
        /// Envia uma lista de <see cref="CategoriaMaxima"/> para ser alterada na api máxima, se a <see cref="CategoriaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="categorias">Representação de uma lista de <see cref="CategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CategoriaMaxima>> AlterarCategorias(List<CategoriaMaxima> categorias)
        {
            return _categoriaMaximaApi.Alterar(categorias);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="CategoriaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="categorias">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCategorias(string[] categorias)
        {
            return _categoriaMaximaApi.Deletar(categorias);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="CategoriaDespesaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="categoriasDespesasMaxima">Representação de uma lista de <see cref="CategoriaDespesaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CategoriaDespesaMaxima>> IncluirCategoriasDespesas(List<CategoriaDespesaMaxima> categoriasDespesasMaxima)
        {
            return _categoriaDespesaMaximaApi.Incluir(categoriasDespesasMaxima);
        }

        /// <summary>
        /// Envia uma lista de <see cref="CategoriaDespesaMaxima"/> para ser alterada na api máxima, se a <see cref="CategoriaDespesaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="categoriasDespesasMaxima">Representação de uma lista de <see cref="CategoriaDespesaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CategoriaDespesaMaxima>> AlterarCategoriasDespesas(List<CategoriaDespesaMaxima> categoriasDespesasMaxima)
        {
            return _categoriaDespesaMaximaApi.Alterar(categoriasDespesasMaxima);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="CategoriaDespesaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="categoriasDespesasMaxima">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCategoriasDespesas(string[] categoriasDespesasMaxima)
        {
            return _categoriaDespesaMaximaApi.Deletar(categoriasDespesasMaxima);
        }
    }
}

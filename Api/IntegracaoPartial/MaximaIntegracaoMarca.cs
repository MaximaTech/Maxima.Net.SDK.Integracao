using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="MarcaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="marcas">Representação de uma lista de <see cref="MarcaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<MarcaMaxima>> IncluirMarcas(List<MarcaMaxima> marcas)
        {
            return _marcaMaximaApi.Incluir(marcas);
        }

        /// <summary>
        /// Envia uma lista de <see cref="MarcaMaxima"/> para ser alterada na api máxima, se a <see cref="MarcaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="marcas">Representação de uma lista de <see cref="MarcaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MarcaMaxima>> AlterarMarcas(List<MarcaMaxima> marcas)
        {
            return _marcaMaximaApi.Alterar(marcas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="MarcaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="marcas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMarcas(string[] marcas)
        {
            return _marcaMaximaApi.Deletar(marcas);
        }
    }
}

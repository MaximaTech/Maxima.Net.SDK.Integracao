using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="MetaVendedorMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="metasVendedores">Representação de uma lista de <see cref="MetaVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<MetaVendedorMaxima>> IncluirMetasVendedores(List<MetaVendedorMaxima> metasVendedores)
        {
            return _metaVendedorMaximaApi.Incluir(metasVendedores);
        }

        /// <summary>
        /// Envia uma lista de <see cref="MetaVendedorMaxima"/> para ser alterada na api máxima, se a <see cref="MetaVendedorMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="metasVendedores">Representação de uma lista de <see cref="MetaVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MetaVendedorMaxima>> AlterarMetasVendedores(List<MetaVendedorMaxima> metasVendedores)
        {
            return _metaVendedorMaximaApi.Alterar(metasVendedores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="MetaVendedorMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="metasVendedores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMetasVendedores(string[] metasVendedores)
        {
            return _metaVendedorMaximaApi.Deletar(metasVendedores);
        }
    }
}

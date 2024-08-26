using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Vendedor para ser incluida na api máxima.
        /// </summary>
        /// <param name="vendedores">Representação de uma lista de Vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VendedorMaxima>> IncluirVendedor(List<VendedorMaxima> vendedores)
        {
            return _vendedorMaximaApi.Incluir(vendedores);
        }

        /// <summary>
        /// Envia uma lista de Vendedor para ser alterada na api máxima, se o vendedor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="vendedores">Representação de uma lista de Vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VendedorMaxima>> AlterarVendedor(List<VendedorMaxima> vendedores)
        {
            return _vendedorMaximaApi.Alterar(vendedores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Vendedor para ser excluida.
        /// </summary>
        /// <param name="vendedores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarVendedor(string[] vendedores)
        {
            return _vendedorMaximaApi.Deletar(vendedores);
        }
    }
}

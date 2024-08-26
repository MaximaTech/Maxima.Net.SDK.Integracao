using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Clientes/Vendedor para ser incluida na api máxima.
        /// </summary>
        /// <param name="clientesVendedor">Representação de uma lista de Clientes/Vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ClienteVendedorMaxima>> IncluirClienteVendedor(List<ClienteVendedorMaxima> clientesVendedor)
        {
            return _clienteVendedorMaximaApi.Incluir(clientesVendedor);
        }

        /// <summary>
        /// Envia uma lista de Cliente/Vendedor para ser alterada na api máxima, se o cliente/vendedor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="clientesVendedor">Representação de uma lista de Cliente/Vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ClienteVendedorMaxima>> AlterarClienteVendedor(List<ClienteVendedorMaxima> clientesVendedor)
        {
            return _clienteVendedorMaximaApi.Alterar(clientesVendedor);
        }
        /// <summary>
        /// Envia uma array de strings com ids de Cliente/Vendedor para ser excluida.
        /// </summary>
        /// <param name="clientesVendedor">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarClienteVendedor(string[] clientesVendedor)
        {
            return _clienteVendedorMaximaApi.Deletar(clientesVendedor);
        }
    }
}

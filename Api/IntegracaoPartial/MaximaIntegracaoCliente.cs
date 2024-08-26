using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Clientes para ser incluida na api máxima.
        /// </summary>
        /// <param name="clientes">Representação de uma lista de Clientes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ClienteMaxima>> IncluirCliente(List<ClienteMaxima> clientes)
        {
            return _clienteMaximaApi.Incluir(clientes);
        }

        /// <summary>
        /// Envia uma lista de Cliente para ser alterada na api máxima, se o cliente não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="clientes">Representação de uma lista de Cliente</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ClienteMaxima>> AlterarCliente(List<ClienteMaxima> clientes)
        {
            return _clienteMaximaApi.Alterar(clientes);
        }
        /// <summary>
        /// Envia uma array de strings com ids de Cliente para ser excluida.
        /// </summary>
        /// <param name="clientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarClientes(string[] clientes)
        {
            return _clienteMaximaApi.Deletar(clientes);
        }
    }
}

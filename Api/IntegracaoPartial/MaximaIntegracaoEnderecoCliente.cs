using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Endereços de Clientes para ser incluida na api máxima.
        /// </summary>
        /// <param name="enderecoCliente">Representação de uma lista de Endereços de Clientes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EnderecoClienteMaxima>> IncluirEnderecosCliente(List<EnderecoClienteMaxima> enderecoCliente)
        {
            return _enderecoClienteMaximaApi.Incluir(enderecoCliente);
        }

        /// <summary>
        /// Envia uma lista de Endereços de Clientes para ser alterada na api máxima, se o endereço não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="enderecoCliente">Representação de uma lista de Endereços de Clientes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EnderecoClienteMaxima>> AlterarEnderecosCliente(List<EnderecoClienteMaxima> enderecoCliente)
        {
            return _enderecoClienteMaximaApi.Alterar(enderecoCliente);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Endereços de Clientes para ser excluida.
        /// </summary>
        /// <param name="enderecosClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEnderecosCliente(string[] enderecosClientes)
        {
            return _enderecoClienteMaximaApi.Deletar(enderecosClientes);
        }
    }
}

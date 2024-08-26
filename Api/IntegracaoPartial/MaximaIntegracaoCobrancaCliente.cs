using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Cobrança/Clientes para ser incluida na api máxima.
        /// </summary>
        /// <param name="cobrancaClientes">Representação de uma lista de Cobrança/Clientes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaClienteMaxima>> IncluirCobrancaClientes(List<CobrancaClienteMaxima> cobrancaClientes)
        {
            return _cobrancaClienteMaximaApi.Incluir(cobrancaClientes);
        }

        /// <summary>
        /// Envia uma lista de Cobrança/Clientes para ser alterada na api máxima, se Cobrança/Cliente não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cobrancaClientes">Representação de uma lista de Cobrança/Clientes</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CobrancaClienteMaxima>> AlterarCobrancaClientes(List<CobrancaClienteMaxima> cobrancaClientes)
        {
            return _cobrancaClienteMaximaApi.Alterar(cobrancaClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Cobrança/Clientes para ser excluida.
        /// </summary>
        /// <param name="cobrancaClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCobrancaClientes(string[] cobrancaClientes)
        {
            return _cobrancaClienteMaximaApi.Deletar(cobrancaClientes);
        }
    }
}

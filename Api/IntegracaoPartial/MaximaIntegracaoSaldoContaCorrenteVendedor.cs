using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Saldo de conta corrente do vendedor para ser incluida na api máxima.
        /// </summary>
        /// <param name="saldoContaCorrente">Representação de uma lista de Saldo de conta corrente do vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SaldoContaCorrenteVendedorMaxima>> IncluirSaldoContaCorrente(List<SaldoContaCorrenteVendedorMaxima> saldoContaCorrente)
        {
            return _saldoContaCorrenteVendedorMaximaApi.Incluir(saldoContaCorrente);
        }

        /// <summary>
        /// Envia uma lista de Saldo de conta corrente do vendedor para ser alterada na api máxima, se o Saldo de conta corrente do vendedor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="saldoContaCorrente">Representação de uma lista de Saldo de conta corrente do vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<SaldoContaCorrenteVendedorMaxima>> AlterarSaldoContaCorrente(List<SaldoContaCorrenteVendedorMaxima> saldoContaCorrente)
        {
            return _saldoContaCorrenteVendedorMaximaApi.Alterar(saldoContaCorrente);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Saldo de conta corrente do vendedor para ser excluida.
        /// </summary>
        /// <param name="saldoContaCorrente">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarSaldoContaCorrente(string[] saldoContaCorrente)
        {
            return _saldoContaCorrenteVendedorMaximaApi.Deletar(saldoContaCorrente);
        }
    }
}

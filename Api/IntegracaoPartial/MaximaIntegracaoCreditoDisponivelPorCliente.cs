using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="CreditoDisponivelPorClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="creditoDisponivelPorClientes">Representação de uma lista de <see cref="CreditoDisponivelPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CreditoDisponivelPorClienteMaxima>> IncluirCreditoDisponivelPorClientes(List<CreditoDisponivelPorClienteMaxima> creditoDisponivelPorClientes)
        {
            return _creditoDisponivelPorClienteMaximaApi.Incluir(creditoDisponivelPorClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="CreditoDisponivelPorClienteMaxima"/> para ser alterada na api máxima, se a <see cref="CreditoDisponivelPorClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="creditoDisponivelPorClientes">Representação de uma lista de <see cref="CreditoDisponivelPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CreditoDisponivelPorClienteMaxima>> AlterarCreditoDisponivelPorClientes(List<CreditoDisponivelPorClienteMaxima> creditoDisponivelPorClientes)
        {
            return _creditoDisponivelPorClienteMaximaApi.Alterar(creditoDisponivelPorClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="CreditoDisponivelPorClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="creditoDisponivelPorClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCreditoDisponivelPorClientes(string[] creditoDisponivelPorClientes)
        {
            return _creditoDisponivelPorClienteMaximaApi.Deletar(creditoDisponivelPorClientes);
        }
    }
}

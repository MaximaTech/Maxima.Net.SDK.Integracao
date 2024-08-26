using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="planosDePagamentoPorCliente">Representação de uma lista de <see cref="PlanoPagamentoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorClienteMaxima>> IncluirPlanosPagamentoPorCliente(List<PlanoPagamentoPorClienteMaxima> planosDePagamentoPorCliente)
        {
            return _planoPagamentoPorClienteApi.Incluir(planosDePagamentoPorCliente);
        }

        /// <summary>
        /// Envia uma lista de <see cref="PlanoPagamentoPorClienteMaxima"/> para ser alterada na api máxima, se a <see cref="PlanoPagamentoPorClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="planosDePagamentoPorCliente">Representação de uma lista de <see cref="PlanoPagamentoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<PlanoPagamentoPorClienteMaxima>> AlterarPlanosPagamentoPorCliente(List<PlanoPagamentoPorClienteMaxima> planosDePagamentoPorCliente)
        {
            return _planoPagamentoPorClienteApi.Alterar(planosDePagamentoPorCliente);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="PlanoPagamentoPorClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="planosDePagamentoPorCliente">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarPlanosPagamentoPorCliente(string[] planosDePagamentoPorCliente)
        {
            return _planoPagamentoPorClienteApi.Deletar(planosDePagamentoPorCliente);
        }
    }
}

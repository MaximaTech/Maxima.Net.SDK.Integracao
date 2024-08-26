using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Restrições de vendas para ser incluida na api máxima.
        /// </summary>
        /// <param name="restricoesVenda">Representação de uma lista de Restrições de vendas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RestricaoVendaMaxima>> IncluirRestricoesVenda(List<RestricaoVendaMaxima> restricoesVenda)
        {
            return _restricaoVendaMaximaApi.Incluir(restricoesVenda);
        }

        /// <summary>
        /// Envia uma lista de Restrições de vendas para ser alterada na api máxima, se a restrição não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="restricoesVenda">Representação de uma lista de Restrições de vendas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RestricaoVendaMaxima>> AlterarRestricoesVenda(List<RestricaoVendaMaxima> restricoesVenda)
        {
            return _restricaoVendaMaximaApi.Alterar(restricoesVenda);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Restrições de vendas para ser excluida.
        /// </summary>
        /// <param name="restricoesVenda">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRestricoesVenda(string[] restricoesVenda)
        {
            return _restricaoVendaMaximaApi.Deletar(restricoesVenda);
        }
    }
}

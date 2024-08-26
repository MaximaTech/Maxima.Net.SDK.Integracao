using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Movimento Venda Pendente WMS para ser incluida na api máxima.
        /// </summary>
        /// <param name="movimentoVendaPendenteWMS">Representação de uma lista de Movimento Venda Pendente WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MovimentoVendaPendenteWMSMaxima>> IncluirMovimentoVendaPendenteWMS(List<MovimentoVendaPendenteWMSMaxima> movimentoVendaPendenteWMS)
        {
            return _movimentoVendaPendenteWMSApi.Incluir(movimentoVendaPendenteWMS);
        }

        /// <summary>
        /// Envia uma lista de Movimento Venda Pendente WMS para ser alterada na api máxima, se o Movimento Venda Pendente WMS não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="movimentoVendaPendenteWMS">Representação de uma lista de Movimento Venda Pendente WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MovimentoVendaPendenteWMSMaxima>> AlterarMovimentoVendaPendenteWMS(List<MovimentoVendaPendenteWMSMaxima> movimentoVendaPendenteWMS)
        {
            return _movimentoVendaPendenteWMSApi.Alterar(movimentoVendaPendenteWMS);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Movimento Venda Pendente WMS para ser excluida.
        /// </summary>
        /// <param name="movimentoVendaPendenteWMS">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMovimentoVendaPendenteWMS(string[] movimentoVendaPendenteWMS)
        {
            return _movimentoVendaPendenteWMSApi.Deletar(movimentoVendaPendenteWMS);
        }
    }
}

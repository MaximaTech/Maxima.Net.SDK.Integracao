using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="DescontoItemMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="descontoItens">Representação de uma lista de <see cref="DescontoItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<DescontoItemMaxima>> IncluirDescontoItens(List<DescontoItemMaxima> descontoItens)
        {
            return _descontoItemMaxima.Incluir(descontoItens);
        }

        /// <summary>
        /// Envia uma lista de <see cref="DescontoItemMaxima"/> para ser alterada na api máxima, se a <see cref="DescontoItemMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="descontoItens">Representação de uma lista de <see cref="DescontoItemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoItemMaxima>> AlterarDescontoItens(List<DescontoItemMaxima> descontoItens)
        {
            return _descontoItemMaxima.Alterar(descontoItens);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="DescontoItemMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="descontoItens">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDescontoItens(string[] descontoItens)
        {
            return _descontoItemMaxima.Deletar(descontoItens);
        }
    }
}

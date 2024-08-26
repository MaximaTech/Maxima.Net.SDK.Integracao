using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="DescontoCapaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="descontoCapa">Representação de uma lista de <see cref="DescontoCapaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<DescontoCapaMaxima>> IncluirDescontoCapa(List<DescontoCapaMaxima> descontoCapa)
        {
            return _descontoCapaApi.Incluir(descontoCapa);
        }

        /// <summary>
        /// Envia uma lista de <see cref="DescontoCapaMaxima"/> para ser alterada na api máxima, se a <see cref="DescontoCapaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="descontoCapa">Representação de uma lista de <see cref="DescontoCapaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoCapaMaxima>> AlterarDescontoCapa(List<DescontoCapaMaxima> descontoCapa)
        {
            return _descontoCapaApi.Alterar(descontoCapa);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="DescontoCapaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="descontoCapa">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDescontoCapa(string[] descontoCapa)
        {
            return _descontoCapaApi.Deletar(descontoCapa);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="DescontoRestricaoMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="descontosRestricoes">Representação de uma lista de <see cref="DescontoRestricaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<DescontoRestricaoMaxima>> IncluirDescontosRestricoes(List<DescontoRestricaoMaxima> descontosRestricoes)
        {
            return _descontoRestricaoMaxima.Incluir(descontosRestricoes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="DescontoRestricaoMaxima"/> para ser alterada na api máxima, se a <see cref="DescontoRestricaoMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="descontosRestricoes">Representação de uma lista de <see cref="DescontoRestricaoMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoRestricaoMaxima>> AlterarDescontosRestricoes(List<DescontoRestricaoMaxima> descontosRestricoes)
        {
            return _descontoRestricaoMaxima.Alterar(descontosRestricoes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="DescontoRestricaoMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="descontosRestricoes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDescontosRestricoes(string[] descontosRestricoes)
        {
            return _descontoRestricaoMaxima.Deletar(descontosRestricoes);
        }
    }
}

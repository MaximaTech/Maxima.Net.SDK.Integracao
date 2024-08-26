using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="LimiteComboMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="limiteCombo">Representação de uma lista de <see cref="LimiteComboMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<LimiteComboMaxima>> IncluirLimiteCombo(List<LimiteComboMaxima> limiteCombo)
        {
            return _limiteComboMaxima.Incluir(limiteCombo);
        }

        /// <summary>
        /// Envia uma lista de <see cref="LimiteComboMaxima"/> para ser alterada na api máxima, se a <see cref="LimiteComboMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="limiteCombo">Representação de uma lista de <see cref="LimiteComboMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<LimiteComboMaxima>> AlterarLimiteCombo(List<LimiteComboMaxima> limiteCombo)
        {
            return _limiteComboMaxima.Alterar(limiteCombo);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="LimiteComboMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="limiteCombo">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarLimiteCombo(string[] limiteCombo)
        {
            return _limiteComboMaxima.Deletar(limiteCombo);
        }
    }
}

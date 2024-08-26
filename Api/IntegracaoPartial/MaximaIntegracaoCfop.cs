using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="CfopMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="cfops">Representação de uma lista de <see cref="CfopMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CfopMaxima>> IncluirCfops(List<CfopMaxima> cfops)
        {
            return _cfopMaxima.Incluir(cfops);
        }

        /// <summary>
        /// Envia uma lista de <see cref="CfopMaxima"/> para ser alterada na api máxima, se a <see cref="CfopMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="cfops">Representação de uma lista de <see cref="CfopMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CfopMaxima>> AlterarCfops(List<CfopMaxima> cfops)
        {
            return _cfopMaxima.Alterar(cfops);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="CfopMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="cfops">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCfops(string[] cfops)
        {
            return _cfopMaxima.Deletar(cfops);
        }
    }
}

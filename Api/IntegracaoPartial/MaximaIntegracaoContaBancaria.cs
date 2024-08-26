using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ContaBancariaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="contasBancarias">Representação de uma lista de <see cref="ContaBancariaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ContaBancariaMaxima>> IncluirContasBancarias(List<ContaBancariaMaxima> contasBancarias)
        {
            return _contaBancariaMaximaApi.Incluir(contasBancarias);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ContaBancariaMaxima"/> para ser alterada na api máxima, se a <see cref="ContaBancariaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="contasBancarias">Representação de uma lista de <see cref="ContaBancariaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ContaBancariaMaxima>> AlterarContasBancarias(List<ContaBancariaMaxima> contasBancarias)
        {
            return _contaBancariaMaximaApi.Alterar(contasBancarias);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ContaBancariaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="contasBancarias">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarContasBancarias(string[] contasBancarias)
        {
            return _contaBancariaMaximaApi.Deletar(contasBancarias);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ConfiguracaoERPMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="configuracaoErp">Representação de uma lista de <see cref="ConfiguracaoERPMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ConfiguracaoERPMaxima>> IncluirConfiguracaoERP(List<ConfiguracaoERPMaxima> configuracaoErp)
        {
            return _configuracaoERPApi.Incluir(configuracaoErp);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ConfiguracaoERPMaxima"/> para ser alterada na api máxima, se a <see cref="ConfiguracaoERPMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="configuracaoErp">Representação de uma lista de <see cref="ConfiguracaoERPMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ConfiguracaoERPMaxima>> AlterarConfiguracaoERP(List<ConfiguracaoERPMaxima> configuracaoErp)
        {
            return _configuracaoERPApi.Alterar(configuracaoErp);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ConfiguracaoERPMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="configuracaoErp">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarConfiguracaoERP(string[] configuracaoErp)
        {
            return _configuracaoERPApi.Deletar(configuracaoErp);
        }
    }
}

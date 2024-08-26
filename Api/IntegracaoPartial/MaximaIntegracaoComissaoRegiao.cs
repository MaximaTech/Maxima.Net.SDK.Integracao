using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de ComissaoRegiao para ser incluida na api máxima.
        /// </summary>
        /// <param name="comissaoRegiao">Representação de uma lista de ComissaoRegiao</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ComissaoRegiaoMaxima>> IncluirComissaoRegioes(List<ComissaoRegiaoMaxima> comissaoRegiao)
        {
            return _comissaoRegiaoApi.Incluir(comissaoRegiao);
        }

        /// <summary>
        /// Envia uma lista de ComissaoRegiao para ser alterada na api máxima, se a comissão região não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="comissaoRegiao">Representação de uma lista de ComissaoRegiao</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ComissaoRegiaoMaxima>> AlterarComissaoRegioes(List<ComissaoRegiaoMaxima> comissaoRegiao)
        {
            return _comissaoRegiaoApi.Alterar(comissaoRegiao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de ComissaoRegiao para ser excluida.
        /// </summary>
        /// <param name="comissaoRegiao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarComissaoRegioes(string[] comissaoRegiao)
        {
            return _comissaoRegiaoApi.Deletar(comissaoRegiao);
        }
    }
}

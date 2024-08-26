using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ComissaoProfissionalMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="comissoesProfissional">Representação de uma lista de <see cref="ComissaoProfissionalMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ComissaoProfissionalMaxima>> IncluirComissoesProfissional(List<ComissaoProfissionalMaxima> comissoesProfissional)
        {
            return _comissaoProfissionalMaximaApi.Incluir(comissoesProfissional);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ComissaoProfissionalMaxima"/> para ser alterada na api máxima, se a <see cref="ComissaoProfissionalMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="comissoesProfissional">Representação de uma lista de <see cref="ComissaoProfissionalMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ComissaoProfissionalMaxima>> AlterarComissoesProfissional(List<ComissaoProfissionalMaxima> comissoesProfissional)
        {
            return _comissaoProfissionalMaximaApi.Alterar(comissoesProfissional);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ComissaoProfissionalMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="comissoesProfissional">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarComissoesProfissional(string[] comissoesProfissional)
        {
            return _comissaoProfissionalMaximaApi.Deletar(comissoesProfissional);
        }
    }
}

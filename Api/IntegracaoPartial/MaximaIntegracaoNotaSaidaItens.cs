using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de itens da nota fiscal de saída para ser incluida na api máxima.
        /// </summary>
        /// <param name="itensNota">Representação de uma lista de itens da nota fiscal de saída</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaSaidaItensMaxima>> IncluirNotaSaidaItens(List<NotaSaidaItensMaxima> itensNota)
        {
            return _notaSaidaItensMaximaApi.Incluir(itensNota);
        }

        /// <summary>
        /// Envia uma lista de itens da nota fiscal de saída para ser alterada na api máxima, se o Item da Nota Fiscal não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="itensNota">Representação de uma lista de itens da nota fiscal de saída</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaSaidaItensMaxima>> AlterarNotaSaidaItens(List<NotaSaidaItensMaxima> itensNota)
        {
            return _notaSaidaItensMaximaApi.Alterar(itensNota);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Itens da nota fiscal de saída para ser excluida.
        /// </summary>
        /// <param name="itensNota">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarNotaSaidaItens(string[] itensNota)
        {
            return _notaSaidaItensMaximaApi.Deletar(itensNota);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Notas entrada capa de conta corrente do vendedor para ser incluida na api máxima.
        /// </summary>
        /// <param name="notaEntradaCapa">Representação de uma lista de Notas entrada capa de conta corrente do vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaFiscalEntradaCapaMaxima>> IncluirNotaEntradaCapa(List<NotaFiscalEntradaCapaMaxima> notaEntradaCapa)
        {
            return _notaFiscalEntradaCapaMaximaApi.Incluir(notaEntradaCapa);
        }

        /// <summary>
        /// Envia uma lista de Notas entrada capa de conta corrente do vendedor para ser alterada na api máxima, se o Notas entrada capa de conta corrente do vendedor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="notaEntradaCapa">Representação de uma lista de Notas entrada capa de conta corrente do vendedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaFiscalEntradaCapaMaxima>> AlterarNotaEntradaCapa(List<NotaFiscalEntradaCapaMaxima> notaEntradaCapa)
        {
            return _notaFiscalEntradaCapaMaximaApi.Alterar(notaEntradaCapa);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Notas entrada capa de conta corrente do vendedor para ser excluida.
        /// </summary>
        /// <param name="notaEntradaCapa">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarNotaEntradaCapa(string[] notaEntradaCapa)
        {
            return _notaFiscalEntradaCapaMaximaApi.Deletar(notaEntradaCapa);
        }
    }
}

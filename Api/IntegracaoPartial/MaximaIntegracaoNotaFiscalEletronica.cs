using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Notas Fiscais para ser incluida na api máxima.
        /// </summary>
        /// <param name="nfe">Representação de uma lista de Notas Fiscais</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaFiscalEletronicaMaxima>> IncluirNotaFiscalEletronica(List<NotaFiscalEletronicaMaxima> nfe)
        {
            return _notaFiscalEletronicaMaximaApi.Incluir(nfe);
        }

        /// <summary>
        /// Envia uma lista de Notas Fiscais para ser alterada na api máxima, se a NF não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="nfe">Representação de uma lista de Notas Fiscais</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaFiscalEletronicaMaxima>> AlterarNotaFiscalEletronica(List<NotaFiscalEletronicaMaxima> nfe)
        {
            return _notaFiscalEletronicaMaximaApi.Alterar(nfe);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Notas Fiscais para ser excluida.
        /// </summary>
        /// <param name="nfes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarNotaFiscalEletronica(string[] nfes)
        {
            return _notaFiscalEletronicaMaximaApi.Deletar(nfes);
        }
    }
}

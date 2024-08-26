using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Notas de saídas capa, para ser incluida na api máxima.
        /// </summary>
        /// <param name="notaSaidasCapa">Representação de uma lista de notaSaidasCapa</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<NotaSaidaCapaMaxima>> IncluirNotaSaidaCapa(List<NotaSaidaCapaMaxima> notaSaidasCapa)
        {
            return _notaSaidaMaximaApi.Incluir(notaSaidasCapa);
        }

        /// <summary>
        /// Envia uma lista de Notas de saídas capa para ser alterada na api máxima, se a Nota de saída não existir no banco nuvem, ira ser retornado um erro.
        /// </summary>
        /// <param name="notaSaidasCapa">Representação de uma lista de notaSaidas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<NotaSaidaCapaMaxima>> AlterarNotaSaidaCapa(List<NotaSaidaCapaMaxima> notaSaidasCapa)
        {
            return _notaSaidaMaximaApi.Alterar(notaSaidasCapa);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Notas de saídas capa, para ser excluida.
        /// </summary>
        /// <param name="notaSaidasCapa">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarNotaSaidasCapas(string[] notaSaidasCapa)
        {
            return _notaSaidaMaximaApi.Deletar(notaSaidasCapa);
        }
    }
}

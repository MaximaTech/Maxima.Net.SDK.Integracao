using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Atividades Economicas para ser incluida na api máxima.
        /// </summary>
        /// <param name="atividades">Representação de uma lista de Atividades Economicas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<AtividadeEconomicaMaxima>> IncluirAtividadesEconomicas(List<AtividadeEconomicaMaxima> atividades)
        {
            return _atividadeEconomicaMaximaApi.Incluir(atividades);
        }

        /// <summary>
        /// Envia uma lista de Atividades Economicas para ser alterada na api máxima, se a atividade economica não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="atividades">Representação de uma lista de Atividades Economicas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<AtividadeEconomicaMaxima>> AlterarAtividadesEconomicas(List<AtividadeEconomicaMaxima> atividades)
        {
            return _atividadeEconomicaMaximaApi.Alterar(atividades);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Atividades Economicas para ser excluida.
        /// </summary>
        /// <param name="atividades">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarAtividadesEconomicas(string[] atividades)
        {
            return _atividadeEconomicaMaximaApi.Deletar(atividades);
        }
    }
}

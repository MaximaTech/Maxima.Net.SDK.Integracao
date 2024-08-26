using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Visitas para ser incluida na api máxima.
        /// </summary>
        /// <param name="visitas">Representação de uma lista de Visitas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VisitaMaxima>> IncluirVisitas(List<VisitaMaxima> visitas)
        {
            return _visitaMaximaApi.Incluir(visitas);
        }

        /// <summary>
        /// Envia uma lista de Visitas para ser alterada na api máxima, se o Visitas não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="visitas">Representação de uma lista de Visitas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VisitaMaxima>> AlterarVisitas(List<VisitaMaxima> visitas)
        {
            return _visitaMaximaApi.Alterar(visitas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Visitas para ser excluida.
        /// </summary>
        /// <param name="visitas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarVisitas(string[] visitas)
        {
            return _visitaMaximaApi.Deletar(visitas);
        }
    }
}

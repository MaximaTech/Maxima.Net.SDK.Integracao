using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Motivos de Visitas para ser incluida na api máxima.
        /// </summary>
        /// <param name="motivoVisitas">Representação de uma lista de Motivos de Visitas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoVisitaMaxima>> IncluirMotivoVisitas(List<MotivoVisitaMaxima> motivoVisitas)
        {
            return _motivoVisitaMaximaApi.Incluir(motivoVisitas);
        }

        /// <summary>
        /// Envia uma lista de Motivos de Visitas para ser alterada na api máxima, se o Motivos de Visitas não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="motivoVisitas">Representação de uma lista de Motivos de Visitas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoVisitaMaxima>> AlterarMotivoVisitas(List<MotivoVisitaMaxima> motivoVisitas)
        {
            return _motivoVisitaMaximaApi.Alterar(motivoVisitas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Motivos de Visitas para ser excluida.
        /// </summary>
        /// <param name="motivoVisitas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMotivoVisitas(string[] motivoVisitas)
        {
            return _motivoVisitaMaximaApi.Deletar(motivoVisitas);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de atividades para ser incluida na api máxima.
        /// </summary>
        /// <param name="atividades">Representação de uma lista de atividades</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<RamoAtividadeMaxima>> IncluirRamoAtividade(List<RamoAtividadeMaxima> atividades)
        {
            return _ramoAtividadeMaximaApi.Incluir(atividades);
        }

        /// <summary>
        /// Envia uma lista de atividades para ser alterada na api máxima, se a atividade não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="atividades">Representação de uma lista de atividades</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RamoAtividadeMaxima>> AlterarRamoAtividade(List<RamoAtividadeMaxima> atividades)
        {
            return _ramoAtividadeMaximaApi.Alterar(atividades);
        }

        /// <summary>
        /// Envia uma array de strings com ids de atividades para ser excluida.
        /// </summary>
        /// <param name="atividades">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRamoAtividades(string[] atividades)
        {
            return _ramoAtividadeMaximaApi.Deletar(atividades);
        }
    }
}

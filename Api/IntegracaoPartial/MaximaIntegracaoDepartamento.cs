using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Departamento para ser incluida na api máxima.
        /// </summary>
        /// <param name="departamentos">Representação de uma lista de Departamento</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DepartamentoMaxima>> IncluirDepartamentos(List<DepartamentoMaxima> departamentos)
        {
            return _departamentoMaximaApi.Incluir(departamentos);
        }

        /// <summary>
        /// Envia uma lista de Departamento para ser alterada na api máxima, se o departamento não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="departamentos">Representação de uma lista de Departamento</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DepartamentoMaxima>> AlterarDepartamentos(List<DepartamentoMaxima> departamentos)
        {
            return _departamentoMaximaApi.Alterar(departamentos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Departamento para ser excluida.
        /// </summary>
        /// <param name="departamentos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDepartamentos(string[] departamentos)
        {
            return _departamentoMaximaApi.Deletar(departamentos);
        }
    }
}

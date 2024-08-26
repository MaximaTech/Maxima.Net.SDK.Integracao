using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Empregados para ser incluida na api máxima.
        /// </summary>
        /// <param name="empregados">Representação de uma lista de Empregados</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EmpregadoMaxima>> IncluirEmpregados(List<EmpregadoMaxima> empregados)
        {
            return _empregadoMaximaApi.Incluir(empregados);
        }

        /// <summary>
        /// Envia uma lista de Empregados para ser alterada na api máxima, se o empregado não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="empregados">Representação de uma lista de Empregados</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<EmpregadoMaxima>> AlterarEmpregados(List<EmpregadoMaxima> empregados)
        {
            return _empregadoMaximaApi.Alterar(empregados);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Empregados para ser excluida.
        /// </summary>
        /// <param name="empregados">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarEmpregados(string[] empregados)
        {
            return _empregadoMaximaApi.Deletar(empregados);
        }
    }
}

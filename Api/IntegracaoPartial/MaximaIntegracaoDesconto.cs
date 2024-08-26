using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Descontos para ser incluida na api máxima.
        /// </summary>
        /// <param name="descontos">Representação de uma lista de Descontos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoMaxima>> IncluirDescontos(List<DescontoMaxima> descontos)
        {
            return _descontoMaximaApi.Incluir(descontos);
        }

        /// <summary>
        /// Envia uma lista de Descontos para ser alterada na api máxima, se o desconto não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="descontos">Representação de uma lista de Descontos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoMaxima>> AlterarDescontos(List<DescontoMaxima> descontos)
        {
            return _descontoMaximaApi.Alterar(descontos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Descontos para ser excluida.
        /// </summary>
        /// <param name="descontos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDescontos(string[] descontos)
        {
            return _descontoMaximaApi.Deletar(descontos);
        }
    }
}

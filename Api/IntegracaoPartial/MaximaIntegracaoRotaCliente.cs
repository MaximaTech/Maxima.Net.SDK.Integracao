using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Rotas para ser incluida na api máxima.
        /// </summary>
        /// <param name="rotas">Representação de uma lista de Rotas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RotaClienteMaxima>> IncluirRotasCliente(List<RotaClienteMaxima> rotas)
        {
            return _rotaClienteMaximaApi.Incluir(rotas);
        }

        /// <summary>
        /// Envia uma lista de Rotas para ser alterada na api máxima, se a rota não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="rotas">Representação de uma lista de Rotas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RotaClienteMaxima>> AlterarRotasCliente(List<RotaClienteMaxima> rotas)
        {
            return _rotaClienteMaximaApi.Alterar(rotas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Rotas para ser excluida.
        /// </summary>
        /// <param name="rotas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRotasCliente(string[] rotas)
        {
            return _rotaClienteMaximaApi.Deletar(rotas);
        }
    }
}

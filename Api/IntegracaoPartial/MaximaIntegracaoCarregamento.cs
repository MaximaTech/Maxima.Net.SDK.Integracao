using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de carregamentos para ser incluida na api máxima.
        /// </summary>
        /// <param name="carregamentos">Representação de uma lista de carregamentos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<CarregamentoMaxima>> IncluirCarregamentos(List<CarregamentoMaxima> carregamentos)
        {
            return _carregamentoMaximaApi.Incluir(carregamentos);
        }

        /// <summary>
        /// Envia uma lista de carregamentos para ser alterada na api máxima, se a carregamentos não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="carregamentos">Representação de uma lista de carregamentos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<CarregamentoMaxima>> AlterarCarregamentos(List<CarregamentoMaxima> carregamentos)
        {
            return _carregamentoMaximaApi.Alterar(carregamentos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de carregamentos para ser excluida.
        /// </summary>
        /// <param name="carregamentos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCarregamentos(List<CarregamentoMaxima> carregamentos)
        {
            return _carregamentoMaximaApi.Deletar(carregamentos);
        }
        /// <summary>
        /// Envia uma array de strings com ids de carregamentos para ser excluida.
        /// </summary>
        /// <param name="carregamentos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarCarregamentos(string[] carregamentos)
        {
            return _carregamentoMaximaApi.Deletar(carregamentos);
        }

        /// <summary>
        /// Buscar todos os carregamento pendentes.
        /// </summary>
        /// <returns>Uma lista de carregamentos pendentes</returns>
        public async Task<List<CarregamentoMaxima>> BuscarCarregamentosPendentes()
        {
            var retornado = await _carregamentoMaximaApi.Get<CarregamentoMaxima>("Pendentes");
            return retornado;
        }

        /// <summary>
        /// Buscar todos os carregamento pendentes com pedidos.
        /// </summary>
        /// <returns>Uma lista de carregamentos pendente com pedidoss</returns>
        public async Task<List<CarregamentoMaxima>> BuscarCarregamentosPendentesComPedidos()
        {
            var retornado = await _carregamentoMaximaApi.Get<CarregamentoMaxima>("PendentesComPedidos");
            return retornado;
        }

        /// <summary>
        /// Buscar todos os carregamento.
        /// </summary>
        /// <returns>Uma lista de carregamentos</returns>
        public async Task<List<CarregamentoMaxima>> BuscarTodosCarregamentos()
        {
            var retornado = await _carregamentoMaximaApi.Get<CarregamentoMaxima>("Todos");
            return retornado;
        }
    }
}

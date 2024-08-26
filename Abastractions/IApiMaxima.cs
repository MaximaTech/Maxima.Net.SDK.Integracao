using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Abastractions
{
    /// <summary>
    /// Interface para a execução de chamadas à API da Máxima.
    /// </summary>
    public interface IApiMaxima
    {
        string Usuario { get; set; }
        string Senha { get; set; }
        string Token { get; set; }

        Task<Login> RealizarLoginAsync(string login, string password);
        Task<RetornoApiMaxima> Get(string versao, string caminho, string id);
        Task<RetornoApiMaxima> Get(string versao, string caminho);
        Task<List<PedidoMaxima>> GetPedidosNaoImportados();
        Task<RetornoApiMaxima> Post<TInput>(string versao, string caminho, TInput objeto);
        Task<RetornoApiMaxima> Put<TInput>(string versao, string caminho, TInput objeto, bool isPedido = false);
        Task<RetornoApiMaxima> Delete<TInput>(string versao, string caminho, TInput objeto);
        Task<RetornoApiMaxima> Delete(string versao, string caminho);
        Task<TReturn> GetAllClientes<TReturn>(string versao, string caminho);
    }
}

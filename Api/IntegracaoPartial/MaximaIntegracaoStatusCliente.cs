using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Retorna os clientes não importados.
        /// </summary>
        /// <returns></returns>
        public Task<List<ClienteMaximaCadastro>> GetClientes()
        {
            return _statusClienteMaximaApi.GetAllClientes();
        }

        /// <summary>
        /// Atualiza o status do cliente que foi importado pelo ERP.
        /// </summary>
        /// <param name="clienteMaxima">Cliente retornado pela máxima.</param>
        /// <param name="sucesso">Se houve sucesso ao importar o cliente no ERP.</param>
        /// <param name="idClienteERP">Indentificador do cliente junto ao ERP.</param>
        /// <param name="msnErro">Breve descrição de erro se ocorrido.</param>
        /// <returns></returns>
        public Task<RetornoApiMaxima> AlterarStatusCliente(ClienteMaximaCadastro clienteMaxima, bool sucesso, string idClienteERP, string msnErro = null)
        {
            return _statusClienteMaximaApi.Alterar(clienteMaxima, sucesso, idClienteERP, msnErro);
        }
    }
}

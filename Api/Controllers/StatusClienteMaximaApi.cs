using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Entidades;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    public class StatusClienteMaximaApi
    {
        private readonly IApiMaxima _api;

        public StatusClienteMaximaApi(IApiMaxima apiMaxima)
        {
            this._api = apiMaxima;
        }

        public async Task<List<ClienteMaximaCadastro>> GetAllClientes()
        {
            var listStatusCliente = await _api.GetAllClientes<List<StatusClienteMaxima>>(StatusClienteMaxima.VersaoAPI, StatusClienteMaxima.EndPoint);
            List<ClienteMaximaCadastro> listCliente = new List<ClienteMaximaCadastro>();
            foreach (var item in listStatusCliente)
            {
                var clienteMaxima = JsonSerializer.Deserialize<ClienteMaximaCadastro>(item.Objeto_json);
                clienteMaxima.Id_cliente = item.Id_cliente;
                listCliente.Add(clienteMaxima);
            }

            return listCliente;
        }

        public async Task<RetornoApiMaxima> Alterar(ClienteMaximaCadastro clienteMaxima, bool sucesso, string idClienteERP, string msnErro)
        {
            StatusClienteMaxima statusCliente = new StatusClienteMaxima();
            statusCliente.Id_cliente = clienteMaxima.Id_cliente;

            if (sucesso)
            {
                clienteMaxima.CriticaImportacao = "Cliente importado com sucesso.";
                clienteMaxima.RetornoImportacao = 2;
                clienteMaxima.Codigo = idClienteERP;
                statusCliente.Status = 4;
                statusCliente.Objeto_json = JsonSerializer.Serialize(clienteMaxima);

                return await _api.Put(StatusClienteMaxima.VersaoAPI, StatusClienteMaxima.EndPoint, new List<StatusClienteMaxima>() { statusCliente }, true);
            }
            else
            {
                clienteMaxima.CriticaImportacao = msnErro;
                clienteMaxima.RetornoImportacao = 3;
                statusCliente.Status = 14;
                statusCliente.Objeto_json = JsonSerializer.Serialize(clienteMaxima);

                return await _api.Put(StatusClienteMaxima.VersaoAPI, StatusClienteMaxima.EndPoint, new List<StatusClienteMaxima>() { statusCliente }, true);
            }

        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Buscar histórico de pedido pelo num car
        /// </summary>
        /// <param name="numTransVendas">Lista com os números dos carregamentos</param>
        /// <returns></returns>
        public async Task<List<NotaFiscalStatusEntregaMaxima>> BuscarStatusEntregaCarregamento(List<string> numTransVendas)
        {
            var paramFormatados = string.Join("&", numTransVendas.Select(s => $"numTransVendas={s}"));
            var retorno = await _notaFiscalStatusEntregaApi.Get<NotaFiscalStatusEntregaMaxima>("ConsultarPorNumTransVendas", paramFormatados);
            return retorno;
        }
    }
}

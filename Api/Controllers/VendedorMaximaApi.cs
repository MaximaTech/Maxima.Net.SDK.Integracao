using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class VendedorMaximaApi : ApiBase<VendedorMaxima>
    {
        override public string VersaoAPI { get; set; } = VendedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = VendedorMaxima.EndPoint;
        public VendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<VendedorMaxima> lista)
        {
            foreach (var vendedor in lista)
            {
                vendedor.TipoVendedor = vendedor.TipoVendedor ?? "E";
                vendedor.UsaDebitoCredito = vendedor.UsaDebitoCredito ?? "N";
                vendedor.ProximoNumeroPedidoForcaVenda = vendedor.ProximoNumeroPedidoForcaVenda ?? 1;
            }
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PedidosProcessadosWMSMaximaApi : ApiBase<PedidosProcessadosWMSMaxima>
    {
        override public string VersaoAPI { get; set; } = PedidosProcessadosWMSMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PedidosProcessadosWMSMaxima.EndPoint;

        public PedidosProcessadosWMSMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PedidosProcessadosWMSMaxima> pedidosProcessados)
        {
            
        }
    }
}

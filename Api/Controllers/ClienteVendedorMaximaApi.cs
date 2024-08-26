using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ClienteVendedorMaximaApi : ApiBase<ClienteVendedorMaxima>
    {
        override public string VersaoAPI { get; set; } = ClienteVendedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ClienteVendedorMaxima.EndPoint;
        public ClienteVendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ClienteVendedorMaxima> list)
        {

        }
    }
}

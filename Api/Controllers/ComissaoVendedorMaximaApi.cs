using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ComissaoVendedorMaximaApi : ApiBase<ComissaoVendedorMaxima>
    {
        override public string VersaoAPI { get; set; } = ComissaoVendedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ComissaoVendedorMaxima.EndPoint;
        public ComissaoVendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ComissaoVendedorMaxima> list)
        {
        }
    }
}

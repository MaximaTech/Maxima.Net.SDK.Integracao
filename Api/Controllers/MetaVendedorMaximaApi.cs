using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MetaVendedorMaximaApi : ApiBase<MetaVendedorMaxima>
    {
        override public string VersaoAPI { get; set; } = MetaVendedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MetaVendedorMaxima.EndPoint;
        public MetaVendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MetaVendedorMaxima> list)
        {

        }
    }
}

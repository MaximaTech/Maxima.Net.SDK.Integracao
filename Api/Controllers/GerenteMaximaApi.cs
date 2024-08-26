using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class GerenteMaximaApi : ApiBase<GerenteMaxima>
    {
        override public string VersaoAPI { get; set; } = GerenteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = GerenteMaxima.EndPoint;

        public GerenteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<GerenteMaxima> list)
        { }
    }
}

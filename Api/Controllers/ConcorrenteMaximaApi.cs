using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ConcorrenteMaximaApi : ApiBase<ConcorrenteMaxima>
    {
        override public string VersaoAPI { get; set; } = ConcorrenteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ConcorrenteMaxima.EndPoint;
        public ConcorrenteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ConcorrenteMaxima> list)
        {

        }
    }
}

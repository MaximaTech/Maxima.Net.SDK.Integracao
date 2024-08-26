using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class VisitaMaximaApi : ApiBase<VisitaMaxima>
    {
        override public string VersaoAPI { get; set; } = VisitaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = VisitaMaxima.EndPoint;
        public VisitaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<VisitaMaxima> list)
        {

        }
    }
}

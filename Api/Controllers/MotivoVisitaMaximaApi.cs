using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MotivoVisitaMaximaApi : ApiBase<MotivoVisitaMaxima>
    {
        override public string VersaoAPI { get; set; } = MotivoVisitaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MotivoVisitaMaxima.EndPoint;
        public MotivoVisitaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MotivoVisitaMaxima> list)
        {

        }
    }
}

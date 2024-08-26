using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PlanoPagamentoPorFilialMaximaApi : ApiBase<PlanoPagamentoPorFilialMaxima>
    {
        override public string VersaoAPI { get; set; } = PlanoPagamentoPorFilialMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PlanoPagamentoPorFilialMaxima.EndPoint;

        public PlanoPagamentoPorFilialMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<PlanoPagamentoPorFilialMaxima> list)
        { }
    }
}

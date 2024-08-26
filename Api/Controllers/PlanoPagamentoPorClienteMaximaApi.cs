using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PlanoPagamentoPorClienteMaximaApi : ApiBase<PlanoPagamentoPorClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = PlanoPagamentoPorClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PlanoPagamentoPorClienteMaxima.EndPoint;

        public PlanoPagamentoPorClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<PlanoPagamentoPorClienteMaxima> list)
        { }
    }
}

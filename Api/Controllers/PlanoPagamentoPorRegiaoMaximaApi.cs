using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PlanoPagamentoPorRegiaoMaximaApi : ApiBase<PlanoPagamentoPorRegiaoMaxima>
    {
        override public string VersaoAPI { get; set; } = PlanoPagamentoPorRegiaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PlanoPagamentoPorRegiaoMaxima.EndPoint;

        public PlanoPagamentoPorRegiaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<PlanoPagamentoPorRegiaoMaxima> list)
        { }
    }
}

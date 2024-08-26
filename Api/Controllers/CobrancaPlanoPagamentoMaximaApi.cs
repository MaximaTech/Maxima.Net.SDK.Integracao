using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CobrancaPlanoPagamentoMaximaApi : ApiBase<CobrancaPlanoPagamentoMaxima>
    {
        override public string VersaoAPI { get; set; } = CobrancaPlanoPagamentoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CobrancaPlanoPagamentoMaxima.EndPoint;
        public CobrancaPlanoPagamentoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CobrancaPlanoPagamentoMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DescontoRestricaoMaximaApi : ApiBase<DescontoRestricaoMaxima>
    {
        override public string VersaoAPI { get; set; } = DescontoRestricaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DescontoRestricaoMaxima.EndPoint;
        public DescontoRestricaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DescontoRestricaoMaxima> list)
        {

        }
    }
}

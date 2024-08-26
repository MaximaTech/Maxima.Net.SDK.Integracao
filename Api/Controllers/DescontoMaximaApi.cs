using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DescontoMaximaApi : ApiBase<DescontoMaxima>
    {
        override public string VersaoAPI { get; set; } = DescontoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DescontoMaxima.EndPoint;
        public DescontoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DescontoMaxima> list)
        {

        }
    }
}

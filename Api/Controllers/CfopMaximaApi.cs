using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CfopMaximaApi : ApiBase<CfopMaxima>
    {
        override public string VersaoAPI { get; set; } = CfopMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CfopMaxima.EndPoint;
        public CfopMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CfopMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrazoAdicionalMaximaApi : ApiBase<PrazoAdicionalMaxima>
    {
        override public string VersaoAPI { get; set; } = PrazoAdicionalMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrazoAdicionalMaxima.EndPoint;
        public PrazoAdicionalMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrazoAdicionalMaxima> list)
        {

        }
    }
}

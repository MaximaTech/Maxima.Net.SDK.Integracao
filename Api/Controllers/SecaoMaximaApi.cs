using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class SecaoMaximaApi : ApiBase<SecaoMaxima>
    {
        override public string VersaoAPI { get; set; } = SecaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = SecaoMaxima.EndPoint;
        public SecaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<SecaoMaxima> list)
        {
        }
    }
}

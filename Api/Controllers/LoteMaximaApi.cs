using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class LoteMaximaApi : ApiBase<LoteMaxima>
    {
        override public string VersaoAPI { get; set; } = LoteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = LoteMaxima.EndPoint;

        public LoteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<LoteMaxima> list)
        {
        }
    }
}

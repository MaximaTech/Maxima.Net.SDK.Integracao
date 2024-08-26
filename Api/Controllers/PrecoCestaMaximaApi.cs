using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrecoCestaMaximaApi : ApiBase<PrecoCestaMaxima>
    {
        override public string VersaoAPI { get; set; } = PrecoCestaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrecoCestaMaxima.EndPoint;
        public PrecoCestaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrecoCestaMaxima> list)
        {

        }
    }
}

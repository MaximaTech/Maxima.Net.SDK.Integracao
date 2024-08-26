using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrecoCestaItemMaximaApi : ApiBase<PrecoCestaItemMaxima>
    {
        override public string VersaoAPI { get; set; } = PrecoCestaItemMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrecoCestaItemMaxima.EndPoint;
        public PrecoCestaItemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrecoCestaItemMaxima> list)
        {

        }
    }
}

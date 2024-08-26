using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class BrindePremioMaximaApi : ApiBase<BrindePremioMaxima>
    {
        override public string VersaoAPI { get; set; } = BrindePremioMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = BrindePremioMaxima.EndPoint;
        public BrindePremioMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<BrindePremioMaxima> list)
        {

        }
    }
}

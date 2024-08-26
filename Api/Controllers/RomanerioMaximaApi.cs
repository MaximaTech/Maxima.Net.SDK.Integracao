using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RomanerioMaximaApi : ApiBase<RomaneioMaxima>
    {
        override public string VersaoAPI { get; set; } = RomaneioMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RomaneioMaxima.EndPoint;
        public RomanerioMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<RomaneioMaxima> list)
        {

        }
    }
}

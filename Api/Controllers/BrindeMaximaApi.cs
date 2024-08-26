using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class BrindeMaximaApi : ApiBase<BrindeMaxima>
    {
        override public string VersaoAPI { get; set; } = BrindeMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = BrindeMaxima.EndPoint;
        public BrindeMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<BrindeMaxima> list)
        {

        }
    }
}

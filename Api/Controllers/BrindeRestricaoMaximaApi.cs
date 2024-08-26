using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class BrindeRestricaoMaximaApi : ApiBase<BrindeRestricaoMaxima>
    {
        override public string VersaoAPI { get; set; } = BrindeRestricaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = BrindeRestricaoMaxima.EndPoint;
        public BrindeRestricaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<BrindeRestricaoMaxima> list)
        {
            foreach (var item in list)
            {
                item.CodigoA = item.CodigoA ?? "0";
            }
        }
    }
}

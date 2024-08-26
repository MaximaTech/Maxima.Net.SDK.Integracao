using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RegiaoMaximaApi : ApiBase<RegiaoMaxima>
    {
        override public string VersaoAPI { get; set; } = RegiaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RegiaoMaxima.EndPoint;
        public RegiaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<RegiaoMaxima> regioes)
        {
        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TributosCapaMaximaApi : ApiBase<TributosCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = TributosCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TributosCapaMaxima.EndPoint;

        public TributosCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<TributosCapaMaxima> tributosCapas)
        {
        }
    }
}

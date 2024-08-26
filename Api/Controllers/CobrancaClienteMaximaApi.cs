using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CobrancaClienteMaximaApi : ApiBase<CobrancaClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = CobrancaClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CobrancaClienteMaxima.EndPoint;
        public CobrancaClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CobrancaClienteMaxima> list)
        {

        }
    }
}

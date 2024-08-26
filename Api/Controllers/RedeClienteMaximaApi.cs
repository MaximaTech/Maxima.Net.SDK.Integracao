using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RedeClienteMaximaApi : ApiBase<RedeClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = RedeClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RedeClienteMaxima.EndPoint;
        public RedeClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<RedeClienteMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrestacaoContaItemMaximaApi : ApiBase<PrestacaoContaItemMaxima>
    {
        override public string VersaoAPI { get; set; } = PrestacaoContaItemMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrestacaoContaItemMaxima.EndPoint;
        public PrestacaoContaItemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrestacaoContaItemMaxima> list)
        {

        }
    }
}

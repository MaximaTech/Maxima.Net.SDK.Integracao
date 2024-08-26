using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrestacaoContaCapaMaximaApi : ApiBase<PrestacaoContaCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = PrestacaoContaCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrestacaoContaCapaMaxima.EndPoint;
        public PrestacaoContaCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrestacaoContaCapaMaxima> list)
        {

        }
    }
}

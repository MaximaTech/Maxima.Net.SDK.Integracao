using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CotacaoCapaMaximaApi : ApiBase<CotacaoCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = CotacaoCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CotacaoCapaMaxima.EndPoint;
        public CotacaoCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CotacaoCapaMaxima> list)
        {

        }
    }
}

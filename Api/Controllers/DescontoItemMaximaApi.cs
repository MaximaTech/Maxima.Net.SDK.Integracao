using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DescontoItemMaximaApi : ApiBase<DescontoItemMaxima>
    {
        override public string VersaoAPI { get; set; } = DescontoItemMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DescontoItemMaxima.EndPoint;
        public DescontoItemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DescontoItemMaxima> list)
        {

        }
    }
}

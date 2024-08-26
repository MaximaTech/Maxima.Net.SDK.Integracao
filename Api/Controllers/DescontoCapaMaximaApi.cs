using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DescontoCapaMaximaApi : ApiBase<DescontoCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = DescontoCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DescontoCapaMaxima.EndPoint;
        public DescontoCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DescontoCapaMaxima> list)
        {

        }
    }
}

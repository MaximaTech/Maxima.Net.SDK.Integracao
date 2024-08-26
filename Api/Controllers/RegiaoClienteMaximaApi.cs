using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RegiaoClienteMaximaApi : ApiBase<RegiaoClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = RegiaoClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RegiaoClienteMaxima.EndPoint;
        public RegiaoClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<RegiaoClienteMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ReferenciaComercialClienteMaximaApi : ApiBase<ReferenciaComercialClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = ReferenciaComercialClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ReferenciaComercialClienteMaxima.EndPoint;
        public ReferenciaComercialClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ReferenciaComercialClienteMaxima> list)
        {

        }
    }
}

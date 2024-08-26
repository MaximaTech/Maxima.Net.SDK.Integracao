using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MotivoNaoCompraMaximaApi : ApiBase<MotivoNaoCompraMaxima>
    {
        override public string VersaoAPI { get; set; } = MotivoNaoCompraMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MotivoNaoCompraMaxima.EndPoint;
        public MotivoNaoCompraMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MotivoNaoCompraMaxima> list)
        {

        }
    }
}

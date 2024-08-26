using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EmbalagemMaximaApi : ApiBase<EmbalagemMaxima>
    {
        public override string VersaoAPI { get; set; } = EmbalagemMaxima.VersaoAPI;
        public override string EndPoint { get; set; } = EmbalagemMaxima.EndPoint;

        public EmbalagemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<EmbalagemMaxima> list)
        { }
    }
}

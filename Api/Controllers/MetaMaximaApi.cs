using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MetaMaximaApi : ApiBase<MetaMaxima>
    {
        override public string VersaoAPI { get; set; } = MetaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MetaMaxima.EndPoint;
        public MetaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MetaMaxima> list)
        {

        }
    }
}

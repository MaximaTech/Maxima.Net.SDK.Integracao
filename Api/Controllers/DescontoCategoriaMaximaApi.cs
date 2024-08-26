using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DescontoCategoriaMaximaApi : ApiBase<DescontoCategoriaMaxima>
    {
        override public string VersaoAPI { get; set; } = DescontoCategoriaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DescontoCategoriaMaxima.EndPoint;
        public DescontoCategoriaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DescontoCategoriaMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EstoqueCestaMaximaApi : ApiBase<EstoqueCestaMaxima>
    {
        override public string VersaoAPI { get; set; } = EstoqueCestaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = EstoqueCestaMaxima.EndPoint;
        public EstoqueCestaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<EstoqueCestaMaxima> list)
        {

        }
    }
}

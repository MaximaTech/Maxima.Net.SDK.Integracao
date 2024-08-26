using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EstadoMaximaApi : ApiBase<EstadoMaxima>
    {
        override public string VersaoAPI { get; set; } = EstadoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = EstadoMaxima.EndPoint;
        public EstadoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<EstadoMaxima> list)
        {

        }
    }
}

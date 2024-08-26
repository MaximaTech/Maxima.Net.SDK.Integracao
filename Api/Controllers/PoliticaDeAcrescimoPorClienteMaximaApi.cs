using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PoliticaDeAcrescimoPorClienteMaximaApi : ApiBase<PoliticaDeAcrescimoPorClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = PoliticaDeAcrescimoPorClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PoliticaDeAcrescimoPorClienteMaxima.EndPoint;
        public PoliticaDeAcrescimoPorClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PoliticaDeAcrescimoPorClienteMaxima> list)
        {

        }
    }
}

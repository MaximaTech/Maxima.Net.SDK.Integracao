using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ContatoMaximaApi : ApiBase<ContatoMaxima>
    {
        override public string VersaoAPI { get; set; } = ContatoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ContatoMaxima.EndPoint;
        public ContatoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<ContatoMaxima> list)
        {

        }
    }
}

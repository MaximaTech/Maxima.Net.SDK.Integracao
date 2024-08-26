using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CidadeMaximaApi : ApiBase<CidadeMaxima>
    {
        override public string VersaoAPI { get; set; } = CidadeMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CidadeMaxima.EndPoint;

        public CidadeMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CidadeMaxima> cidades)
        {
        }
    }
}

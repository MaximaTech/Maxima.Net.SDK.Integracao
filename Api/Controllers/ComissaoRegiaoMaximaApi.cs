using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ComissaoRegiaoMaximaApi : ApiBase<ComissaoRegiaoMaxima>
    {
        override public string VersaoAPI { get; set; } = ComissaoRegiaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ComissaoRegiaoMaxima.EndPoint;
        public ComissaoRegiaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ComissaoRegiaoMaxima> list)
        {
        }
    }
}

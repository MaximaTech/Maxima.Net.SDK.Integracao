using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FilialRegiaoMaximaApi : ApiBase<FilialRegiaoMaxima>
    {
        override public string VersaoAPI { get; set; } = FilialRegiaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FilialRegiaoMaxima.EndPoint;
        public FilialRegiaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FilialRegiaoMaxima> list)
        {

        }
    }
}

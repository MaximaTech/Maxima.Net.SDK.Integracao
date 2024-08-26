using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CategoriaMaximaApi : ApiBase<CategoriaMaxima>
    {
        override public string VersaoAPI { get; set; } = CategoriaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CategoriaMaxima.EndPoint;
        public CategoriaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CategoriaMaxima> list)
        {

        }
    }
}

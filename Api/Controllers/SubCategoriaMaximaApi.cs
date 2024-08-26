using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class SubCategoriaMaximaApi : ApiBase<SubCategoriaMaxima>
    {
        override public string VersaoAPI { get; set; } = SubCategoriaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = SubCategoriaMaxima.EndPoint;
        public SubCategoriaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<SubCategoriaMaxima> list)
        {

        }
    }
}

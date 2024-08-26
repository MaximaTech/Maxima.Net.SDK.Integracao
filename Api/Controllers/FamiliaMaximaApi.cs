using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FamiliaMaximaApi : ApiBase<FamiliaMaxima>
    {
        override public string VersaoAPI { get; set; } = FamiliaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FamiliaMaxima.EndPoint;
        public FamiliaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FamiliaMaxima> listFamilia)
        {
        }
    }
}

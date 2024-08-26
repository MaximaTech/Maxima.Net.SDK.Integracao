using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MarcaMaximaApi : ApiBase<MarcaMaxima>
    {
        override public string VersaoAPI { get; set; } = MarcaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MarcaMaxima.EndPoint;
        public MarcaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MarcaMaxima> list)
        {

        }
    }
}

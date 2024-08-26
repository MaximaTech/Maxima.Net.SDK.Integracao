using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class LimiteComboMaximaApi : ApiBase<LimiteComboMaxima>
    {
        override public string VersaoAPI { get; set; } = LimiteComboMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = LimiteComboMaxima.EndPoint;
        public LimiteComboMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<LimiteComboMaxima> list)
        {

        }
    }
}

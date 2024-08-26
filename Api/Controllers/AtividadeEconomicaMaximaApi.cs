using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class AtividadeEconomicaMaximaApi : ApiBase<AtividadeEconomicaMaxima>
    {
        override public string VersaoAPI { get; set; } = AtividadeEconomicaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = AtividadeEconomicaMaxima.EndPoint;
        public AtividadeEconomicaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<AtividadeEconomicaMaxima> list)
        {

        }
    }
}

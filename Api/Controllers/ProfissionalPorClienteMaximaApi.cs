using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProfissionalPorClienteMaximaApi : ApiBase<ProfissionalPorClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = ProfissionalPorClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProfissionalPorClienteMaxima.EndPoint;
        public ProfissionalPorClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProfissionalPorClienteMaxima> list)
        {

        }
    }
}

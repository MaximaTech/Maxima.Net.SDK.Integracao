using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class DepartamentoMaximaApi : ApiBase<DepartamentoMaxima>
    {
        override public string VersaoAPI { get; set; } = DepartamentoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = DepartamentoMaxima.EndPoint;
        public DepartamentoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<DepartamentoMaxima> departamentos)
        {
        }
    }
}

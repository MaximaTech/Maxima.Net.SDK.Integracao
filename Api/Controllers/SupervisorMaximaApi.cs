using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class SupervisorMaximaApi : ApiBase<SupervisorMaxima>
    {
        override public string VersaoAPI { get; set; } = SupervisorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = SupervisorMaxima.EndPoint;

        public SupervisorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<SupervisorMaxima> supervisorMaximas)
        {
        }
    }
}

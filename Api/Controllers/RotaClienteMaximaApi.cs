using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RotaClienteMaximaApi : ApiBase<RotaClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = RotaClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RotaClienteMaxima.EndPoint;
        public RotaClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<RotaClienteMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ContaBancariaMaximaApi : ApiBase<ContaBancariaMaxima>
    {
        override public string VersaoAPI { get; set; } = ContaBancariaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ContaBancariaMaxima.EndPoint;
        public ContaBancariaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ContaBancariaMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CreditoDisponivelPorClienteMaximaApi : ApiBase<CreditoDisponivelPorClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = CreditoDisponivelPorClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CreditoDisponivelPorClienteMaxima.EndPoint;
        public CreditoDisponivelPorClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CreditoDisponivelPorClienteMaxima> list)
        {

        }
    }
}

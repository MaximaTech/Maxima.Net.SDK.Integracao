using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MovimentoVendaPendenteWMSMaximaApi : ApiBase<MovimentoVendaPendenteWMSMaxima>
    {
        override public string VersaoAPI { get; set; } = MovimentoVendaPendenteWMSMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MovimentoVendaPendenteWMSMaxima.EndPoint;

        public MovimentoVendaPendenteWMSMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MovimentoVendaPendenteWMSMaxima> movimentoVendaPendenteWMs)
        {
        }
    }
}

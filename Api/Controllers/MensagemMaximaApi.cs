using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MensagemMaximaApi : ApiBase<MensagemMaxima>
    {
        override public string VersaoAPI { get; set; } = MensagemMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MensagemMaxima.EndPoint;
        public MensagemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MensagemMaxima> list)
        {
            foreach (var item in list)
            {
                item.Status = item.Status ?? "0";
            }
        }
    }
}

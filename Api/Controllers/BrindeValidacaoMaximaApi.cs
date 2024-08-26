using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class BrindeValidacaoMaximaApi : ApiBase<BrindeValidacaoMaxima>
    {
        override public string VersaoAPI { get; set; } = BrindeValidacaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = BrindeValidacaoMaxima.EndPoint;
        public BrindeValidacaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<BrindeValidacaoMaxima> list)
        {

        }
    }
}

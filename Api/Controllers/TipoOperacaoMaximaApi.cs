using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TipoOperacaoMaximaApi : ApiBase<TipoOperacaoMaxima>
    {
        override public string VersaoAPI { get; set; } = TipoOperacaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TipoOperacaoMaxima.EndPoint;
        public TipoOperacaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<TipoOperacaoMaxima> list)
        {

        }
    }
}

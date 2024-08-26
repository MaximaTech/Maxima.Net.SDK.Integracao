using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CotacaoItensMaximaApi : ApiBase<CotacaoItensMaxima>
    {
        override public string VersaoAPI { get; set; } = CotacaoItensMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CotacaoItensMaxima.EndPoint;
        public CotacaoItensMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CotacaoItensMaxima> list)
        {

        }
    }
}

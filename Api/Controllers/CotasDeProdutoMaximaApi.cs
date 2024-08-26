using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CotasDeProdutoMaximaApi : ApiBase<CotasDeProdutoMaxima>
    {
        override public string VersaoAPI { get; set; } = CotasDeProdutoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CotasDeProdutoMaxima.EndPoint;
        public CotasDeProdutoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CotasDeProdutoMaxima> list)
        {

        }
    }
}

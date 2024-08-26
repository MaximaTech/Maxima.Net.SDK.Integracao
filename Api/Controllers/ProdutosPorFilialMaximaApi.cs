using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutosPorFilialMaximaApi : ApiBase<ProdutosPorFilialMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutosPorFilialMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutosPorFilialMaxima.EndPoint;
        public ProdutosPorFilialMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProdutosPorFilialMaxima> list)
        {

        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutoSimilarMaximaApi : ApiBase<ProdutoSimilarMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutoSimilarMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutoSimilarMaxima.EndPoint;
        public ProdutoSimilarMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProdutoSimilarMaxima> list)
        {

        }
    }
}

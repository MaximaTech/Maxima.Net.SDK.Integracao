using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutoAgregadoMaximaApi : ApiBase<ProdutoAgregadoMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutoAgregadoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutoAgregadoMaxima.EndPoint;
        public ProdutoAgregadoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProdutoAgregadoMaxima> list)
        {

        }
    }
}

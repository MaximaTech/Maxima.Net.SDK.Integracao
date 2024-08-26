using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MixProdutoClienteMaximaApi : ApiBase<MixProdutoClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = MixProdutoClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MixProdutoClienteMaxima.EndPoint;
        public MixProdutoClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MixProdutoClienteMaxima> list)
        {

        }
    }
}

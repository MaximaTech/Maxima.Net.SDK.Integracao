using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutoCestaMaximaApi : ApiBase<ProdutoCestaMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutoCestaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutoCestaMaxima.EndPoint;
        public ProdutoCestaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProdutoCestaMaxima> list)
        {

        }
    }
}

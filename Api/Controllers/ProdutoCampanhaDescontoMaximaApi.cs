using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutoCampanhaDescontoMaximaApi : ApiBase<ProdutoCampanhaDescontoMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutoCampanhaDescontoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutoCampanhaDescontoMaxima.EndPoint;
        public ProdutoCampanhaDescontoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ProdutoCampanhaDescontoMaxima> list)
        {

        }
    }
}

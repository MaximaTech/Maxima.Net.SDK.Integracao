using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PlanoPagamentoPorProdutoMaximaApi : ApiBase<PlanoPagamentoPorProdutoMaxima>
    {
        override public string VersaoAPI { get; set; } = PlanoPagamentoPorProdutoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PlanoPagamentoPorProdutoMaxima.EndPoint;

        public PlanoPagamentoPorProdutoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<PlanoPagamentoPorProdutoMaxima> list)
        { }
    }
}

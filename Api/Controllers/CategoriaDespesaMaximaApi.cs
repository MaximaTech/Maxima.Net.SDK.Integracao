using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CategoriaDespesaMaximaApi : ApiBase<CategoriaDespesaMaxima>
    {
        override public string VersaoAPI { get; set; } = CategoriaDespesaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CategoriaDespesaMaxima.EndPoint;
        public CategoriaDespesaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<CategoriaDespesaMaxima> list)
        {

        }
    }
}

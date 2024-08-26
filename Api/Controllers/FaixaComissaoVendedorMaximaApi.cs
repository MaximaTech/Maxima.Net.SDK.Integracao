using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FaixaComissaoVendedorMaximaApi : ApiBase<FaixaComissaoVendedorMaxima>
    {
        override public string VersaoAPI { get; set; } = FaixaComissaoVendedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FaixaComissaoVendedorMaxima.EndPoint;
        public FaixaComissaoVendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FaixaComissaoVendedorMaxima> list)
        {

        }
    }
}

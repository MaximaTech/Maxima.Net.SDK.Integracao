using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class VendedorFornecedorMaximaApi : ApiBase<VendedorFornecedorMaxima>
    {
        override public string VersaoAPI { get; set; } = VendedorFornecedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = VendedorFornecedorMaxima.EndPoint;
        public VendedorFornecedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<VendedorFornecedorMaxima> list)
        {

        }
    }
}

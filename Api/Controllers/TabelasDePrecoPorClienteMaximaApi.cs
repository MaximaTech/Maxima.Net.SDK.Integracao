using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TabelasDePrecoPorClienteMaximaApi : ApiBase<TabelasDePrecoPorClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = TabelasDePrecoPorClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TabelasDePrecoPorClienteMaxima.EndPoint;

        public TabelasDePrecoPorClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        { }

        internal override void DefinirCamposDefault(List<TabelasDePrecoPorClienteMaxima> list)
        { }
    }
}

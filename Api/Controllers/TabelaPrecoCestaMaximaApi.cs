using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TabelaPrecoCestaMaximaApi : ApiBase<TabelaPrecoCestaMaxima>
    {
        override public string VersaoAPI { get; set; } = TabelaPrecoCestaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TabelaPrecoCestaMaxima.EndPoint;
        public TabelaPrecoCestaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<TabelaPrecoCestaMaxima> list)
        {

        }
    }
}

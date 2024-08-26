using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class BancoMaximaApi : ApiBase<BancoMaxima>
    {
        override public string VersaoAPI { get; set; } = BancoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = BancoMaxima.EndPoint;
        public BancoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<BancoMaxima> list)
        {

        }
    }
}

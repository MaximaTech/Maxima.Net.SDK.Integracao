using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class SetorMaximaApi : ApiBase<SetorMaxima>
    {
        public SetorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        public override string VersaoAPI { get; set; } = SetorMaxima.VersaoAPI;
        public override string EndPoint { get; set; } = SetorMaxima.EndPoint;

        internal override void DefinirCamposDefault(List<SetorMaxima> list)
        { }
    }
}

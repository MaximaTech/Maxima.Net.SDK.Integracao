using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PracaMaximaApi : ApiBase<PracaMaxima>
    {
        override public string VersaoAPI { get; set; } = PracaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PracaMaxima.EndPoint;

        public PracaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PracaMaxima> pracas)
        {

        }
    }
}

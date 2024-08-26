using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TransportadoraMaximaApi : ApiBase<TransportadoraMaxima>
    {
        override public string VersaoAPI { get; set; } = TransportadoraMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TransportadoraMaxima.EndPoint;
        public TransportadoraMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<TransportadoraMaxima> transportadoras)
        {
            foreach (var transportadora in transportadoras)
            {
                transportadora.ERedespacho = transportadora.ERedespacho ?? "N";
                transportadora.Revenda = transportadora.Revenda ?? "N";
            }
        }
    }
}

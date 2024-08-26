using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class NotaFiscalStatusEntregaMaximaApi : ApiBase<NotaFiscalStatusEntregaMaxima>
    {
        private readonly IApiMaxima _api;
        override public string VersaoAPI { get; set; } = NotaFiscalStatusEntregaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = NotaFiscalStatusEntregaMaxima.EndPoint;
        public NotaFiscalStatusEntregaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
            _api = apiMaxima;
        }

        override internal void DefinirCamposDefault(List<NotaFiscalStatusEntregaMaxima> list)
        {

        }
    }
}

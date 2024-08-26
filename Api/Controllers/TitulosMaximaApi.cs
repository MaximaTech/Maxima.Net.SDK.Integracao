using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TitulosMaximaApi : ApiBase<TitulosMaxima>
    {
        override public string VersaoAPI { get; set; } = TitulosMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TitulosMaxima.EndPoint;
        public TitulosMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<TitulosMaxima> list)
        {
            foreach (var erpPrest in list)
            {
                erpPrest.CodigoCobranca = erpPrest.CodigoCobranca ?? "15";
                erpPrest.Valor = erpPrest.Valor ?? 0;
                erpPrest.ValorOriginal = erpPrest.ValorOriginal ?? 0;
            }
        }
    }
}

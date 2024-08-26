using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class MotivoDevolucaoMaximaApi : ApiBase<MotivoDevolucaoMaxima>
    {
        override public string VersaoAPI { get; set; } = MotivoDevolucaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = MotivoDevolucaoMaxima.EndPoint;
        public MotivoDevolucaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<MotivoDevolucaoMaxima> list)
        {
            foreach (var item in list)
            {
                item.Tipo = item.Tipo ?? "ED";
            }
        }
    }
}

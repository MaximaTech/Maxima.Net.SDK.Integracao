using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class VeiculoMaximaApi : ApiBase<VeiculoMaxima>
    {
        public VeiculoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        override public string VersaoAPI { get; set; } = VeiculoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = VeiculoMaxima.EndPoint;

        internal override void DefinirCamposDefault(List<VeiculoMaxima> list)
        {
            foreach (var item in list)
            {
                item.Volume = item.Volume ?? 0;
                item.PesoCarga = item.PesoCarga ?? 0;
            }
        }
    }
}

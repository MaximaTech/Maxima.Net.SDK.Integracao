using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CarregamentoMaximaApi : ApiBase<CarregamentoMaxima>
    {
        public CarregamentoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        override public string VersaoAPI { get; set; } = CarregamentoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CarregamentoMaxima.EndPoint;

        internal override void DefinirCamposDefault(List<CarregamentoMaxima> list)
        {
            foreach (var item in list)
            {
                item.QuantidadeNotas = item.QuantidadeNotas ?? 0;
                item.TotalPeso = item.TotalPeso ?? 0;
                item.TotalVolume = item.TotalVolume ?? 0;
                item.ValorTotal = item.ValorTotal ?? 0;
            }
        }
    }
}

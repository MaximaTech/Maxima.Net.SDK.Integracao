using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class RamoAtividadeMaximaApi : ApiBase<RamoAtividadeMaxima>
    {
        override public string VersaoAPI { get; set; } = RamoAtividadeMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = RamoAtividadeMaxima.EndPoint;
        public RamoAtividadeMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<RamoAtividadeMaxima> list)
        {
            foreach (var item in list)
            {
                item.CalcularST = item.CalcularST ?? "N";
                item.PercentualDescontoTabelaPreco = item.PercentualDescontoTabelaPreco ?? 0;
            }
        }
    }
}

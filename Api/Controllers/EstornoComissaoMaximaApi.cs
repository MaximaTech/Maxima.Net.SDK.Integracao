using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EstornoComissaoMaximaApi : ApiBase<EstornoComissaoMaxima>
    {
        override public string VersaoAPI { get; set; } = EstornoComissaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = EstornoComissaoMaxima.EndPoint;
        public EstornoComissaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<EstornoComissaoMaxima> list)
        {
            list.ForEach(item =>
            {
                item.ValorEstorno = item.ValorEstorno ?? 0;
            });
        }
    }
}

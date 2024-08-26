using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class NotaFiscalEntradaCapaMaximaApi : ApiBase<NotaFiscalEntradaCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = NotaFiscalEntradaCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = NotaFiscalEntradaCapaMaxima.EndPoint;
        public NotaFiscalEntradaCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<NotaFiscalEntradaCapaMaxima> list)
        {
            foreach (var item in list)
            {
                item.CodigoMotivoDevolucao = item.CodigoMotivoDevolucao ?? "1";
                item.TotalPeso = item.TotalPeso ?? 0;
                item.ValorFrete = item.ValorFrete ?? 0;
                item.ValorSituacaoTributaria = item.ValorSituacaoTributaria ?? 0;
            }
        }
    }
}

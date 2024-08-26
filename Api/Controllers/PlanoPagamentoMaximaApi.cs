using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PlanoPagamentoMaximaApi : ApiBase<PlanoPagamentoMaxima>
    {
        override public string VersaoAPI { get; set; } = PlanoPagamentoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PlanoPagamentoMaxima.EndPoint;
        public PlanoPagamentoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<PlanoPagamentoMaxima> planosPagamentos)
        {
            foreach (var item in planosPagamentos)
            {
                item.NumColunaTabelaPreco = item.NumColunaTabelaPreco ?? 1;
                item.ValorMinimoPedido = item.ValorMinimoPedido ?? 0;
                item.TipoPrazo = item.TipoPrazo ?? "N";
                item.AceitaVendaBoleto = item.AceitaVendaBoleto ?? "S";
                item.PrazoMedio = item.PrazoMedio ?? 0;
                item.TipoDeEntrada = item.TipoDeEntrada ?? 3;
            }

        }

    }
}

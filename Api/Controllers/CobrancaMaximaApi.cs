using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class CobrancaMaximaApi : ApiBase<CobrancaMaxima>
    {
        override public string VersaoAPI { get; set; } = CobrancaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = CobrancaMaxima.EndPoint;

        public CobrancaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<CobrancaMaxima> cobrancas)
        {
            foreach (var cobranca in cobrancas)
            {
                cobranca.Nivelvenda = cobranca.Nivelvenda ?? 1;
                cobranca.PrazoMaximoVenda = cobranca.PrazoMaximoVenda ?? 999;
                cobranca.ValorMinimoVendaPedido = cobranca.ValorMinimoVendaPedido ?? 0;
                cobranca.Cartao = cobranca.Cartao ?? "N";
                cobranca.Boleto = cobranca.Boleto ?? "N";
                cobranca.CobrancaBroker = cobranca.CobrancaBroker ?? "N";
            }
        }
    }
}

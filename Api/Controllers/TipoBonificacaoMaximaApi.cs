using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TipoBonificacaoMaximaApi : ApiBase<TipoBonificacaoMaxima>
    {
        override public string VersaoAPI { get; set; } = TipoBonificacaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TipoBonificacaoMaxima.EndPoint;
        public TipoBonificacaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<TipoBonificacaoMaxima> list)
        {
            foreach (var item in list)
            {
                item.CalcularIpi = item.CalcularIpi ?? "N";
                item.MovimentarContaCorrenteVendedor = item.MovimentarContaCorrenteVendedor ?? "N";
            }

        }
    }
}

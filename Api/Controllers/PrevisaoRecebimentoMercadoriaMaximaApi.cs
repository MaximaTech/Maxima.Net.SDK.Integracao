using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrevisaoRecebimentoMercadoriaMaximaApi : ApiBase<PrevisaoRecebimentoMercadoriaMaxima>
    {
        override public string VersaoAPI { get; set; } = PrevisaoRecebimentoMercadoriaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrevisaoRecebimentoMercadoriaMaxima.EndPoint;
        public PrevisaoRecebimentoMercadoriaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrevisaoRecebimentoMercadoriaMaxima> list)
        {
            foreach (var item in list)
            {
                item.Situacao = item.Situacao ?? "PN";
            }
        }
    }
}

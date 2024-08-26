using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TributosItemMaximaApi : ApiBase<TributosItemMaxima>
    {
        override public string VersaoAPI { get; set; } = TributosItemMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TributosItemMaxima.EndPoint;
        public TributosItemMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<TributosItemMaxima> list)
        {
            foreach (var item in list)
            {
                item.CodigoOperacao = item.CodigoOperacao ?? 0;
            }
        }
    }
}

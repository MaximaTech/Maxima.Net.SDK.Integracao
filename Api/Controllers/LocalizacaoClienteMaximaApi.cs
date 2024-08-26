using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class LocalizacaoClienteMaximaApi : ApiBase<LocalizacaoClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = LocalizacaoClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = LocalizacaoClienteMaxima.EndPoint;
        public LocalizacaoClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<LocalizacaoClienteMaxima> list)
        {
            list.ForEach(x =>
            {
                x.EhPorCep = x.EhPorCep ?? "N";
            });
        }
    }
}

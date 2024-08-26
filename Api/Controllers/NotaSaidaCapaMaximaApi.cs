using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class NotaSaidaCapaMaximaApi : ApiBase<NotaSaidaCapaMaxima>
    {
        override public string VersaoAPI { get; set; } = NotaSaidaCapaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = NotaSaidaCapaMaxima.EndPoint;

        public NotaSaidaCapaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<NotaSaidaCapaMaxima> notaSaidaCapaMaximas)
        {
        }
    }
}

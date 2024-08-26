using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class NotaSaidaItensMaximaApi : ApiBase<NotaSaidaItensMaxima>
    {
        override public string VersaoAPI { get; set; } = NotaSaidaItensMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = NotaSaidaItensMaxima.EndPoint;
        public NotaSaidaItensMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        override internal void DefinirCamposDefault(List<NotaSaidaItensMaxima> list)
        {

        }
    }
}

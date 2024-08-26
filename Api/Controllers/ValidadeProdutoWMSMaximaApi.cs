using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ValidadeProdutoWMSMaximaApi : ApiBase<ValidadeProdutoWMSMaxima>
    {
        override public string VersaoAPI { get; set; } = ValidadeProdutoWMSMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ValidadeProdutoWMSMaxima.EndPoint;
        public ValidadeProdutoWMSMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ValidadeProdutoWMSMaxima> list)
        {

        }
    }
}

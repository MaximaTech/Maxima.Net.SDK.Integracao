using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ComissaoProfissionalMaximaApi : ApiBase<ComissaoProfissionalMaxima>
    {
        override public string VersaoAPI { get; set; } = ComissaoProfissionalMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ComissaoProfissionalMaxima.EndPoint;
        public ComissaoProfissionalMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ComissaoProfissionalMaxima> list)
        {

        }
    }
}

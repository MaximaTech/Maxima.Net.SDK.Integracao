using System;
using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EnderecoClienteMaximaApi : ApiBase<EnderecoClienteMaxima>
    {
        public override string VersaoAPI { get; set; } = EnderecoClienteMaxima.VersaoAPI;
        public override string EndPoint { get; set; } = EnderecoClienteMaxima.EndPoint;

        public EnderecoClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<EnderecoClienteMaxima> list)
        {
        }
    }
}

using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FilialRetiradaEstoqueMaximaApi : ApiBase<FilialRetiradaEstoqueMaxima>
    {
        override public string VersaoAPI { get; set; } = FilialRetiradaEstoqueMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FilialRetiradaEstoqueMaxima.EndPoint;
        public FilialRetiradaEstoqueMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FilialRetiradaEstoqueMaxima> list)
        {

        }
    }
}

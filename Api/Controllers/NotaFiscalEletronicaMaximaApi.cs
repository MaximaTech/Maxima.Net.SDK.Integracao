using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class NotaFiscalEletronicaMaximaApi : ApiBase<NotaFiscalEletronicaMaxima>
    {
        public NotaFiscalEletronicaMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        override public string VersaoAPI { get; set; } = NotaFiscalEletronicaMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = NotaFiscalEletronicaMaxima.EndPoint;

        internal override void DefinirCamposDefault(List<NotaFiscalEletronicaMaxima> list)
        { }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FilialMaximaApi : ApiBase<FilialMaxima>
    {
        override public string VersaoAPI { get; set; } = FilialMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FilialMaxima.EndPoint;
        public FilialMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FilialMaxima> filiais)
        {
            foreach (var filial in filiais)
            {
                filial.UtilizaWMS = filial.UtilizaWMS ?? "N";
                filial.TipoPrecificacao = filial.TipoPrecificacao ?? "A";
                filial.FilialUtilizaVendaPorEmbalagem = filial.FilialUtilizaVendaPorEmbalagem ?? "N";
                filial.CalcularIpiNaVenda = filial.CalcularIpiNaVenda ?? "N";
            }
        }
    }
}

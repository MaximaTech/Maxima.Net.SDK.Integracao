using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class VisitaVendedorMaximaApi : ApiBase<VisitaVendedorMaxima>
    {
        public VisitaVendedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        public override string VersaoAPI { get; set; } = VisitaVendedorMaxima.VersaoAPI;
        public override string EndPoint { get; set; } = VisitaVendedorMaxima.EndPoint;

        internal override void DefinirCamposDefault(List<VisitaVendedorMaxima> list)
        {
            list.ForEach(item =>
            {
                if (item.DataProximaVisita is not null)
                    item.NumeroDaSemanaDoMes = 1;
                else
                    item.DataProximaVisita = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            });
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ClienteMaximaApi : ApiBase<ClienteMaxima>
    {
        override public string VersaoAPI { get; set; } = ClienteMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ClienteMaxima.EndPoint;

        public ClienteMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ClienteMaxima> clientes)
        {
            foreach (var cliente in clientes)
            {
                cliente.Contribuinte = cliente.Contribuinte ?? "N";
                cliente.ConsumidorFinal = cliente.ConsumidorFinal ?? "N";
                cliente.AceitaVendaFracionada = cliente.AceitaVendaFracionada ?? "N";
                cliente.CalcularST = cliente.CalcularST ?? "N";
                cliente.ValidarMultiploVenda = cliente.ValidarMultiploVenda ?? "S";
                cliente.ValidarCampanhaBrinde = cliente.ValidarCampanhaBrinde ?? "N";
                cliente.UsaVendaPadrao = cliente.UsaVendaPadrao ?? "S";
                cliente.UsaVendaBonificada = cliente.UsaVendaBonificada ?? "S";
                cliente.UsaVendaEntregaFutura = cliente.UsaVendaEntregaFutura ?? "N";
                cliente.UsaVendaSimplesEntrega = cliente.UsaVendaSimplesEntrega ?? "N";
                cliente.UsaVendaNormal = cliente.UsaVendaNormal ?? "N";
                cliente.UsaVendaComTroca = cliente.UsaVendaComTroca ?? "N";
                cliente.UsaVendaSimplesRemessa = cliente.UsaVendaSimplesRemessa ?? "N";
                cliente.UsaVendaManifesto = cliente.UsaVendaManifesto ?? "N";
                cliente.UsaVendaConsignada = cliente.UsaVendaConsignada ?? "N";
                cliente.SimplesNacional = cliente.SimplesNacional ?? "N";
                cliente.UsaDebitoECreditoDoContaCorrente = cliente.UsaDebitoECreditoDoContaCorrente ?? "S";
                cliente.CodigoCobranca = cliente.CodigoCobranca ?? "01";
                cliente.InscricaoEstadual = cliente.InscricaoEstadual ?? "ISENTO";
                cliente.BloqueioVenda = cliente.BloqueioVenda ?? "N";
                cliente.Codfuncultalter = "1";
                cliente.BloqueioSefaz = cliente.BloqueioSefaz ?? "N";

            }
        }
    }
}

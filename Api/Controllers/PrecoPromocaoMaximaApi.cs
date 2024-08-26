using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class PrecoPromocaoMaximaApi : ApiBase<PrecoPromocaoMaxima>
    {
        override public string VersaoAPI { get; set; } = PrecoPromocaoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = PrecoPromocaoMaxima.EndPoint;
        public PrecoPromocaoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<PrecoPromocaoMaxima> list)
        {
            foreach (var item in list)
            {
                item.EnviaForcaVenda = item.EnviaForcaVenda ?? "S";
                item.AceitaAcrescimoPrecoFixo = item.AceitaAcrescimoPrecoFixo ?? "N";
                item.AceitaDescPrecofixo = item.AceitaDescPrecofixo ?? "N";
                item.AgregarST = item.AgregarST ?? "N";
                item.ApenasPlanoPagamentoMax = item.ApenasPlanoPagamentoMax ?? "N";
                item.AplicaDescontoSimplesNacional = item.AplicaDescontoSimplesNacional ?? "N";
                item.ConsideraPrecoSemImposto = item.ConsideraPrecoSemImposto ?? "N";
                item.UtilizaPrecoFixoFamilia = item.UtilizaPrecoFixoFamilia ?? "N";
                item.UtilizaPrecoFixoRede = item.UtilizaPrecoFixoRede ?? "N";
                item.OrigemPedido = item.OrigemPedido ?? "F";
            }
        }
    }
}

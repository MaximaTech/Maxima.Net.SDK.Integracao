using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ConfiguracaoERPMaximaApi : ApiBase<ConfiguracaoERPMaxima>
    {
        override public string VersaoAPI { get; set; } = ConfiguracaoERPMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ConfiguracaoERPMaxima.EndPoint;
        public ConfiguracaoERPMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<ConfiguracaoERPMaxima> list)
        {
            foreach (var item in list)
            {
                item.AceitaVendaSemEstoque = item.AceitaVendaSemEstoque ?? "S";
                item.CalculaStFontePessoaFisica = item.CalculaStFontePessoaFisica ?? "N";
                item.CalculaStPessoaFisica = item.CalculaStPessoaFisica ?? "N";
                item.CalculaStComIpi = item.CalculaStComIpi ?? "N";
                item.UtilizaVendaPorEmbalagem = item.UtilizaVendaPorEmbalagem ?? "N";
                item.UtilizaTributacaopPorUf = item.UtilizaTributacaopPorUf ?? "N";
                item.ValidaPrecoMinimo = item.ValidaPrecoMinimo ?? "N";

            }

        }
    }
}

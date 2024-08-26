using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class TabelaPrecoMaximaApi : ApiBase<TabelaPrecoMaxima>
    {
        override public string VersaoAPI { get; set; } = TabelaPrecoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = TabelaPrecoMaxima.EndPoint;
        public TabelaPrecoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }
        internal override void DefinirCamposDefault(List<TabelaPrecoMaxima> list)
        {
            foreach (var item in list)
            {
                item.CodigoTributacaoProduto = item.CodigoTributacaoProduto ?? "1";
                item.PercDescontoMaximo = item.PercDescontoMaximo ?? 0;
                item.PrecoTabela = item.PrecoTabela ?? 0;
            }
        }
    }
}

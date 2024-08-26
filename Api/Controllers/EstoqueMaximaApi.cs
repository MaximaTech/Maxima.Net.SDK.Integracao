using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EstoqueMaximaApi : ApiBase<EstoqueMaxima>
    {
        override public string VersaoAPI { get; set; } = EstoqueMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = EstoqueMaxima.EndPoint;

        public EstoqueMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<EstoqueMaxima> listEstoque)
        {
            foreach (var item in listEstoque)
            {
                item.QtdEstoqueReservado = item.QtdEstoqueReservado ?? 0;
                item.QtdEstoqueBloqueado = item.QtdEstoqueBloqueado ?? 0;
                item.ValorUltimaEntrada = item.ValorUltimaEntrada ?? 0;
                item.QtdEstoquePendente = item.QtdEstoquePendente ?? 0;
                item.CustoReal = item.CustoReal ?? 0;
                item.CustoReposicao = item.CustoReposicao ?? 0;
            }
        }
    }
}

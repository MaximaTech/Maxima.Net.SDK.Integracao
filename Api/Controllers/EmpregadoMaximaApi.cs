using System.Collections.Generic;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class EmpregadoMaximaApi : ApiBase<EmpregadoMaxima>
    {
        public EmpregadoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima)
        {
        }

        public override string VersaoAPI { get; set; } = EmpregadoMaxima.VersaoAPI;
        public override string EndPoint { get; set; } = EmpregadoMaxima.EndPoint;
        internal override void DefinirCamposDefault(List<EmpregadoMaxima> list)
        {
            foreach (var item in list)
            {
                item.Situacao = string.IsNullOrEmpty(item.Situacao) ? "A" : item.Situacao;
            }
        }
    }
}

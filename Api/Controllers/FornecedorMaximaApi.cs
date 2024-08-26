using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class FornecedorMaximaApi : ApiBase<FornecedorMaxima>
    {
        override public string VersaoAPI { get; set; } = FornecedorMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = FornecedorMaxima.EndPoint;
        public FornecedorMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { }

        internal override void DefinirCamposDefault(List<FornecedorMaxima> fornecedores)
        {

        }
    }
}

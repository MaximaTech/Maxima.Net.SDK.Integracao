using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api.Controllers
{
    internal class ProdutoMaximaApi : ApiBase<ProdutoMaxima>
    {
        override public string VersaoAPI { get; set; } = ProdutoMaxima.VersaoAPI;
        override public string EndPoint { get; set; } = ProdutoMaxima.EndPoint;
        public IApiMaxima _api { get; set; }
        public ProdutoMaximaApi(IApiMaxima apiMaxima) : base(apiMaxima) { _api = apiMaxima; }

        internal override async Task<ResponseApiMaxima<ProdutoMaxima>> Incluir(List<ProdutoMaxima> listProdutos)
        {
            ResponseApiMaxima<ProdutoMaxima> retorno = new ResponseApiMaxima<ProdutoMaxima>();
            DefinirCamposDefault(listProdutos);

            retorno = await base.Incluir(listProdutos);
            if (retorno.Sucesso)
            {
                var listProdFilial = listProdutos.Select(p => MontarprodutoPorFilial(p)).ToList();
                await _api.Post(ProdutosPorFilialMaxima.VersaoAPI, ProdutosPorFilialMaxima.EndPoint, listProdFilial);
            }

            return retorno;
        }


        internal override void DefinirCamposDefault(List<ProdutoMaxima> produtos)
        {
            foreach (var produto in produtos)
            {
                produto.Revenda = produto.Revenda ?? "S";
                produto.AceitavendaFracao = produto.AceitavendaFracao ?? "N";
                produto.TipoMercadoria = produto.TipoMercadoria ?? "L";
                produto.TipoEstoque = produto.TipoEstoque ?? "PA";
                produto.Multiplo = produto.Multiplo ?? 1;
                produto.QtdUnitaria = produto.QtdUnitaria ?? 1;
                produto.QtdUnitariaCaixa = produto.QtdUnitariaCaixa ?? 0;
                produto.Enviarforcavendas = "S";
                produto.PesoLiquido = produto.PesoLiquido ?? 0;
                produto.PesoBruto = produto.PesoBruto ?? 0;
            }
        }

        public ProdutosPorFilialMaxima MontarprodutoPorFilial(ProdutoMaxima produto)
        {
            ProdutosPorFilialMaxima produtoFilial = new()
            {
                CodigoFilial = produto.CodigoFilial,
                CodigoProduto = produto.CodigoProduto,
                Multiplo = 1,
                EnviarForcaVendas = "S",
                ProibidaVenda = "N"
            };
            return produtoFilial;
        }


    }
}

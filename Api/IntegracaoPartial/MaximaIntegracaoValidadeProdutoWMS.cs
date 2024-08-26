using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Validade de Produtos WMS para ser incluida na api máxima.
        /// </summary>
        /// <param name="validadeProdutos">Representação de uma lista de Validade de Produtos WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ValidadeProdutoWMSMaxima>> IncluirValidadeProdutosWms(List<ValidadeProdutoWMSMaxima> validadeProdutos)
        {
            return _validadeProdutoWMSMaximaApi.Incluir(validadeProdutos);
        }

        /// <summary>
        /// Envia uma lista de Validade de Produtos WMS para ser alterada na api máxima, se a validade de produto não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="validadeProdutos">Representação de uma lista de Validade de Produtos WMS</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ValidadeProdutoWMSMaxima>> AlterarValidadeProdutosWms(List<ValidadeProdutoWMSMaxima> validadeProdutos)
        {
            return _validadeProdutoWMSMaximaApi.Alterar(validadeProdutos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Validade de Produtos WMS para ser excluida.
        /// </summary>
        /// <param name="validadeProdutos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarValidadeProdutosWms(string[] validadeProdutos)
        {
            return _validadeProdutoWMSMaximaApi.Deletar(validadeProdutos);
        }
    }
}

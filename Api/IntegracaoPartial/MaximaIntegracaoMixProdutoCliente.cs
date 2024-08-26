using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Mix de cliente para ser incluida na api máxima.
        /// </summary>
        /// <param name="mixProdutoClientes">Representação de uma lista de Mix de cliente</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MixProdutoClienteMaxima>> IncluirMixProdutoClientes(List<MixProdutoClienteMaxima> mixProdutoClientes)
        {
            return _mixProdutoClienteMaximaApi.Incluir(mixProdutoClientes);
        }

        /// <summary>
        /// Envia uma lista de Mix de cliente para ser alterada na api máxima, se o Mix de cliente não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="mixProdutoClientes">Representação de uma lista de Mix de cliente</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MixProdutoClienteMaxima>> AlterarMixProdutoClientes(List<MixProdutoClienteMaxima> mixProdutoClientes)
        {
            return _mixProdutoClienteMaximaApi.Alterar(mixProdutoClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Mix de cliente para ser excluida.
        /// </summary>
        /// <param name="mixProdutoClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMixProdutoClientes(string[] mixProdutoClientes)
        {
            return _mixProdutoClienteMaximaApi.Deletar(mixProdutoClientes);
        }
    }
}

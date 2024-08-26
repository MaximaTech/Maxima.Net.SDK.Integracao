using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Fornecedor para ser incluida na api máxima.
        /// </summary>
        /// <param name="fornecedores">Representação de uma lista de Fornecedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FornecedorMaxima>> IncluirFornecedores(List<FornecedorMaxima> fornecedores)
        {
            return _fornecedorMaximaApi.Incluir(fornecedores);
        }

        /// <summary>
        /// Envia uma lista de Fornecedor para ser alterada na api máxima, se o fornecedor não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="fornecedores">Representação de uma lista de Fornecedor</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FornecedorMaxima>> AlterarFornecedores(List<FornecedorMaxima> fornecedores)
        {
            return _fornecedorMaximaApi.Alterar(fornecedores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Fornecedor para ser excluida.
        /// </summary>
        /// <param name="fornecedores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFornecedor(string[] fornecedores)
        {
            return _fornecedorMaximaApi.Deletar(fornecedores);
        }
    }
}

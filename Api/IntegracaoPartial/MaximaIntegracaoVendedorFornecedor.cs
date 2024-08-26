using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="VendedorFornecedorMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="vendedoresFornecedores">Representação de uma lista de <see cref="VendedorFornecedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<VendedorFornecedorMaxima>> IncluirVendedoresFornecedores(List<VendedorFornecedorMaxima> vendedoresFornecedores)
        {
            return _vendedorFornecedorApi.Incluir(vendedoresFornecedores);
        }

        /// <summary>
        /// Envia uma lista de <see cref="VendedorFornecedorMaxima"/> para ser alterada na api máxima, se a <see cref="VendedorFornecedorMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="vendedoresFornecedores">Representação de uma lista de <see cref="VendedorFornecedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VendedorFornecedorMaxima>> AlterarVendedoresFornecedores(List<VendedorFornecedorMaxima> vendedoresFornecedores)
        {
            return _vendedorFornecedorApi.Alterar(vendedoresFornecedores);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="VendedorFornecedorMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="vendedoresFornecedores">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarVendedoresFornecedores(string[] vendedoresFornecedores)
        {
            return _vendedorFornecedorApi.Deletar(vendedoresFornecedores);
        }
    }
}

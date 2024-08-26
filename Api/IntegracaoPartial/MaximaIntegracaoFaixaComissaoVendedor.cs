using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="FaixaComissaoVendedorMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="faixasComissaoVendedor">Representação de uma lista de <see cref="FaixaComissaoVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<FaixaComissaoVendedorMaxima>> IncluirFaixasComissaoVendedor(List<FaixaComissaoVendedorMaxima> faixasComissaoVendedor)
        {
            return _faixaComissaoVendedorMaximaApi.Incluir(faixasComissaoVendedor);
        }

        /// <summary>
        /// Envia uma lista de <see cref="FaixaComissaoVendedorMaxima"/> para ser alterada na api máxima, se a <see cref="FaixaComissaoVendedorMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="faixasComissaoVendedor">Representação de uma lista de <see cref="FaixaComissaoVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FaixaComissaoVendedorMaxima>> AlterarFaixasComissaoVendedor(List<FaixaComissaoVendedorMaxima> faixasComissaoVendedor)
        {
            return _faixaComissaoVendedorMaximaApi.Alterar(faixasComissaoVendedor);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="FaixaComissaoVendedorMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="faixasComissaoVendedor">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFaixasComissaoVendedor(string[] faixasComissaoVendedor)
        {
            return _faixaComissaoVendedorMaximaApi.Deletar(faixasComissaoVendedor);
        }
    }
}

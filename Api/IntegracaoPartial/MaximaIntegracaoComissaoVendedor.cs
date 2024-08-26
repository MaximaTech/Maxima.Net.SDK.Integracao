using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Comissão de Usuário para ser incluida na api máxima.
        /// </summary>
        /// <param name="comissaoVendedor">Representação de uma lista de Comissão de Usuário</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ComissaoVendedorMaxima>> IncluirComissaoVendedores(List<ComissaoVendedorMaxima> comissaoVendedor)
        {
            return _comissaoVendedorApi.Incluir(comissaoVendedor);
        }

        /// <summary>
        /// Envia uma lista de Comissão de Usuário para ser alterada na api máxima, se a comissão usuário não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="comissaoVendedor">Representação de uma lista de Comissão de Usuário</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ComissaoVendedorMaxima>> AlterarComissaoVendedores(List<ComissaoVendedorMaxima> comissaoVendedor)
        {
            return _comissaoVendedorApi.Alterar(comissaoVendedor);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Comissão de Usuário para ser excluida.
        /// </summary>
        /// <param name="comissaoVendedor">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarComissaoVendedores(string[] comissaoVendedor)
        {
            return _comissaoVendedorApi.Deletar(comissaoVendedor);
        }
    }
}

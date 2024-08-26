using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="RegiaoClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="regioesClientes">Representação de uma lista de <see cref="RegiaoClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<RegiaoClienteMaxima>> IncluirRegioesClientes(List<RegiaoClienteMaxima> regioesClientes)
        {
            return _regiaoClienteMaximaApi.Incluir(regioesClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="RegiaoClienteMaxima"/> para ser alterada na api máxima, se a <see cref="RegiaoClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="regioesClientes">Representação de uma lista de <see cref="RegiaoClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<RegiaoClienteMaxima>> AlterarRegioesClientes(List<RegiaoClienteMaxima> regioesClientes)
        {
            return _regiaoClienteMaximaApi.Alterar(regioesClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="RegiaoClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="regioesClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRegioesClientes(string[] regioesClientes)
        {
            return _regiaoClienteMaximaApi.Deletar(regioesClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="RegiaoClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="regioesClientes">Lista de RegiaoClienteMaxima</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarRegioesClientes(List<RegiaoClienteMaxima> regioesClientes)
        {
            return _regiaoClienteMaximaApi.Deletar(regioesClientes);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ProfissionalPorClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="profissionaisPorCliente">Representação de uma lista de <see cref="ProfissionalPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ProfissionalPorClienteMaxima>> IncluirProfissionaisPorCliente(List<ProfissionalPorClienteMaxima> profissionaisPorCliente)
        {
            return _profissionalPorClienteMaximaApi.Incluir(profissionaisPorCliente);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ProfissionalPorClienteMaxima"/> para ser alterada na api máxima, se a <see cref="ProfissionalPorClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="profissionaisPorCliente">Representação de uma lista de <see cref="ProfissionalPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ProfissionalPorClienteMaxima>> AlterarProfissionaisPorCliente(List<ProfissionalPorClienteMaxima> profissionaisPorCliente)
        {
            return _profissionalPorClienteMaximaApi.Alterar(profissionaisPorCliente);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ProfissionalPorClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="profissionaisPorCliente">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarProfissionaisPorCliente(string[] profissionaisPorCliente)
        {
            return _profissionalPorClienteMaximaApi.Deletar(profissionaisPorCliente);
        }
    }
}

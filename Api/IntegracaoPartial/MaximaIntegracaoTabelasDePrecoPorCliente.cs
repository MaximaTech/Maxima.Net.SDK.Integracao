using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="TabelasDePrecoPorClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="tabelasDePrecoPorClientes">Representação de uma lista de <see cref="TabelasDePrecoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<TabelasDePrecoPorClienteMaxima>> IncluirTabelasDePrecoPorClientes(List<TabelasDePrecoPorClienteMaxima> tabelasDePrecoPorClientes)
        {
            return _tabelasDePrecoPorClienteMaximaApi.Incluir(tabelasDePrecoPorClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="TabelasDePrecoPorClienteMaxima"/> para ser alterada na api máxima, se a <see cref="TabelasDePrecoPorClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tabelasDePrecoPorClientes">Representação de uma lista de <see cref="TabelasDePrecoPorClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TabelasDePrecoPorClienteMaxima>> AlterarTabelasDePrecoPorClientes(List<TabelasDePrecoPorClienteMaxima> tabelasDePrecoPorClientes)
        {
            return _tabelasDePrecoPorClienteMaximaApi.Alterar(tabelasDePrecoPorClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="TabelasDePrecoPorClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="tabelasDePrecoPorClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTabelasDePrecoPorClientes(string[] tabelasDePrecoPorClientes)
        {
            return _tabelasDePrecoPorClienteMaximaApi.Deletar(tabelasDePrecoPorClientes);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Tabela de Preço para ser incluida na api máxima.
        /// </summary>
        /// <param name="tabelaPrecos">Representação de uma lista de Tabela de Preço</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TabelaPrecoMaxima>> IncluirTabelaPreco(List<TabelaPrecoMaxima> tabelaPrecos)
        {
            return _tabelaDePrecoMaxima.Incluir(tabelaPrecos);
        }

        /// <summary>
        /// Envia uma lista de Tabela de Preço para ser alterada na api máxima, se a tabela de preço não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tabelaPrecos">Representação de uma lista de Tabela de Preço</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TabelaPrecoMaxima>> AlterarTabelaPreco(List<TabelaPrecoMaxima> tabelaPrecos)
        {
            return _tabelaDePrecoMaxima.Alterar(tabelaPrecos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Tabela de Preço para ser excluida.
        /// </summary>
        /// <param name="tabelaPrecos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTabelaPreco(List<TabelaPrecoMaxima> tabelaPrecos)
        {
            return _tabelaDePrecoMaxima.Deletar(tabelaPrecos);
        }
    }
}

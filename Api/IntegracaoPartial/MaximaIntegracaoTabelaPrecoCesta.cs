using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="TabelaPrecoCestaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="tabelaPrecoCesta">Representação de uma lista de <see cref="TabelaPrecoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<TabelaPrecoCestaMaxima>> IncluirTabelaPrecoCesta(List<TabelaPrecoCestaMaxima> tabelaPrecoCesta)
        {
            return _tabelaPrecoCestaApi.Incluir(tabelaPrecoCesta);
        }

        /// <summary>
        /// Envia uma lista de <see cref="TabelaPrecoCestaMaxima"/> para ser alterada na api máxima, se a <see cref="TabelaPrecoCestaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tabelaPrecoCesta">Representação de uma lista de <see cref="TabelaPrecoCestaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TabelaPrecoCestaMaxima>> AlterarTabelaPrecoCesta(List<TabelaPrecoCestaMaxima> tabelaPrecoCesta)
        {
            return _tabelaPrecoCestaApi.Alterar(tabelaPrecoCesta);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="TabelaPrecoCestaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="tabelaPrecoCesta">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTabelaPrecoCesta(string[] tabelaPrecoCesta)
        {
            return _tabelaPrecoCestaApi.Deletar(tabelaPrecoCesta);
        }
    }
}

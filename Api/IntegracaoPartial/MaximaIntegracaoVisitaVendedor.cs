using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="VisitaVendedorMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="visitas">Representação de uma lista de <see cref="VisitaVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<VisitaVendedorMaxima>> IncluirVisitasVendedor(List<VisitaVendedorMaxima> visitas)
        {
            return _visitaVendedorMaximaApi.Incluir(visitas);
        }

        /// <summary>
        /// Envia uma lista de <see cref="VisitaVendedorMaxima"/> para ser alterada na api máxima, se a <see cref="VisitaVendedorMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="visitas">Representação de uma lista de <see cref="VisitaVendedorMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VisitaVendedorMaxima>> AlterarVisitasVendedor(List<VisitaVendedorMaxima> visitas)
        {
            return _visitaVendedorMaximaApi.Alterar(visitas);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="VisitaVendedorMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="visitas">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarVisitasVendedor(string[] visitas)
        {
            return _visitaVendedorMaximaApi.Deletar(visitas);
        }
    }
}

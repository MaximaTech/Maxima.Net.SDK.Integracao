using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="ReferenciaComercialClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="referenciasComerciaisClientes">Representação de uma lista de <see cref="ReferenciaComercialClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<ReferenciaComercialClienteMaxima>> IncluirReferenciasComerciaisClientes(List<ReferenciaComercialClienteMaxima> referenciasComerciaisClientes)
        {
            return _referenciaComercialClienteMaxima.Incluir(referenciasComerciaisClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="ReferenciaComercialClienteMaxima"/> para ser alterada na api máxima, se a <see cref="ReferenciaComercialClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="referenciasComerciaisClientes">Representação de uma lista de <see cref="ReferenciaComercialClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ReferenciaComercialClienteMaxima>> AlterarReferenciasComerciaisClientes(List<ReferenciaComercialClienteMaxima> referenciasComerciaisClientes)
        {
            return _referenciaComercialClienteMaxima.Alterar(referenciasComerciaisClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="ReferenciaComercialClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="referenciasComerciaisClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarReferenciasComerciaisClientes(string[] referenciasComerciaisClientes)
        {
            return _referenciaComercialClienteMaxima.Deletar(referenciasComerciaisClientes);
        }
    }
}

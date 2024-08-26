using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Motivos de não comprar para ser incluida na api máxima.
        /// </summary>
        /// <param name="motivoNaoCompra">Representação de uma lista de Motivos de não comprar</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoNaoCompraMaxima>> IncluirMotivoNaoCompra(List<MotivoNaoCompraMaxima> motivoNaoCompra)
        {
            return _motivoNaoCompraMaximaApi.Incluir(motivoNaoCompra);
        }

        /// <summary>
        /// Envia uma lista de Motivos de não comprar para ser alterada na api máxima, se o Motivos de não comprar não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="motivoNaoCompra">Representação de uma lista de Motivos de não comprar</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MotivoNaoCompraMaxima>> AlterarMotivoNaoCompra(List<MotivoNaoCompraMaxima> motivoNaoCompra)
        {
            return _motivoNaoCompraMaximaApi.Alterar(motivoNaoCompra);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Motivos de não comprar para ser excluida.
        /// </summary>
        /// <param name="motivoNaoCompra">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMotivoNaoCompra(string[] motivoNaoCompra)
        {
            return _motivoNaoCompraMaximaApi.Deletar(motivoNaoCompra);
        }
    }
}

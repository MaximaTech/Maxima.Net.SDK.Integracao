using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Metas para ser incluida na api máxima.
        /// </summary>
        /// <param name="meta">Representação de uma lista de Metas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MetaMaxima>> IncluirMetas(List<MetaMaxima> meta)
        {
            return _metaMaximaApi.Incluir(meta);
        }

        /// <summary>
        /// Envia uma lista de Metas para ser alterada na api máxima, se a Meta não existir no Banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="meta">Representação de uma lista de Metas</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MetaMaxima>> AlterarMetas(List<MetaMaxima> meta)
        {
            return _metaMaximaApi.Alterar(meta);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Metas para ser excluida.
        /// </summary>
        /// <param name="meta">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMetas(string[] meta)
        {
            return _metaMaximaApi.Deletar(meta);
        }
    }
}

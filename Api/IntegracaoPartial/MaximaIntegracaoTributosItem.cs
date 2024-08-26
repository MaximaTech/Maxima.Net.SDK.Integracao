using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Tabelas de tributação do ERP para ser incluida na api máxima.
        /// </summary>
        /// <param name="tabelaTributacao">Representação de uma lista de Tabelas de tributação do ERP</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TributosItemMaxima>> IncluirTributosItem(List<TributosItemMaxima> tabelaTributacao)
        {
            return _tributosItemMaximaApi.Incluir(tabelaTributacao);
        }

        /// <summary>
        /// Envia uma lista de Tabelas de tributação do ERP para ser alterada na api máxima, se a tabela de tributação não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="tabelaTributacao">Representação de uma lista de Tabelas de tributação do ERP</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<TributosItemMaxima>> AlterarTributosItem(List<TributosItemMaxima> tabelaTributacao)
        {
            return _tributosItemMaximaApi.Alterar(tabelaTributacao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Tabelas de tributação do ERP para ser excluida.
        /// </summary>
        /// <param name="tabelaTributacao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarTributosItem(string[] tabelaTributacao)
        {
            return _tributosItemMaximaApi.Deletar(tabelaTributacao);
        }
    }
}

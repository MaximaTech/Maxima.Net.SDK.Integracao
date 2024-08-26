using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Filial para ser incluida na api máxima.
        /// </summary>
        /// <param name="filiais">Representação de uma lista de Filial</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialMaxima>> IncluirFiliais(List<FilialMaxima> filiais)
        {
            return _filialMaximaApi.Incluir(filiais);
        }

        /// <summary>
        /// Envia uma lista de Filial para ser alterada na api máxima, se a filial não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="filiais">Representação de uma lista de Filial</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialMaxima>> AlterarFiliais(List<FilialMaxima> filiais)
        {
            return _filialMaximaApi.Alterar(filiais);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Filial para ser excluida.
        /// </summary>
        /// <param name="filiais">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFilial(string[] filiais)
        {
            return _filialMaximaApi.Deletar(filiais);
        }
    }
}

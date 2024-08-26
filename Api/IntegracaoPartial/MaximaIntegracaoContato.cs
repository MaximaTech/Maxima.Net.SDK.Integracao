using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Contatos para ser incluida na api máxima.
        /// </summary>
        /// <param name="contatos">Representação de uma lista de Contatos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ContatoMaxima>> IncluirContatos(List<ContatoMaxima> contatos)
        {
            return _contatoMaximaApi.Incluir(contatos);
        }

        /// <summary>
        /// Envia uma lista de Contatos para ser alterada na api máxima, se o contato não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="contatos">Representação de uma lista de Contatos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<ContatoMaxima>> AlterarContatos(List<ContatoMaxima> contatos)
        {
            return _contatoMaximaApi.Alterar(contatos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Contatos para ser excluida.
        /// </summary>
        /// <param name="contatos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarContatos(string[] contatos)
        {
            return _contatoMaximaApi.Deletar(contatos);
        }
    }
}

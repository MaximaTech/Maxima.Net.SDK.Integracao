using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="MensagemMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="mensagens">Representação de uma lista de <see cref="MensagemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<MensagemMaxima>> IncluirMensagens(List<MensagemMaxima> mensagens)
        {
            return _mensagemMaximaApi.Incluir(mensagens);
        }

        /// <summary>
        /// Envia uma lista de <see cref="MensagemMaxima"/> para ser alterada na api máxima, se a <see cref="MensagemMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="mensagens">Representação de uma lista de <see cref="MensagemMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<MensagemMaxima>> AlterarMensagens(List<MensagemMaxima> mensagens)
        {
            return _mensagemMaximaApi.Alterar(mensagens);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="MensagemMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="mensagens">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarMensagens(string[] mensagens)
        {
            return _mensagemMaximaApi.Deletar(mensagens);
        }
    }
}

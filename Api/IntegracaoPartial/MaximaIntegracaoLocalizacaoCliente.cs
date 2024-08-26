using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="LocalizacaoClienteMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="localizacoesClientes">Representação de uma lista de <see cref="LocalizacaoClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<LocalizacaoClienteMaxima>> IncluirLocalizacoesClientes(List<LocalizacaoClienteMaxima> localizacoesClientes)
        {
            return _localizacaoClienteMaxima.Incluir(localizacoesClientes);
        }

        /// <summary>
        /// Envia uma lista de <see cref="LocalizacaoClienteMaxima"/> para ser alterada na api máxima, se a <see cref="LocalizacaoClienteMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="localizacoesClientes">Representação de uma lista de <see cref="LocalizacaoClienteMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<LocalizacaoClienteMaxima>> AlterarLocalizacoesClientes(List<LocalizacaoClienteMaxima> localizacoesClientes)
        {
            return _localizacaoClienteMaxima.Alterar(localizacoesClientes);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="LocalizacaoClienteMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="localizacoesClientes">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarLocalizacoesClientes(string[] localizacoesClientes)
        {
            return _localizacaoClienteMaxima.Deletar(localizacoesClientes);
        }
    }
}

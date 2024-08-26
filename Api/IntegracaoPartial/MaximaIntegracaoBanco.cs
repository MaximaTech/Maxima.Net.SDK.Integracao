using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Bancos para ser incluida na api máxima.
        /// </summary>
        /// <param name="bancos">Representação de uma lista de Bancos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BancoMaxima>> IncluirBancos(List<BancoMaxima> bancos)
        {
            return _bancoMaximaApi.Incluir(bancos);
        }

        /// <summary>
        /// Envia uma lista de Bancos para ser alterada na api máxima, se o banco não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="bancos">Representação de uma lista de Bancos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<BancoMaxima>> AlterarBancos(List<BancoMaxima> bancos)
        {
            return _bancoMaximaApi.Alterar(bancos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Bancos para ser excluida.
        /// </summary>
        /// <param name="bancos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarBancos(string[] bancos)
        {
            return _bancoMaximaApi.Deletar(bancos);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de veiculos para ser incluida na api máxima.
        /// </summary>
        /// <param name="veiculos">Representação de uma lista de veiculos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<VeiculoMaxima>> IncluirVeiculos(List<VeiculoMaxima> veiculos)
        {
            return _veiculoMaximaApi.Incluir(veiculos);
        }

        /// <summary>
        /// Envia uma lista de veiculos para ser alterada na api máxima, se a veiculos não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="veiculos">Representação de uma lista de veiculos</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<VeiculoMaxima>> AlterarVeiculos(List<VeiculoMaxima> veiculos)
        {
            return _veiculoMaximaApi.Alterar(veiculos);
        }

        /// <summary>
        /// Envia uma array de strings com ids de veiculos para ser excluida.
        /// </summary>
        /// <param name="veiculos">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarVeiculos(string[] veiculos)
        {
            return _veiculoMaximaApi.Deletar(veiculos);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de <see cref="DescontoCategoriaMaxima"/> para ser incluida na api máxima.
        /// </summary>
        /// <param name="descontoCategoria">Representação de uma lista de <see cref="DescontoCategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao.</returns>
        public Task<ResponseApiMaxima<DescontoCategoriaMaxima>> IncluirDescontoCategorias(List<DescontoCategoriaMaxima> descontoCategoria)
        {
            return _descontoCategoriaApi.Incluir(descontoCategoria);
        }

        /// <summary>
        /// Envia uma lista de <see cref="DescontoCategoriaMaxima"/> para ser alterada na api máxima, se a <see cref="DescontoCategoriaMaxima"/> não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="descontoCategoria">Representação de uma lista de <see cref="DescontoCategoriaMaxima"/>.</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<DescontoCategoriaMaxima>> AlterarDescontoCategorias(List<DescontoCategoriaMaxima> descontoCategoria)
        {
            return _descontoCategoriaApi.Alterar(descontoCategoria);
        }

        /// <summary>
        /// Envia uma array de strings com ids de <see cref="DescontoCategoriaMaxima"/> para ser excluida.
        /// </summary>
        /// <param name="descontoCategoria">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarDescontoCategorias(string[] descontoCategoria)
        {
            return _descontoCategoriaApi.Deletar(descontoCategoria);
        }
    }
}

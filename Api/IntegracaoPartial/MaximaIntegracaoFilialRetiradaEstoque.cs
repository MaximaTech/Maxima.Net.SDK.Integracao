using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Filial Retirada Estoque para ser incluida na api máxima.
        /// </summary>
        /// <param name="filiaisRetiradaEstoque">Representação de uma lista de Filial Retirada Estoque</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialRetiradaEstoqueMaxima>> IncluirFiliaisRetiradaEstoque(List<FilialRetiradaEstoqueMaxima> filiaisRetiradaEstoque)
        {
            return _filialRetiradaEstoqueMaximaApi.Incluir(filiaisRetiradaEstoque);
        }

        /// <summary>
        /// Envia uma lista de Filial Retirada Estoque para ser alterada na api máxima, se a filial não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="filiaisRetiradaEstoque">Representação de uma lista de Filial Retirada Estoque</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialRetiradaEstoqueMaxima>> AlterarFiliaisRetiradaEstoque(List<FilialRetiradaEstoqueMaxima> filiaisRetiradaEstoque)
        {
            return _filialRetiradaEstoqueMaximaApi.Alterar(filiaisRetiradaEstoque);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Filial Retirada Estoque para ser excluida.
        /// </summary>
        /// <param name="filiaisRetiradaEstoque">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFiliaisRetiradaEstoque(string[] filiaisRetiradaEstoque)
        {
            return _filialRetiradaEstoqueMaximaApi.Deletar(filiaisRetiradaEstoque);
        }
    }
}

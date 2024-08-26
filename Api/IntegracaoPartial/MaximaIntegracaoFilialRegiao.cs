using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Dto;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Envia uma lista de Filial Regiao para ser incluida na api máxima.
        /// </summary>
        /// <param name="filiaisRegiao">Representação de uma lista de Filial Regiao</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialRegiaoMaxima>> IncluirFiliaisRegiao(List<FilialRegiaoMaxima> filiaisRegiao)
        {
            return _filialRegiaoMaximaApi.Incluir(filiaisRegiao);
        }

        /// <summary>
        /// Envia uma lista de Filial Regiao para ser alterada na api máxima, se a filial não existir no banco nuvem ira ser retornado um erro.
        /// </summary>
        /// <param name="filiaisRegiao">Representação de uma lista de Filial Regiao</param>
        /// <returns>Retorna um ResponseApiMaxima onde existe um resumo do envio com os seguintes dados: ItensInserido, TotalItensNaoInserido, ErrosValidacao. </returns>
        public Task<ResponseApiMaxima<FilialRegiaoMaxima>> AlterarFiliaisRegiao(List<FilialRegiaoMaxima> filiaisRegiao)
        {
            return _filialRegiaoMaximaApi.Alterar(filiaisRegiao);
        }

        /// <summary>
        /// Envia uma array de strings com ids de Filial Regiao para ser excluida.
        /// </summary>
        /// <param name="filiaisRegiao">array de chaves</param>
        /// <returns>RetornoApiMaxima com resumo de chaves excluidas</returns>
        public Task<RetornoApiMaxima> DeletarFiliaisRegiao(string[] filiaisRegiao)
        {
            return _filialRegiaoMaximaApi.Deletar(filiaisRegiao);
        }
    }
}

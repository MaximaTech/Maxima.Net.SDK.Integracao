using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Responsável por armazenar informações dos funcionários.
    /// </summary>
    public class EmpregadoMaxima
    {
        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Emprs";
        internal const string Tabela = "MXSEMPR";

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Matricula do empregado, campo obrigatório.
        /// </summary>
        [PropriedadePK]
        [JsonProperty("Matricula")]
        public int Matricula { get; set; }

        /// <summary>
        /// Nome do empregado, campo obrigatório com tamanho máximo de 4000 caracteres.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(4000)]
        [JsonProperty("Nome")]
        public string Nome { get; set; }

        /// <summary>
        /// Código do setor do empregado com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Setores.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(SetorMaxima.VersaoAPI, SetorMaxima.EndPoint, SetorMaxima.Tabela, typeof(SetorMaxima))]
        [JsonProperty("Codsetor")]
        public string CodigoSetor { get; set; }

        /// <summary>
        /// E-mail do empregado limite de até 4000 caracteres.
        /// </summary>
        [TamanhoMaximo(4000)]
        [JsonProperty("Email")]
        public string Email { get; set; }

        /// <summary>
        /// Código do veiculo do empregado com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>Código veículo referente ao cadastro de veículos.</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(VeiculoMaxima.VersaoAPI, VeiculoMaxima.EndPoint, VeiculoMaxima.Tabela, typeof(VeiculoMaxima))]
        [JsonProperty("Codveiculo")]
        public string CodigoVeiculo { get; set; }

        /// <summary>
        /// Apelido do empregado com tamanho limite de até 400 caracteres.
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Nome_guerra")]
        public string Apelido { get; set; }

        /// <summary>
        /// Telefone fixo do empregado com limite de até 400 caracteres.
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Fone")]
        public string TelefoneFixo { get; set; }

        /// <summary>
        /// Celular do empregado com limite de até 400 caracteres.
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Celular")]
        public string Celular { get; set; }

        /// <summary>
        /// Código da filial do empregado com preenchimento obrigatório e limite de até 50 caracteres <br/>
        /// </summary>
        /// <value>O código usado deve existir no cadastro de Filiais</value>
        [CampoObrigatorioAoInserir]
        [TamanhoMaximo(50)]
        [PropriedadeFK(FilialMaxima.VersaoAPI, FilialMaxima.EndPoint, FilialMaxima.Tabela, typeof(FilialMaxima))]
        [JsonProperty("Codfilial")]
        public string CodigoFilial { get; set; }

        /// <summary>
        /// Tipo de empregado com preenchimento obrigatório
        /// </summary>
        /// <value>'F' - Funcionário / 'M' - Motorista</value>
        [CampoObrigatorioAoInserir]
        [RangeString(new string[] { "F", "M" })]
        [JsonProperty("Tipo")]
        public string TipoDeEmpregado { get; set; }

        /// <summary>
        /// Data de validade da CNH do empregado.
        /// </summary>
        [JsonProperty("Dtvalidadecnh")]
        public DateTime? DataDeValidadeCNH { get; set; }

        /// <summary>
        /// Data da exclusão lógica do registro do empregado.
        /// </summary>
        [JsonProperty("Dt_exclusao")]
        public DateTime? DataExclusao { get; set; }

        /// <summary>
        /// CPF do empregado.
        /// </summary>
        [TamanhoMaximo(20)]
        [JsonProperty("Cpf")]
        public string Cpf { get; set; }

        /// <summary>
        /// Situacao do empregado A - Ativo / I - Inativo (Padrão: Ativo)
        /// </summary>
        [TamanhoMaximo(1)]
        [JsonProperty("Situacao")]
        public string Situacao { get; set; }

        /// <summary>
        /// Nome do usuário no banco de dados com limite de até 400 caracteres.
        /// </summary>
        [TamanhoMaximo(400)]
        [JsonProperty("Usuariobd")]
        public string UsuarioNoBancoDeDados { get; set; }
    }
}

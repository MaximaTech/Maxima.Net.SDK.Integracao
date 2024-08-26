using System;
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena visitas realizadas para o cliente pelo vendedor.
    /// </summary>
    public class VisitaMaxima
    {
        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Visitafv";
        internal const string Tabela = "ERP_MXSVISITAFV";

        /// <summary>
        /// Código da justificativa da visita, com preenchimento obrigatório,
        /// </summary>
        /// <value>
        /// Código referente ao cadastro de Motivos de visita (<see cref="MotivoVisitaMaxima"/>)
        /// </value>
        [PropriedadeFK(MotivoVisitaMaxima.VersaoAPI, MotivoVisitaMaxima.EndPoint, MotivoVisitaMaxima.Tabela, typeof(MotivoVisitaMaxima))]
        [ValorEntre(0, 999999)]
        [PropriedadePK(1)]
        [JsonProperty("Codmotivo")]
        public int? CodigoMotivo { get; set; }

        /// <summary>
        /// Data da visita.
        /// </summary>
        [PropriedadePK(2)]
        [JsonProperty("Data")]
        public DateTime? DataVisita { get; set; }

        /// <summary>
        /// CPF/CNPJ do cliente.
        /// </summary>
        [PropriedadePK(3)]
        [JsonProperty("Cgccli")]
        [TamanhoMaximo(18)]
        public string CpfCnpj { get; set; }

        ///<summary>
        /// Código do cliente, com preenchimento é obrigatório e com limite de até 50 caracteres.
        ///</summary>
        ///<value> CodigoCliente referente ao Cadastro de Clientes </value>
        [TamanhoMaximo(50)]
        [JsonProperty("Codcli")]
        [PropriedadePK(5)]
        [PropriedadeFK(ClienteMaxima.VersaoAPI, ClienteMaxima.EndPoint, ClienteMaxima.Tabela, typeof(ClienteMaxima))]
        public string CodigoCliente { get; set; }

        /// <summary>
        /// Código do vendedor. O preenchimento é obrigatório e limite de até 50 caracteres. <br/>
        /// </summary>
        /// <value>Código do vendedor referente ao cadastro de vendedor.</value>
        [TamanhoMaximo(50)]
        [PropriedadeFK(VendedorMaxima.VersaoAPI, VendedorMaxima.EndPoint, VendedorMaxima.Tabela, typeof(VendedorMaxima))]
        [PropriedadePK(4)]
        [JsonProperty("Codusur")]
        public string CodigoVendedor { get; set; }

        /// <summary>
        /// Hora inicio da visita.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 23)]
        [JsonProperty("Horainicial")]
        public int? HoraInicialVisita { get; set; }

        /// <summary>
        /// Minuto inicial da visita.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 59)]
        [JsonProperty("Minutoinicial")]
        public int? MinutoInicialVisita { get; set; }

        /// <summary>
        /// Hora final da visita.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 23)]
        [JsonProperty("Horafinal")]
        public int? HoraFinalVisita { get; set; }

        /// <summary>
        /// Minuto final da visita.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 59)]
        [JsonProperty("Minutofinal")]
        public int? MinutoFinalVisita { get; set; }

        /// <summary>
        /// Observação/Assunto da visita.
        /// </summary>
        [CampoObrigatorioAoInserir]
        [JsonProperty("Assunto")]
        public string Assunto { get; set; }

        /// <summary>
        /// Latitude (coordenadas geográficas da visita).
        /// </summary>
        [JsonProperty("Latitude")]
        [TamanhoMaximo(50)]
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude (coordenadas geográficas da visita)
        /// </summary>
        [JsonProperty("Longitude")]
        [TamanhoMaximo(50)]
        public string Longitude { get; set; }

        /// <summary>
        /// Importado pelo ERP? 2 – Sim ou 3 – Não.
        /// </summary>
        /// <value>2 – Sim ou 3 – Não.</value>
        [JsonProperty("Importado")]
        [RangeNumber(2, 3)]
        public int? ImportadoPeloERP { get; set; }

    }
}

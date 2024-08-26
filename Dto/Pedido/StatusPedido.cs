using System;
using System.ComponentModel.DataAnnotations;
using Maxima.Net.SDK.Integracao.Utils.Atributos;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    internal class StatusPedido
    {


        [CampoObrigatorioAoInserir]
        public string Id_pedido { get; set; }

        public string Objeto_json { get; set; }

        public DateTime? Data { get; set; }

        public int? Status { get; set; }

        public string Critica { get; set; }

        public int? Tipopedido { get; set; }

        public string Codusuario { get; set; }

        public string Numped { get; set; }

        public long? Numcritica { get; set; }

        public int? Tipocritica { get; set; }

        public DateTime? Dtinclusao { get; set; }

        public DateTime? Dtenvioerp { get; set; }

        public DateTime? Dtretornoerp { get; set; }

        public DateTime? Dtprocessamentoerp { get; set; }

        public decimal? Percdescontopedido { get; set; }

        public decimal? Perclucratividade { get; set; }

        public decimal? Vlatend { get; set; }

        public DateTime? Dataenvioaprovacao { get; set; }

        public decimal? Vlbonific { get; set; }

        public int? Condvenda { get; set; }

        public DateTime? Dataautorizacaopedido { get; set; }

        public int? Codusuarioautorizou { get; set; }

        public DateTime? Dtgravacaoerp { get; set; }

        public decimal? Valortotal { get; set; }

        public DateTime? Dtaberturapedpalm { get; set; }

        public long? Qtdeprodutos { get; set; }

        [TamanhoMaximo(1)]
        public string Editado { get; set; }

        [TamanhoMaximo(1)]
        public string Reenviado { get; set; }

        [TamanhoMaximo(1)]
        public string Cancelado { get; set; }

        [TamanhoMaximo(50)]
        public string Codusur { get; set; }

        [TamanhoMaximo(50)]
        public string Codcli { get; set; }

        [TamanhoMaximo(50)]
        public string Codplpag { get; set; }

        [TamanhoMaximo(50)]
        public string Codfilial { get; set; }

        [TamanhoMaximo(50)]
        public string Numpederp { get; set; }

        [TamanhoMaximo(50)]
        public string Codsupervisor { get; set; }

        [TamanhoMaximo(1000)]
        public string Observacao { get; set; }

        [TamanhoMaximo(4000)]
        public string Obspedido { get; set; }

        internal const string VersaoAPI = "v1";

        internal const string EndPoint = "StatusPedidos";

    }

}

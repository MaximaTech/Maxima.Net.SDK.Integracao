using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class Critica
    {
        public Critica()
        {
            HouveExcessao = false;
        }

        #region Fields

        private List<DetalheCritica> itens;

        #endregion

        #region Classes


        public class DetalheCritica
        {


            public string Codigo
            { get; set; }


            public int Ordem
            { get; set; }

            public string Descricao
            { get; set; }

        }

        #endregion

        #region Propriedades


        public string Status
        { get; set; }


        public string NumPedido
        { get; set; }


        public string CodigoPedidoNuvem { get; set; }


        public string NumPedidoERP
        { get; set; }


        public ulong? NumPedidoPreposto { get; set; }


        public long NumCritica
        { get; set; }


        public string CodigoUsuario
        { get; set; }


        public DateTime Data
        { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EnumTipoCritica Tipo
        { get; set; }

        public bool AguardandoAlgumaAutorizacao
        {
            get
            {
                return Tipo == EnumTipoCritica.AguardandoAutorizacaoPreco ||
                       Tipo == EnumTipoCritica.AguardandoAutorizacaoLucratividade ||
                       Tipo == EnumTipoCritica.AguardandoAutorizacaoGeral ||
                       Tipo == EnumTipoCritica.AguardandoAutorizacaoBonificacao ||
                       Tipo == EnumTipoCritica.AguardandoAutorizacaoPedidoTroca;
            }
        }


        public List<DetalheCritica> Itens
        {
            get
            {

                if (itens == null)
                    itens = new List<DetalheCritica>();
                return itens;

            }
            set { itens = value; }
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public EnumPosicaoPedido PosicaoPedidoERP { get; set; }


        public int CodigoTipoVenda
        { get; set; }

        /// <summary>
        /// Hash do pedido que originou essa critica
        /// </summary>

        public string HashCode
        { get; set; }

        /// <summary>
        /// O status do envio do pedido, valores possíveis: Assinado ou Pendente.
        /// </summary>

        public EnumStatusAssinatura StatusDaAssinatura { get; set; }

        /// <summary>
        /// Informa se a critica já foi enviada para o android.
        /// </summary>

        public string CriticaEnviada { get; set; }

        #endregion

        #region VARIAVEIS DE CONTROLE PARA POSSIBILITAR AS ALTERAÇÕES DO LADO DO SERVER


        public bool ExcluirPedido { get; set; }


        public bool SalvarCritica { get; set; }


        public bool EnviarEmailPedidoAutomaticoParaSupervisor { get; set; }


        public bool SalvarJustificativaNaoVendaPrePedido { get; set; }


        public bool AtualizacaoPosPedido { get; set; }

        #endregion

        #region Metodos

        /// <summary>
        /// Adiciona um detalhe à critica do Pedido
        /// </summary>
        /// <param name="pCodigo"></param>
        /// <param name="pDescricao"></param>
        /// <param name="pOrdem"></param>
        public void AdicionarDetalheCritica(uint pCodigo, string pDescricao, int pOrdem)
        {
            Itens.Add(new DetalheCritica() { Codigo = pCodigo.ToString(), Descricao = pDescricao, Ordem = pOrdem });
        }


        #endregion


        public bool Cancelado { get; set; }

        public bool? SucessoSincronizacao { get; set; } = true;


        public bool HouveExcessao { get; set; }


        public bool? PackageValida { get; set; }

        public bool PossuiMensagemDeSucesso()
        {
            if (Itens == null) return false;

            foreach (var item in Itens)
            {
                if (item.Descricao.ToLower().Contains("pedido salvo com sucesso"))
                    return true;
            }

            return false;
        }
    }

    public enum EnumStatusAssinatura
    {

        Nenhuma = -1,


        Pendente = 0,


        Assinado = 1,


        NaoAssinar = 2
    }

    public enum EnumTipoCritica
    {

        Nenhuma = -1,


        Sucesso = 0,


        Alerta = 1,


        Erro = 2,


        Cancelado = 3,


        AguardandoAutorizacaoPreco = 4,


        AutorizacaoPrecoAceita = 5,


        AutorizacaoPrecoNegada = 6,


        Processando = 7,


        AguardandoAssinatura = 8,


        FalhaNoWebService = 9,


        AguardandoAutorizacaoLucratividade = 10,


        AutorizacaoLucratividadeAceita = 11,


        AutorizacaoLucratividadeNegada = 12,

        // Quando o pedido possuir os dois tipos de autorizações ao mesmo tempo (Lucratividade e Preço).

        AguardandoAutorizacaoGeral = 13,


        AutorizacaoGeralAceita = 14,


        AutorizacaoGeralNegada = 15,


        EnviadoParaNuvem = 16,


        BloqueadoNuvem = 17,


        CanceladoNuvem = 18,


        AguardandoAutorizacaoBonificacao = 19,


        AutorizacaoBonificacaoAceita = 20,


        AutorizacaoBonificacaoNegada = 21,


        AguardandoAutorizacaoPedidoTroca = 22,


        AutorizacaoPedidoTrocaAceita = 23,


        AutorizacaoPedidoTrocaNegada = 24,
    }
}
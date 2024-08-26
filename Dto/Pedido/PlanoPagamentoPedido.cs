using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Maxima.Net.SDK.Integracao.Dto.Pedido
{
    public class PlanoPagamentoPedido
    {
        #region Fields
        private int?[] prazos;
        private DateTime?[] vencimentos;
        private List<PlanoPagamentoVencimentosVariaveis> vencimentosVariaveis;
        #endregion

        #region Métodos

        /// <summary>
        /// Obtem as parcelas que compoe esse prazo, separadas por vírgula
        /// </summary>
        public string GetParcelas()
        {

            string vRetVal = string.Empty;

            foreach (int? item in this.Prazos)
            {
                if (item != null)
                    vRetVal += item.ToString() + ", ";
            }

            if (string.IsNullOrEmpty(vRetVal))
                return null;
            else
            {
                return vRetVal.Substring(0, vRetVal.Length - 2);
            }

        }

        /// <summary>
        /// Obtem o numero de parcelas que compoe esse plano
        /// </summary>
        /// <returns></returns>
        public ushort GetNumeroParcelas()
        {

            ushort vRetVal = 0;

            foreach (int? item in this.Prazos)
            {
                if (item != null)
                    vRetVal++;
            }

            return (ushort)Math.Max((int)1, (int)vRetVal);

        }

        /// <summary>
        /// Obtem as datas de vencimento fixa de plano, separadas por virgula
        /// </summary>
        public string GetDatasVencimento(string pFormatString)
        {
            string vRetVal = string.Empty;

            foreach (DateTime? item in Vencimentos)
            {
                if (item != null)
                    vRetVal += ((DateTime)item).ToString(pFormatString) + ", ";
            }

            if (string.IsNullOrEmpty(vRetVal))
                return null;
            else
            {
                return vRetVal.Substring(0, vRetVal.Length - 2);
            }

        }

        #endregion

        #region Classes

        [Serializable, DataContract]
        public class PlanoPagamentoVencimentosVariaveis
        {

            private int numParcela;

            /// <summary>
            /// Número da parcela
            /// </summary>

            public int NumParcela
            {
                get { return numParcela; }
                set { numParcela = value; }
            }
            private DateTime dataVencimento;

            /// <summary>
            /// Data de vencimento da parcela
            /// </summary>

            public DateTime DataVencimento
            {
                get { return dataVencimento; }
                set { dataVencimento = value; }
            }
        }

        #endregion



        public string Codigo
        { get; set; }


        public string Descricao
        { get; set; }


        public string Descricao2
        { get; set; }


        public short PrazoMedio
        { get; set; }


        public int?[] Prazos
        {
            get
            {

                if (prazos == null)
                    prazos = new int?[12];

                return prazos;
            }
            set { prazos = value; }
        }


        public DateTime?[] Vencimentos
        {
            get
            {
                if (vencimentos == null)
                    vencimentos = new DateTime?[3];
                return vencimentos;
            }
            set { vencimentos = value; }
        }


        public decimal ValorMinimoPedido
        { get; set; }


        public ushort IndicePrazo
        { get; set; }

        public string Obs
        { get; set; }

        public string TipoRestricao
        { get; set; }

        public string CodigoRestricao
        { get; set; }


        public bool VendaPrazo
        { get; set; }


        public decimal MargemMinima
        { get; set; }


        public decimal PercTaxaFinanceira
        { get; set; }


        public bool AceitaVendaBoleto { get; set; }


        public string TipoPrazo { get; set; }


        public string FormaParcelamento
        { get; set; }


        public decimal? ValorMinimoParcela
        { get; set; }


        public int? DiasMinParcela
        { get; set; }


        public int? DiasMaxParcela
        { get; set; }


        public int? NumeroParcelas
        { get; set; }

        /// <summary>
        /// Percentual de desconto de juros do plano Variavel [PCPLPAGVARIAVELJUROS.PERCDESC]
        /// </summary>

        public decimal? PercDescontoPlanoVariavel
        { get; set; }

        /// <summary>
        /// Prazo Médio calculado a partir das datas de vencimento variaveis do sistema
        /// </summary>

        public short? PrazoMedioVariavel
        { get; set; }

        /// <summary>
        /// Lista de Vencimentos Variaveis estabelecidos para o Plano
        /// </summary>
        /// <remarks>
        /// Não definir a lista de planos de pagamento variaveis diretamente. A mesma deverá ser definida
        /// utilizando-se o metodo de validação da BLL (BLL.ValidarPlanoPagamentoVariavel)
        /// </remarks>

        public List<PlanoPagamentoVencimentosVariaveis> VencimentosVariaveis
        {
            get
            {
                if (vencimentosVariaveis == null)
                    vencimentosVariaveis = new List<PlanoPagamentoVencimentosVariaveis>();
                return vencimentosVariaveis;
            }
            set { vencimentosVariaveis = value; }
        }


        public int NumeroMinimoItens { get; set; }

        /// <summary>
        /// PCPLPAGI.PERCBONIFICACAO
        /// </summary>

        public decimal PercBonific { get; set; }


        public int? TipoEntrada
        { get; set; }

        public int ObterQuantidadePrazos()
        {
            var qtdParcelas = 0;

            for (int i = 0; i < Prazos.Count(); i++)
            {
                if (Prazos[i] > 0)
                    qtdParcelas++;
            }

            return qtdParcelas;
        }
    }
}
using Maxima.Net.SDK.Integracao.Utils.Atributos;
using Newtonsoft.Json;

namespace Maxima.Net.SDK.Integracao.Entidades
{
    /// <summary>
    /// Entidade que armazena o cabeçalho da figura tributária.
    /// </summary>
    public class TributosCapaMaxima
    {
        /// <summary>
        /// Código da figura tributária, preenchimento obrigatório e limite de até 50 caracteres.
        /// </summary>
        [TamanhoMaximo(50)]
        [PropriedadePK]
        [JsonProperty("CodSt")]
        public string CodigoFiguraTributaria { get; set; }

        /// <summary>
        /// Define o codigo do IVA (Imposto sobre valor agregado).
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.9999)]
        public double? Iva { get; set; }

        /// <summary>
        /// Define a Alíquota de ICMS 1
        /// </summary>
        [JsonProperty("Aliqicms1")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.9999)]
        public double? AliquotaIcms1 { get; set; }

        /// <summary>
        /// Define a Alíquota de ICMS 2
        /// </summary>
        [JsonProperty("Aliqicms2")]
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 9999.9999)]
        public double? AliquotaIcms2 { get; set; }

        /// <summary>
        /// Define o valor da pauta
        /// </summary>
        [CampoObrigatorioAoInserir]
        [ValorEntre(0, 999999999999.999999)]
        public double? Pauta { get; set; }

        /// <summary>
        /// Define a alíquota de ICMS normal.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Codicm")]
        public double? AliquotaIcms { get; set; }

        /// <summary>
        /// Define a alíquota de ICMS pessoa física.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Codicmpf")]
        public double? AliquotaIcmsPessoaFisica { get; set; }

        /// <summary>
        /// Define a porcentagem de imposto CMV (Custo mercadoria vendida).
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Codicmtab")]
        public double? ImpostoCmv { get; set; }

        /// <summary>
        /// Define a porcentagem de desconto do ICMS 
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perdescicmisencao")]
        public double? PercentualDescontoIcmsIsencao { get; set; }

        /// <summary>
        /// Define a porcentagem da redução da base de cálculo ST 
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percbaseredst")]
        public double? PercentualReducaoBaseST { get; set; }

        /// <summary>
        /// Define a porcentagem da redução da base de cálculo ST Fonte
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percbaseredstfonte")]
        public double? PercentualReducaoBaseStFonte { get; set; }

        /// <summary>
        /// Define a porcentagem de imposto CMV (Custo mercadoria vendida) pessoa física.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Codicmtabpf")]
        public double? ImpostoCmvPf { get; set; }

        /// <summary>
        /// Define a porcentagem de acréscimo pessoa física.
        /// </summary>
        [ValorEntre(0, 9999.99)]
        [JsonProperty("Peracrescimopf")]
        public double? PercentualAcrescimoPessoaFisica { get; set; }

        /// <summary>
        /// Define a porcentagem de desconto do PIS.
        /// </summary>
        [ValorEntre(0, 99999999.9999)]
        [JsonProperty("Percdescpis")]
        public double? PercentualDescontoPis { get; set; }

        /// <summary>
        /// Define a porcentagem de desconto do COFINS.
        /// </summary>
        [ValorEntre(0, 99999999.9999)]
        [JsonProperty("Percdesccofins")]
        public double? PercentualDescontoCofins { get; set; }

        /// <summary>
        /// Define a porcentagem de desconto do PIS SUFRAMA.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perdescpissuframa")]
        public double? PercentualDescontoPisSuframa { get; set; }

        /// <summary>
        /// Define a porcentagem de desconto do SUFRAMA.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perdescsuframa")]
        public double? PercentualDescontoSuframa { get; set; }

        /// <summary>
        /// Define a porcentagem de redução da base de ICMS consumidor final.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percbaseredconsumidor")]
        public double? PercentualBaseReducaoConsumidor { get; set; }

        /// <summary>
        /// Define a porcentagem de redução da base de ICMS NRPA.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perbaserednrpa")]
        public double? PercentualBaseReducaoNrpa { get; set; }

        /// <summary>
        /// Define a alíquota de ICMS 2 fonte.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Aliqicms2fonte")]
        [CampoObrigatorioAoInserir]
        public double? AlicotaIcms2Fonte { get; set; }

        /// <summary>
        /// Define a alíquota de ICMS 1 fonte.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Aliqicms1fonte")]
        [CampoObrigatorioAoInserir]
        public double? AlicotaIcms1Fonte { get; set; }

        /// <summary>
        /// Define o percentual de IVA fonte.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Ivafonte")]
        [CampoObrigatorioAoInserir]
        public double? PercentualIvaFonte { get; set; }

        // /// <summary>
        // /// Define o percentual de acréscimo para pessoa física.
        // /// </summary>
        // [ValorEntre(0, 9999.9999)]
        // [JsonProperty("Peracrescismopf")]
        // public decimal? PercentualAcrescimoPessoaFisica { get; set; }

        /// <summary>
        /// Define o percentual de redução de venda para cliente simples nacional.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percredpvendasimplesnac")]
        public double? PercentualReducaoVendaSimplesNacional { get; set; }

        /// <summary>
        /// Define o percentual de desconto de repasse.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perdescrepasse")]
        public double? PercentualDescontoRepasse { get; set; }

        /// <summary>
        /// Define o percentual de redução da base do ICMS.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percbasered")]
        public double? PercentualReducaoBaseIcms { get; set; }

        /// <summary>
        /// Define o percentual da base ST para o estado do RJ.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Percbasestrj")]
        public double? PercentualBaseStRj { get; set; }

        /// <summary>
        /// Define o percentual de acréscimo FUNCEP
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Peracrescimofuncep")]
        public double? PercentualAcrescimoFuncep { get; set; }

        /// <summary>
        /// Define a alicota de ICMS para produtor rural
        /// </summary>
        [ValorEntre(0, 999999.9999)]
        [JsonProperty("Codicmprodrural")]
        public double? AlicotaIcmsProdutorRural { get; set; }

        /// <summary>
        /// Define o código CFOP para venda pronta entrega dentro do estado.
        /// * Obrigatório se utilizar o processo venda pronta entrega.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Codfiscalvendaprontaent")]
        public long? CodigoCfopVendaProntaEntregaEstadual { get; set; }

        /// <summary>
        /// Define o código CFOP para venda pronta entrega fora do estado.
        /// * Obrigatório se utilizar o processo venda pronta entrega.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Codfiscalvendaprontaentinter")]
        public long? CodigoCfopVendaProntaEntregaInterEstadual { get; set; }

        /// <summary>
        /// Define o código CFOP para venda bonificada pronta entrega dentro do estado.
        /// * Obrigatório se utilizar o processo venda pronta entrega.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Codfiscalbonific")]
        public long? CodigoCfopBonificacaoProntaEntregaEstadual { get; set; }

        /// <summary>
        /// Define o código CFOP para venda bonificada pronta entrega fora do estado.
        /// * Obrigatório se utilizar o processo venda pronta entrega.
        /// </summary>
        [ValorEntre(0, 9999999999)]
        [JsonProperty("Codfiscalbonificinter")]
        public long? CodigoCfopBonificacaoProntaEntregaInterEstadual { get; set; }

        /// <summary>
        /// Hash para controle de integração, usado para excluir uma entidade.
        /// </summary>
        [TamanhoMaximo(128)]
        public string Hash { get; set; }

        /// <summary>
        /// Define a formula do preço venda.
        /// * Obrigatório para realização do cálculo do FECP, Identifica qual o tipo de FECP a ser calculado pela aplicação.
        /// </summary>
        [TamanhoMaximo(50)]
        [JsonProperty("Formulapvenda")]
        public string FormulaPrecoVenda { get; set; }


        /// <summary>
        /// Define a situação tributária.
        /// </summary>
        /// <value>
        ///<br>00 - Tributada integralmente</br>
        ///<br>10 - Tributada e com cobrança do ICMS por substituição tributária</br>
        ///<br>20 - Com redução de base de cálculo</br>
        ///<br>30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária</br>
        ///<br>40 - Isenta</br>
        ///<br>41 - Não tributada</br>
        ///<br>50 - Suspensão</br>
        ///<br>51 - Diferimento</br>
        ///<br>60 - ICMS cobrado anteriormente por substituição tributária</br>
        ///<br>70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária</br>
        ///<br>90 - Outras.</br>
        ///<br>101 - Tributada pelo Simples Nacional com permissão de crédito</br>
        ///<br>102 - Tributada pelo Simples Nacional sem permissão de crédito</br>
        ///<br>103 - Isenção do ICMS no Simples Nacional para faixa de receita bruta</br>
        ///<br>201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por substituição tributária</br>
        ///<br>202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por substituição tributária</br>
        ///<br>203 - Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do ICMS por substituição tributária</br>
        ///<br>300 - Imune</br>
        ///<br>400 - Não tributada pelo Simples Nacional</br>
        ///<br>500 - ICMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação</br>
        ///<br>900 - Outros</br>
        /// </value>
        [RangeString("00", "10", "20", "30", "40", "41", "50", "51", "60", "70", "90", "101", "102", "103", "201", "202", "203", "300", "400", "500", "900")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Sittribut")]
        public string SituacaoTributaria { get; set; }

        /// <summary>
        /// Define a situação tributária.
        /// </summary>
        /// <value>
        ///<br>00 - Tributada integralmente</br>
        ///<br>10 - Tributada e com cobrança do ICMS por substituição tributária</br>
        ///<br>20 - Com redução de base de cálculo</br>
        ///<br>30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária</br>
        ///<br>40 - Isenta</br>
        ///<br>41 - Não tributada</br>
        ///<br>50 - Suspensão</br>
        ///<br>51 - Diferimento</br>
        ///<br>60 - ICMS cobrado anteriormente por substituição tributária</br>
        ///<br>70 - Com redução de base de cálculo e cobrança do ICMS por substituição tributária</br>
        ///<br>90 - Outras.</br>
        ///<br>101 - Tributada pelo Simples Nacional com permissão de crédito</br>
        ///<br>102 - Tributada pelo Simples Nacional sem permissão de crédito</br>
        ///<br>103 - Isenção do ICMS no Simples Nacional para faixa de receita bruta</br>
        ///<br>201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por substituição tributária</br>
        ///<br>202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por substituição tributária</br>
        ///<br>203 - Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do ICMS por substituição tributária</br>
        ///<br>300 - Imune</br>
        ///<br>400 - Não tributada pelo Simples Nacional</br>
        ///<br>500 - ICMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação</br>
        ///<br>900 - Outros</br>
        /// </value>
        [RangeString("00", "10", "20", "30", "40", "41", "50", "51", "60", "70", "90", "101", "102", "103", "201", "202", "203", "300", "400", "500", "900")]
        [CampoObrigatorioAoInserir]
        [JsonProperty("Sittributpf")]
        public string SituacaoTributariaPessoaFisica { get; set; }

        /// <summary>
        /// Utilizar Valor da Última Entrada como Base ST (Decreto Nº 40.016/2006 RJ.)
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Usavalorultentbasest")]
        public string UtilizaValorUltimaEntradaBaseSt { get; set; }

        /// <summary>
        /// Utilizar Valor da Última Entrada para o Cálculo do ICMS a ser Reduzido do Valor do ST.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Usavalorultentbasest2")]
        public string UtilizaValorUltimaEntradaBaseSt2 { get; set; }

        /// <summary>
        /// Exibe o preço sem ST na venda
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Mostrarpvendasemst")]
        public string ExibePrecoSemStNaVenda { get; set; }

        /// <summary>
        /// Aplica acréscimo de pessoa PJ isenta?
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Aplicaacrescpjisenta")]
        public string AplicaAcrescimoPjIsento { get; set; }

        /// <summary>
        /// Exibe preço venda sem IPI
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Mostrarpvendasemipi")]
        public string ExibePrecoVendaSemIPI { get; set; }

        /// <summary>
        /// Usa valor de última entrada médio para base de ST
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Usavlultentmediobasest")]
        public string UtilizaValorUltimaEntradaMedioBaseSt { get; set; }

        /// <summary>
        /// Agrega IPI ao cálculo da ST
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Agregaripicalculost")]
        public string AgregaIpiCalculoSt { get; set; }

        /// <summary>
        /// Flag para informar se a figura tributária é partilha
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Figurapartilha")]
        public string FiguraTributariaPartilha { get; set; }

        /// <summary>
        /// Define a descrição da tributação.
        /// </summary>
        [TamanhoMaximo(100)]
        [JsonProperty("Obs")]
        public string Observacao { get; set; }

        /// <summary>
        /// Define o percentual de diferimento do ICMS.
        /// </summary>
        [ValorEntre(0, 9999.9999)]
        [JsonProperty("Perdifereimentoicms")]
        public double PercentualDiferimentoIcms { get; set; }

        /// <summary>
        /// Define se utiliza porcentagem de redução para pessoa física.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Utilizapercbaseredpf")]
        public string UtilizaPercentualBaseReducaoPessoaFisica { get; set; }

        /// <summary>
        /// Identifica se a aplicação irá utilizar o motor de fórmulas da Máxima, obrigatório para realização do cálculo do FECP.
        /// </summary>
        /// <value>
        /// S - Sim ou N - Não
        /// </value>
        [RangeString("S", "N")]
        [JsonProperty("Utilizamotorcalculo")]
        public string UtilizaMotorCalculoMaxima { get; set; }

        internal const string VersaoAPI = "v3";
        internal const string EndPoint = "Tributos";
        internal const string Tabela = "MXSTRIBUT";
    }
}

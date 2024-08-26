using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Api;
using Maxima.Net.SDK.Integracao.Api.Controllers;
using Maxima.Net.SDK.Integracao.Entidades;
using Microsoft.Extensions.DependencyInjection;

namespace Maxima.Net.SDK.Integracao.Utils
{
    public static class MaximaSdkServiceCollectionsExtensions
    {
        public static IServiceCollection AddMaximaSdkService(this IServiceCollection services)
        {
            services.AddSingleton<IApiMaxima, ApiMaxima>();
            services.AddSingleton<MaximaIntegracao>();
            services.AddTransient<ApiBase<RamoAtividadeMaxima>, RamoAtividadeMaximaApi>();
            services.AddTransient<ApiBase<AtividadeEconomicaMaxima>, AtividadeEconomicaMaximaApi>();
            services.AddTransient<ApiBase<BancoMaxima>, BancoMaximaApi>();
            services.AddTransient<ApiBase<BrindePremioMaxima>, BrindePremioMaximaApi>();
            services.AddTransient<ApiBase<BrindeRestricaoMaxima>, BrindeRestricaoMaximaApi>();
            services.AddTransient<ApiBase<BrindeValidacaoMaxima>, BrindeValidacaoMaximaApi>();
            services.AddTransient<ApiBase<ContatoMaxima>, ContatoMaximaApi>();
            services.AddTransient<ApiBase<ContaBancariaMaxima>, ContaBancariaMaximaApi>();
            services.AddTransient<ApiBase<CidadeMaxima>, CidadeMaximaApi>();
            services.AddTransient<ApiBase<TipoOperacaoMaxima>, TipoOperacaoMaximaApi>();
            services.AddTransient<ApiBase<ClienteMaxima>, ClienteMaximaApi>();
            services.AddTransient<ApiBase<ClienteVendedorMaxima>, ClienteVendedorMaximaApi>();
            services.AddTransient<
                ApiBase<ProfissionalPorClienteMaxima>,
                ProfissionalPorClienteMaximaApi
            >();
            services.AddTransient<ApiBase<CotacaoCapaMaxima>, CotacaoCapaMaximaApi>();
            services.AddTransient<ApiBase<CotacaoItensMaxima>, CotacaoItensMaximaApi>();
            services.AddTransient<ApiBase<CotasDeProdutoMaxima>, CotasDeProdutoMaximaApi>();
            services.AddTransient<ApiBase<EmbalagemMaxima>, EmbalagemMaximaApi>();
            services.AddTransient<ApiBase<DepartamentoMaxima>, DepartamentoMaximaApi>();
            services.AddTransient<ApiBase<DescontoMaxima>, DescontoMaximaApi>();
            services.AddTransient<ApiBase<TitulosMaxima>, TitulosMaximaApi>();
            services.AddTransient<
                ApiBase<NotaFiscalEletronicaMaxima>,
                NotaFiscalEletronicaMaximaApi
            >();
            services.AddTransient<ApiBase<EstoqueMaxima>, EstoqueMaximaApi>();
            services.AddTransient<ApiBase<FamiliaMaxima>, FamiliaMaximaApi>();
            services.AddTransient<ApiBase<MensagemMaxima>, MensagemMaximaApi>();
            services.AddTransient<
                ApiBase<CreditoDisponivelPorClienteMaxima>,
                CreditoDisponivelPorClienteMaximaApi
            >();
            services.AddTransient<ApiBase<FilialMaxima>, FilialMaximaApi>();
            services.AddTransient<ApiBase<FilialRegiaoMaxima>, FilialRegiaoMaximaApi>();
            services.AddTransient<
                ApiBase<FilialRetiradaEstoqueMaxima>,
                FilialRetiradaEstoqueMaximaApi
            >();
            services.AddTransient<ApiBase<FornecedorMaxima>, FornecedorMaximaApi>();
            services.AddTransient<
                ApiBase<PedidosProcessadosWMSMaxima>,
                PedidosProcessadosWMSMaximaApi
            >();
            services.AddTransient<ApiBase<ProdutoMaxima>, ProdutoMaximaApi>();
            services.AddTransient<ApiBase<ProdutoAgregadoMaxima>, ProdutoAgregadoMaximaApi>();
            services.AddTransient<
                ApiBase<ProdutoCampanhaDescontoMaxima>,
                ProdutoCampanhaDescontoMaximaApi
            >();
            services.AddTransient<ApiBase<ProdutoSimilarMaxima>, ProdutoSimilarMaximaApi>();
            services.AddTransient<ApiBase<MarcaMaxima>, MarcaMaximaApi>();
            services.AddTransient<ApiBase<MixProdutoClienteMaxima>, MixProdutoClienteMaximaApi>();
            services.AddTransient<ApiBase<CategoriaMaxima>, CategoriaMaximaApi>();
            services.AddTransient<ApiBase<SubCategoriaMaxima>, SubCategoriaMaximaApi>();
            services.AddTransient<ApiBase<ProdutosPorFilialMaxima>, ProdutosPorFilialMaximaApi>();
            services.AddTransient<ApiBase<RedeClienteMaxima>, RedeClienteMaximaApi>();
            services.AddTransient<ApiBase<RotaClienteMaxima>, RotaClienteMaximaApi>();
            services.AddTransient<ApiBase<PrazoAdicionalMaxima>, PrazoAdicionalMaximaApi>();
            services.AddTransient<
                ApiBase<ReferenciaComercialClienteMaxima>,
                ReferenciaComercialClienteMaximaApi
            >();
            services.AddTransient<ApiBase<TransportadoraMaxima>, TransportadoraMaximaApi>();
            services.AddTransient<ApiBase<VendedorMaxima>, VendedorMaximaApi>();
            services.AddTransient<ApiBase<GerenteMaxima>, GerenteMaximaApi>();
            services.AddTransient<ApiBase<VisitaVendedorMaxima>, VisitaVendedorMaximaApi>();
            services.AddTransient<
                ApiBase<ComissaoProfissionalMaxima>,
                ComissaoProfissionalMaximaApi
            >();
            services.AddTransient<ApiBase<PracaMaxima>, PracaMaximaApi>();
            services.AddTransient<
                ApiBase<PrevisaoRecebimentoMercadoriaMaxima>,
                PrevisaoRecebimentoMercadoriaMaximaApi
            >();
            services.AddTransient<ApiBase<RegiaoMaxima>, RegiaoMaximaApi>();
            services.AddTransient<ApiBase<RegiaoClienteMaxima>, RegiaoClienteMaximaApi>();
            services.AddTransient<ApiBase<PlanoPagamentoMaxima>, PlanoPagamentoMaximaApi>();
            services.AddTransient<
                ApiBase<PlanoPagamentoPorClienteMaxima>,
                PlanoPagamentoPorClienteMaximaApi
            >();
            services.AddTransient<
                ApiBase<PlanoPagamentoPorRegiaoMaxima>,
                PlanoPagamentoPorRegiaoMaximaApi
            >();
            services.AddTransient<
                ApiBase<PlanoPagamentoPorFilialMaxima>,
                PlanoPagamentoPorFilialMaximaApi
            >();
            services.AddTransient<
                ApiBase<PlanoPagamentoPorProdutoMaxima>,
                PlanoPagamentoPorProdutoMaximaApi
            >();
            services.AddTransient<ApiBase<ConcorrenteMaxima>, ConcorrenteMaximaApi>();
            services.AddTransient<ApiBase<CobrancaMaxima>, CobrancaMaximaApi>();
            services.AddTransient<ApiBase<CobrancaClienteMaxima>, CobrancaClienteMaximaApi>();
            services.AddTransient<
                ApiBase<CobrancaPlanoPagamentoMaxima>,
                CobrancaPlanoPagamentoMaximaApi
            >();
            services.AddTransient<ApiBase<TabelaPrecoMaxima>, TabelaPrecoMaximaApi>();
            services.AddTransient<
                ApiBase<TabelasDePrecoPorClienteMaxima>,
                TabelasDePrecoPorClienteMaximaApi
            >();
            services.AddTransient<
                ApiBase<PoliticaDeAcrescimoPorClienteMaxima>,
                PoliticaDeAcrescimoPorClienteMaximaApi
            >();
            services.AddTransient<ApiBase<EnderecoClienteMaxima>, EnderecoClienteMaximaApi>();
            services.AddTransient<ApiBase<HistoricoPedidoFaltaMaxima>, HistoricoPedidoFaltaApi>();
            services.AddTransient<
                ApiBase<Dto.Pedido.HistoricoPedidoCapa>,
                HistoricoCapaMaximaApi
            >();
            services.AddTransient<
                ApiBase<Dto.Pedido.HistoricoPedidoItem>,
                HistoricoItensMaximaApi
            >();
            services.AddTransient<ApiBase<SetorMaxima>, SetorMaximaApi>();
            services.AddTransient<ApiBase<MetaMaxima>, MetaMaximaApi>();
            services.AddTransient<ApiBase<MetaVendedorMaxima>, MetaVendedorMaximaApi>();
            services.AddTransient<ApiBase<EstoqueCestaMaxima>, EstoqueCestaMaximaApi>();
            services.AddTransient<ApiBase<EmpregadoMaxima>, EmpregadoMaximaApi>();
            services.AddTransient<ApiBase<CarregamentoMaxima>, CarregamentoMaximaApi>();
            services.AddTransient<ApiBase<VeiculoMaxima>, VeiculoMaximaApi>();
            services.AddTransient<ApiBase<NotaSaidaCapaMaxima>, NotaSaidaCapaMaximaApi>();
            services.AddTransient<ApiBase<NotaSaidaItensMaxima>, NotaSaidaItensMaximaApi>();
            services.AddTransient<ApiBase<EstornoComissaoMaxima>, EstornoComissaoMaximaApi>();
            services.AddTransient<
                ApiBase<FaixaComissaoVendedorMaxima>,
                FaixaComissaoVendedorMaximaApi
            >();
            services.AddTransient<ApiBase<HistoricoPedidoCorteMaxima>, HistoricoPedidoCorteApi>();
            services.AddTransient<ApiBase<SupervisorMaxima>, SupervisorMaximaApi>();
            services.AddTransient<
                ApiBase<MovimentoVendaPendenteWMSMaxima>,
                MovimentoVendaPendenteWMSMaximaApi
            >();
            services.AddTransient<ApiBase<LoteMaxima>, LoteMaximaApi>();
            services.AddTransient<ApiBase<TributosCapaMaxima>, TributosCapaMaximaApi>();
            services.AddTransient<ApiBase<DescontoItemMaxima>, DescontoItemMaximaApi>();
            services.AddTransient<ApiBase<DescontoRestricaoMaxima>, DescontoRestricaoMaximaApi>();
            services.AddTransient<ApiBase<EstadoMaxima>, EstadoMaximaApi>();
            services.AddTransient<ApiBase<LocalizacaoClienteMaxima>, LocalizacaoClienteMaximaApi>();
            services.AddTransient<ApiBase<TributosItemMaxima>, TributosItemMaximaApi>();
            services.AddTransient<ApiBase<SecaoMaxima>, SecaoMaximaApi>();
            services.AddTransient<ApiBase<RestricaoVendaMaxima>, RestricaoVendaMaximaApi>();
            services.AddTransient<ApiBase<BrindeMaxima>, BrindeMaximaApi>();
            services.AddTransient<ApiBase<ComissaoRegiaoMaxima>, ComissaoRegiaoMaximaApi>();
            services.AddTransient<ApiBase<ComissaoVendedorMaxima>, ComissaoVendedorMaximaApi>();
            services.AddTransient<
                ApiBase<SaldoContaCorrenteVendedorMaxima>,
                SaldoContaCorrenteVendedorMaximaApi
            >();
            services.AddTransient<ApiBase<VisitaMaxima>, VisitaMaximaApi>();
            services.AddTransient<ApiBase<MotivoVisitaMaxima>, MotivoVisitaMaximaApi>();
            services.AddTransient<ApiBase<VendedorFornecedorMaxima>, VendedorFornecedorMaximaApi>();
            services.AddTransient<ApiBase<CfopMaxima>, CfopMaximaApi>();
            services.AddTransient<ApiBase<CategoriaDespesaMaxima>, CategoriaDespesaMaximaApi>();
            services.AddTransient<ApiBase<PrestacaoContaItemMaxima>, PrestacaoContaItemMaximaApi>();
            services.AddTransient<ApiBase<MotivoNaoCompraMaxima>, MotivoNaoCompraMaximaApi>();
            services.AddTransient<ApiBase<MotivoDevolucaoMaxima>, MotivoDevolucaoMaximaApi>();
            services.AddTransient<
                ApiBase<NotaFiscalEntradaCapaMaxima>,
                NotaFiscalEntradaCapaMaximaApi
            >();
            services.AddTransient<ApiBase<PrestacaoContaCapaMaxima>, PrestacaoContaCapaMaximaApi>();
            services.AddTransient<ApiBase<PrecoCestaMaxima>, PrecoCestaMaximaApi>();
            services.AddTransient<ApiBase<PrecoCestaItemMaxima>, PrecoCestaItemMaximaApi>();
            services.AddTransient<ApiBase<PrecoPromocaoMaxima>, PrecoPromocaoMaximaApi>();
            services.AddTransient<ApiBase<TipoBonificacaoMaxima>, TipoBonificacaoMaximaApi>();
            services.AddTransient<ApiBase<LimiteComboMaxima>, LimiteComboMaximaApi>();
            services.AddTransient<ApiBase<ConfiguracaoERPMaxima>, ConfiguracaoERPMaximaApi>();
            services.AddTransient<ApiBase<DescontoCapaMaxima>, DescontoCapaMaximaApi>();
            services.AddTransient<ApiBase<ValidadeProdutoWMSMaxima>, ValidadeProdutoWMSMaximaApi>();
            services.AddTransient<ApiBase<DescontoCategoriaMaxima>, DescontoCategoriaMaximaApi>();
            services.AddTransient<ApiBase<ProdutoCestaMaxima>, ProdutoCestaMaximaApi>();
            services.AddTransient<ApiBase<TabelaPrecoCestaMaxima>, TabelaPrecoCestaMaximaApi>();
            services.AddTransient<
                ApiBase<NotaFiscalStatusEntregaMaxima>,
                NotaFiscalStatusEntregaMaximaApi
            >();
            services.AddTransient<ApiBase<RomaneioMaxima>, RomanerioMaximaApi>();
            services.AddTransient<PedidoMaximaApi>();
            services.AddTransient<StatusClienteMaximaApi>();

            return services;
        }
    }
}

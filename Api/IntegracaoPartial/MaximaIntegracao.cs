using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maxima.Net.SDK.Integracao.Abastractions;
using Maxima.Net.SDK.Integracao.Api.Controllers;
using Maxima.Net.SDK.Integracao.Dto.Pedido;
using Maxima.Net.SDK.Integracao.Entidades;

namespace Maxima.Net.SDK.Integracao.Api
{
    /// <summary>
    /// Para iniciar e manter o SDK é necessário fazer o login com o usuário da Máxima através do RealizarLogin <br/>
    /// <br/>
    /// Na primeira execução deve realizar a carga inicial das entidades da MaximaIntegracao <br/>
    /// Importante fazer o cadastro inicial das tabelas referente a cadastros básicos e depois as demais tabelas <br/>
    /// Preferencialmente seguir a ordem abaixo:  <br/>
    /// * Cadastro de Cidades <br/>
    /// * Cadastro de Filiais <br/>
    /// * Cadastro de Tipo de Atividades do cliente <br/>
    /// * Cadastro de Tipo de Cobrança <br/>
    /// * Cadastro de Forma de pagamento <br/>
    /// * Cadastro de Bancos <br/>
    /// * Cadastro de Vendedores <br/>
    /// * Cadastro de Fornecedores <br/>
    /// * Cadastro de Transportadoras <br/>
    /// * Cadastro de Clientes <br/>
    /// * Cadastro de Produtos <br/>
    /// * Cadastro de Títulos <br/>
    /// * Cadastro de Histórico dos Pedidos <br/>
    /// <br/>
    /// Após a primeira Carga inicial, as Jobs serão executadas via Hangfire conforme o agendamento pré definido <br/>
    ///  <br/>
    /// </summary>
    public partial class MaximaIntegracao
    {
        /// <summary>
        /// Listener para ouvir quando um pedido máxima entrou.
        /// </summary>
        public Action<PedidoMaxima> OnIncluirPedido;

        /// <summary>
        /// Listener para ouvir quando um pedido muda de status.
        /// </summary>
        public Action<string> OnStatusPedido;
        private readonly IApiMaxima _apiMaxima;
        private readonly ApiBase<RamoAtividadeMaxima> _ramoAtividadeMaximaApi;
        private readonly ApiBase<AtividadeEconomicaMaxima> _atividadeEconomicaMaximaApi;
        private readonly ApiBase<CarregamentoMaxima> _carregamentoMaximaApi;
        private readonly ApiBase<RomaneioMaxima> _romaneioMaximaApi;
        private readonly ApiBase<VeiculoMaxima> _veiculoMaximaApi;
        private readonly ApiBase<BancoMaxima> _bancoMaximaApi;
        private readonly ApiBase<BrindePremioMaxima> _brindePremioMaximaApi;
        private readonly ApiBase<BrindeRestricaoMaxima> _brindeRestricaoMaximaApi;
        private readonly ApiBase<BrindeValidacaoMaxima> _brindeValidacaoMaximaApi;
        private readonly ApiBase<ContatoMaxima> _contatoMaximaApi;
        private readonly ApiBase<ContaBancariaMaxima> _contaBancariaMaximaApi;
        private readonly ApiBase<CidadeMaxima> _cidadeMaximaApi;
        private readonly ApiBase<TipoOperacaoMaxima> _tipoOperacaoMaximaApi;
        private readonly ApiBase<ClienteMaxima> _clienteMaximaApi;
        private readonly ApiBase<ClienteVendedorMaxima> _clienteVendedorMaximaApi;
        private readonly ApiBase<ProfissionalPorClienteMaxima> _profissionalPorClienteMaximaApi;
        private readonly ApiBase<CotacaoCapaMaxima> _cotacaoCapaMaximaApi;
        private readonly ApiBase<CotacaoItensMaxima> _cotacaoItensMaximaApi;
        private readonly ApiBase<CotasDeProdutoMaxima> _cotasDeProdutoMaximaApi;
        private readonly ApiBase<EmbalagemMaxima> _embalagemMaximaApi;
        private readonly ApiBase<DepartamentoMaxima> _departamentoMaximaApi;
        private readonly ApiBase<DescontoMaxima> _descontoMaximaApi;
        private readonly ApiBase<PrazoAdicionalMaxima> _prazoAdicionalMaximaApi;
        private readonly ApiBase<EstoqueMaxima> _estoqueMaximaApi;
        private readonly ApiBase<MensagemMaxima> _mensagemMaximaApi;
        private readonly ApiBase<TitulosMaxima> _erpPrestMaximaApi;
        private readonly ApiBase<NotaFiscalEletronicaMaxima> _notaFiscalEletronicaMaximaApi;
        private readonly ApiBase<FamiliaMaxima> _familiaMaximaApi;
        private readonly ApiBase<CreditoDisponivelPorClienteMaxima> _creditoDisponivelPorClienteMaximaApi;
        private readonly ApiBase<FilialMaxima> _filialMaximaApi;
        private readonly ApiBase<FilialRegiaoMaxima> _filialRegiaoMaximaApi;
        private readonly ApiBase<FilialRetiradaEstoqueMaxima> _filialRetiradaEstoqueMaximaApi;
        private readonly ApiBase<FornecedorMaxima> _fornecedorMaximaApi;
        private readonly ApiBase<VendedorFornecedorMaxima> _vendedorFornecedorApi;
        private readonly ApiBase<CfopMaxima> _cfopMaxima;
        private readonly ApiBase<PedidosProcessadosWMSMaxima> _pedidosProcessadosWMSMaximaMaximaApi;
        private readonly ApiBase<ProdutoMaxima> _produtoMaximaApi;
        private readonly ApiBase<ProdutoAgregadoMaxima> _produtoAgregadoMaximaApi;
        private readonly ApiBase<ProdutoCampanhaDescontoMaxima> _produtoCampanhaDescontoMaximaApi;
        private readonly ApiBase<ProdutoSimilarMaxima> _produtoSimilarMaximaApi;
        private readonly ApiBase<MarcaMaxima> _marcaMaximaApi;
        private readonly ApiBase<MixProdutoClienteMaxima> _mixProdutoClienteMaximaApi;
        private readonly ApiBase<CategoriaMaxima> _categoriaMaximaApi;
        private readonly ApiBase<SubCategoriaMaxima> _subCategoriaMaximaApi;
        private readonly ApiBase<ProdutosPorFilialMaxima> _produtosPorFilialMaximaApi;
        private readonly ApiBase<RedeClienteMaxima> _redeMaximaApi;
        private readonly ApiBase<RotaClienteMaxima> _rotaClienteMaximaApi;
        private readonly ApiBase<ReferenciaComercialClienteMaxima> _referenciaComercialClienteMaxima;
        private readonly ApiBase<TransportadoraMaxima> _transportadoraMaximaApi;
        private readonly ApiBase<VendedorMaxima> _vendedorMaximaApi;
        private readonly ApiBase<VisitaVendedorMaxima> _visitaVendedorMaximaApi;
        private readonly ApiBase<ComissaoProfissionalMaxima> _comissaoProfissionalMaximaApi;
        private readonly ApiBase<PracaMaxima> _pracaMaximaApi;
        private readonly ApiBase<PrevisaoRecebimentoMercadoriaMaxima> _previsaoRecebimentoMercadoriaMaximaApi;
        private readonly ApiBase<Entidades.RegiaoMaxima> _regiaoMaximaApi;
        private readonly ApiBase<Entidades.RegiaoClienteMaxima> _regiaoClienteMaximaApi;
        private readonly ApiBase<PlanoPagamentoMaxima> _planoPagamentoApi;
        private readonly ApiBase<PlanoPagamentoPorClienteMaxima> _planoPagamentoPorClienteApi;
        private readonly ApiBase<PlanoPagamentoPorRegiaoMaxima> _planoPagamentoPorRegiaoApi;
        private readonly ApiBase<PlanoPagamentoPorFilialMaxima> _planoPagamentoPorFilialApi;
        private readonly ApiBase<PlanoPagamentoPorProdutoMaxima> _planoPagamentoPorProdutoApi;
        private readonly ApiBase<ConcorrenteMaxima> _concorrenteMaximaApi;
        private readonly ApiBase<CobrancaMaxima> _cobrancaMaximaApi;
        private readonly ApiBase<CobrancaClienteMaxima> _cobrancaClienteMaximaApi;
        private readonly ApiBase<CobrancaPlanoPagamentoMaxima> _cobrancaPlanoPagamentoMaximaApi;
        private readonly ApiBase<TabelaPrecoMaxima> _tabelaDePrecoMaxima;
        private readonly ApiBase<TabelasDePrecoPorClienteMaxima> _tabelasDePrecoPorClienteMaximaApi;
        private readonly ApiBase<PoliticaDeAcrescimoPorClienteMaxima> _politicaDeAcrescimoPorClienteMaximaApi;
        private readonly ApiBase<EnderecoClienteMaxima> _enderecoClienteMaximaApi;
        private readonly ApiBase<HistoricoPedidoFaltaMaxima> _historicoPedidoFaltaApi;
        private readonly ApiBase<HistoricoPedidoCorteMaxima> _historicoPedidoCorteMaximaApi;
        private readonly ApiBase<EmpregadoMaxima> _empregadoMaximaApi;
        private readonly ApiBase<SetorMaxima> _setorMaximaApi;
        private readonly ApiBase<CategoriaDespesaMaxima> _categoriaDespesaMaximaApi;
        private readonly ApiBase<PrestacaoContaItemMaxima> _prestacaoContaItemMaximaApi;
        private readonly ApiBase<MetaMaxima> _metaMaximaApi;
        private readonly ApiBase<MetaVendedorMaxima> _metaVendedorMaximaApi;
        private readonly ApiBase<NotaSaidaCapaMaxima> _notaSaidaMaximaApi;
        private readonly ApiBase<NotaSaidaItensMaxima> _notaSaidaItensMaximaApi;
        private readonly ApiBase<EstornoComissaoMaxima> _estornoComissaoMaximaApi;
        private readonly ApiBase<FaixaComissaoVendedorMaxima> _faixaComissaoVendedorMaximaApi;
        private readonly ApiBase<Entidades.SupervisorMaxima> _supervisorMaximaApi;
        private readonly ApiBase<Entidades.GerenteMaxima> _gerenteMaximaApi;
        private readonly ApiBase<MovimentoVendaPendenteWMSMaxima> _movimentoVendaPendenteWMSApi;
        private readonly ApiBase<LoteMaxima> _loteMaximaApi;
        private readonly ApiBase<TributosCapaMaxima> _tributosCapaApi;
        private readonly ApiBase<DescontoItemMaxima> _descontoItemMaxima;
        private readonly ApiBase<DescontoRestricaoMaxima> _descontoRestricaoMaxima;
        private readonly ApiBase<EstadoMaxima> _estadoMaximaApi;
        private readonly ApiBase<LocalizacaoClienteMaxima> _localizacaoClienteMaxima;
        private readonly ApiBase<TributosItemMaxima> _tributosItemMaximaApi;
        private readonly ApiBase<EstoqueCestaMaxima> _estoqueCestaMaximaApi;
        private readonly ApiBase<SecaoMaxima> _secaoMaximaApi;
        private readonly ApiBase<RestricaoVendaMaxima> _restricaoVendaMaximaApi;
        private readonly ApiBase<BrindeMaxima> _brindeMaximaApi;
        private readonly ApiBase<ComissaoRegiaoMaxima> _comissaoRegiaoApi;
        private readonly ApiBase<ComissaoVendedorMaxima> _comissaoVendedorApi;
        private readonly ApiBase<SaldoContaCorrenteVendedorMaxima> _saldoContaCorrenteVendedorMaximaApi;
        private readonly ApiBase<MotivoVisitaMaxima> _motivoVisitaMaximaApi;
        private readonly ApiBase<MotivoNaoCompraMaxima> _motivoNaoCompraMaximaApi;
        private readonly ApiBase<VisitaMaxima> _visitaMaximaApi;
        private readonly ApiBase<MotivoDevolucaoMaxima> _motivoDevolucaoMaximaApi;
        private readonly ApiBase<NotaFiscalEntradaCapaMaxima> _notaFiscalEntradaCapaMaximaApi;
        private readonly ApiBase<PrestacaoContaCapaMaxima> _prestacaoContaCapaMaximaApi;
        private readonly ApiBase<PrecoCestaMaxima> _precoCestaMaximaApi;
        private readonly ApiBase<PrecoCestaItemMaxima> _precoCestaItemMaximaApi;
        private readonly ApiBase<PrecoPromocaoMaxima> _precoPromocaoMaximaApi;
        private readonly ApiBase<TipoBonificacaoMaxima> _tipoBonificacaoMaximaApi;
        private readonly ApiBase<LimiteComboMaxima> _limiteComboMaxima;
        private readonly ApiBase<ConfiguracaoERPMaxima> _configuracaoERPApi;
        private readonly ApiBase<DescontoCapaMaxima> _descontoCapaApi;
        private readonly ApiBase<ValidadeProdutoWMSMaxima> _validadeProdutoWMSMaximaApi;
        private readonly ApiBase<DescontoCategoriaMaxima> _descontoCategoriaApi;
        private readonly ApiBase<ProdutoCestaMaxima> _produtoCestaApi;
        private readonly ApiBase<TabelaPrecoCestaMaxima> _tabelaPrecoCestaApi;
        private readonly ApiBase<NotaFiscalStatusEntregaMaxima> _notaFiscalStatusEntregaApi;
        private readonly PedidoMaximaApi _pedidoMaximaApi;
        private readonly StatusClienteMaximaApi _statusClienteMaximaApi;

        public MaximaIntegracao(
            IApiMaxima apiMaxima,
            ApiBase<RamoAtividadeMaxima> apiRamoAtividade,
            ApiBase<AtividadeEconomicaMaxima> apiAtividadeEconomica,
            ApiBase<BancoMaxima> apiBanco,
            ApiBase<BrindePremioMaxima> apiBrindePremio,
            ApiBase<BrindeRestricaoMaxima> apiBrindeRestricao,
            ApiBase<BrindeValidacaoMaxima> apiBrindeValidacao,
            ApiBase<ContatoMaxima> apiContato,
            ApiBase<ContaBancariaMaxima> apiContaBancaria,
            ApiBase<CidadeMaxima> cidadeMaxima,
            ApiBase<TipoOperacaoMaxima> tipoOperacaoMaximaApi,
            ApiBase<ClienteMaxima> apiCliente,
            ApiBase<ClienteVendedorMaxima> apiClienteVendedor,
            ApiBase<ProfissionalPorClienteMaxima> profissionalPorClienteMaximaApi,
            ApiBase<CotacaoCapaMaxima> apiCotacaoCapa,
            ApiBase<CotacaoItensMaxima> apiCotacaoItens,
            ApiBase<CotasDeProdutoMaxima> apiCotasDeProduto,
            ApiBase<EmbalagemMaxima> apiEmbalagem,
            ApiBase<DepartamentoMaxima> apiDepartamento,
            ApiBase<DescontoMaxima> apiDesconto,
            ApiBase<PrazoAdicionalMaxima> prazoAdicionalMaxima,
            ApiBase<EstoqueMaxima> apiEstoque,
            ApiBase<MensagemMaxima> mensagemMaximaApi,
            ApiBase<TitulosMaxima> apiErpPrest,
            ApiBase<NotaFiscalEletronicaMaxima> notaFiscalEletronicaMaximaApi,
            ApiBase<FamiliaMaxima> apiFamilia,
            ApiBase<CreditoDisponivelPorClienteMaxima> creditoDisponivelPorClienteMaximaApi,
            ApiBase<FilialMaxima> apiFilial,
            ApiBase<FilialRegiaoMaxima> apiFilialRegiao,
            ApiBase<FilialRetiradaEstoqueMaxima> apiFilialRetiradaEstoque,
            ApiBase<FornecedorMaxima> apiFornecedor,
            ApiBase<VendedorFornecedorMaxima> vendedorFornecedorApi,
            ApiBase<CfopMaxima> cfopMaxima,
            ApiBase<PedidosProcessadosWMSMaxima> apiPedidosProcessadosWMS,
            ApiBase<ProdutoMaxima> apiProduto,
            ApiBase<ProdutoAgregadoMaxima> produtoAgregadoMaximaApi,
            ApiBase<ProdutoCampanhaDescontoMaxima> apiProdutoCampanhaDesconto,
            ApiBase<ProdutoSimilarMaxima> produtoSimilarMaximaApi,
            ApiBase<MarcaMaxima> apiMarca,
            ApiBase<MixProdutoClienteMaxima> apiMixProdutoCliente,
            ApiBase<CategoriaMaxima> categoriaMaximaApi,
            ApiBase<SubCategoriaMaxima> subCategoriaMaximaApi,
            ApiBase<ProdutosPorFilialMaxima> apiProdutosPorFilial,
            ApiBase<RedeClienteMaxima> redeMaximaApi,
            ApiBase<RotaClienteMaxima> rotaClienteMaximaApi,
            ApiBase<ReferenciaComercialClienteMaxima> referenciaComercialClienteMaxima,
            ApiBase<TransportadoraMaxima> transportadoraMaxima,
            ApiBase<VendedorMaxima> apiVendedor,
            ApiBase<VisitaVendedorMaxima> apiVisitaVendedor,
            ApiBase<ComissaoProfissionalMaxima> comissaoProfissionalMaximaApi,
            StatusClienteMaximaApi apiStatusCliente,
            PedidoMaximaApi pedidoMaximaApi,
            ApiBase<PracaMaxima> pracaMaximaApi,
            ApiBase<PrevisaoRecebimentoMercadoriaMaxima> previsaoRecebimentoMercadoriaMaximaApi,
            ApiBase<Entidades.RegiaoMaxima> regiaoMaximaApi,
            ApiBase<Entidades.RegiaoClienteMaxima> regiaoClienteMaximaApi,
            ApiBase<PlanoPagamentoMaxima> planoPagamentoApi,
            ApiBase<PlanoPagamentoPorClienteMaxima> planoPagamentoPorClienteApi,
            ApiBase<PlanoPagamentoPorRegiaoMaxima> planoPagamentoPorRegiaoApi,
            ApiBase<PlanoPagamentoPorFilialMaxima> planoPagamentoPorFilialApi,
            ApiBase<PlanoPagamentoPorProdutoMaxima> planoPagamentoPorProdutoApi,
            ApiBase<ConcorrenteMaxima> concorrenteApi,
            ApiBase<CobrancaMaxima> cobrancaApi,
            ApiBase<CobrancaClienteMaxima> cobrancaClienteApi,
            ApiBase<CobrancaPlanoPagamentoMaxima> cobrancaPlanoPagamentoApi,
            ApiBase<CarregamentoMaxima> carregamentoApi,
            ApiBase<RomaneioMaxima> romaneioMaximaApi,
            ApiBase<VeiculoMaxima> veiculoApi,
            ApiBase<TabelaPrecoMaxima> tabelaPrecoApi,
            ApiBase<TabelasDePrecoPorClienteMaxima> tabelasDePrecoPorClienteMaximaApi,
            ApiBase<PoliticaDeAcrescimoPorClienteMaxima> politicaDeAcrescimoPorClienteMaximaApi,
            ApiBase<EnderecoClienteMaxima> enderecoClienteMaximaApi,
            ApiBase<HistoricoPedidoFaltaMaxima> historicoPedidoFaltaApi,
            ApiBase<HistoricoPedidoCorteMaxima> historicoPedidoCorteMaximaApi,
            ApiBase<SetorMaxima> setorMaximaApi,
            ApiBase<CategoriaDespesaMaxima> categoriaDespesaMaximaApi,
            ApiBase<PrestacaoContaItemMaxima> prestacaoContaItemMaximaApi,
            ApiBase<MetaMaxima> metaMaximaApi,
            ApiBase<MetaVendedorMaxima> metaVendedorMaximaApi,
            ApiBase<NotaSaidaCapaMaxima> notaSaidaMaximaApi,
            ApiBase<NotaSaidaItensMaxima> notaSaidaItensMaximaApi,
            ApiBase<EstornoComissaoMaxima> estornoComissaoMaximaApi,
            ApiBase<FaixaComissaoVendedorMaxima> faixaComissaoVendedorMaximaApi,
            ApiBase<MovimentoVendaPendenteWMSMaxima> movimentoVendaPendenteWMSApi,
            ApiBase<EstadoMaxima> apiEstado,
            ApiBase<LocalizacaoClienteMaxima> localizacaoClienteMaxima,
            ApiBase<TributosItemMaxima> apiTributosItem,
            ApiBase<EstoqueCestaMaxima> estoqueCestaMaximaApi,
            ApiBase<Entidades.SupervisorMaxima> supervisorMaximaApi,
            ApiBase<Entidades.GerenteMaxima> gerenteMaximaApi,
            ApiBase<LoteMaxima> loteMaximaApi,
            ApiBase<TributosCapaMaxima> tributosCapaApi,
            ApiBase<DescontoItemMaxima> descontoItemMaxima,
            ApiBase<DescontoRestricaoMaxima> descontoRestricaoMaxima,
            ApiBase<SecaoMaxima> secaoMaximaApi,
            ApiBase<RestricaoVendaMaxima> restricaoVendaMaximaApi,
            ApiBase<BrindeMaxima> brindeMaximaApi,
            ApiBase<ComissaoRegiaoMaxima> comissaoRegiaoApi,
            ApiBase<ComissaoVendedorMaxima> comissaVendedorApi,
            ApiBase<SaldoContaCorrenteVendedorMaxima> saldoContaCorrenteVendedorMaximaApi,
            ApiBase<VisitaMaxima> visitaMaximaApi,
            ApiBase<MotivoVisitaMaxima> motivoVisitaMaximaApi,
            ApiBase<MotivoNaoCompraMaxima> motivoNaoCompraMaximaApi,
            ApiBase<MotivoDevolucaoMaxima> motivoDevolucaoMaximaApi,
            ApiBase<NotaFiscalEntradaCapaMaxima> notaFiscalEntradaCapaMaximaApi,
            ApiBase<PrestacaoContaCapaMaxima> prestacaoContaCapaMaximaApi,
            ApiBase<PrecoCestaMaxima> precoCestaMaximaApi,
            ApiBase<PrecoCestaItemMaxima> precoCestaItemMaximaApi,
            ApiBase<PrecoPromocaoMaxima> precoPromocaoMaximaApi,
            ApiBase<TipoBonificacaoMaxima> tipoBonificacaoMaximaApi,
            ApiBase<LimiteComboMaxima> limiteComboMaximaApi,
            ApiBase<ConfiguracaoERPMaxima> configuracaoERPApi,
            ApiBase<DescontoCapaMaxima> descontoCapaApi,
            ApiBase<ValidadeProdutoWMSMaxima> validadeProdutoWMSMaximaApi,
            ApiBase<DescontoCategoriaMaxima> descontoCategoriaApi,
            ApiBase<ProdutoCestaMaxima> produtoCestaApi,
            ApiBase<TributosCapaMaxima> trubutosCapaApi,
            ApiBase<TabelaPrecoCestaMaxima> tabelaPrecoCestaApi,
            ApiBase<EmpregadoMaxima> empregadoMaximaApi,
            ApiBase<NotaFiscalStatusEntregaMaxima> notaFiscalStatusEntregaApi
            )
        {
            _apiMaxima = apiMaxima;
            _ramoAtividadeMaximaApi = apiRamoAtividade;
            _atividadeEconomicaMaximaApi = apiAtividadeEconomica;
            _bancoMaximaApi = apiBanco;
            _brindePremioMaximaApi = apiBrindePremio;
            _brindeRestricaoMaximaApi = apiBrindeRestricao;
            _brindeValidacaoMaximaApi = apiBrindeValidacao;
            _contatoMaximaApi = apiContato;
            _contaBancariaMaximaApi = apiContaBancaria;
            _cidadeMaximaApi = cidadeMaxima;
            _tipoOperacaoMaximaApi = tipoOperacaoMaximaApi;
            _clienteMaximaApi = apiCliente;
            _clienteVendedorMaximaApi = apiClienteVendedor;
            _profissionalPorClienteMaximaApi = profissionalPorClienteMaximaApi;
            _cotacaoCapaMaximaApi = apiCotacaoCapa;
            _cotacaoItensMaximaApi = apiCotacaoItens;
            _cotasDeProdutoMaximaApi = apiCotasDeProduto;
            _embalagemMaximaApi = apiEmbalagem;
            _departamentoMaximaApi = apiDepartamento;
            _descontoMaximaApi = apiDesconto;
            _prazoAdicionalMaximaApi = prazoAdicionalMaxima;
            _estoqueMaximaApi = apiEstoque;
            _mensagemMaximaApi = mensagemMaximaApi;
            _erpPrestMaximaApi = apiErpPrest;
            _notaFiscalEletronicaMaximaApi = notaFiscalEletronicaMaximaApi;
            _familiaMaximaApi = apiFamilia;
            _creditoDisponivelPorClienteMaximaApi = creditoDisponivelPorClienteMaximaApi;
            _filialMaximaApi = apiFilial;
            _filialRegiaoMaximaApi = apiFilialRegiao;
            _filialRetiradaEstoqueMaximaApi = apiFilialRetiradaEstoque;
            _fornecedorMaximaApi = apiFornecedor;
            _vendedorFornecedorApi = vendedorFornecedorApi;
            _cfopMaxima = cfopMaxima;
            _pedidosProcessadosWMSMaximaMaximaApi = apiPedidosProcessadosWMS;
            _produtoMaximaApi = apiProduto;
            _produtoAgregadoMaximaApi = produtoAgregadoMaximaApi;
            _produtoCampanhaDescontoMaximaApi = apiProdutoCampanhaDesconto;
            _produtoSimilarMaximaApi = produtoSimilarMaximaApi;
            _marcaMaximaApi = apiMarca;
            _mixProdutoClienteMaximaApi = apiMixProdutoCliente;
            _categoriaMaximaApi = categoriaMaximaApi;
            _subCategoriaMaximaApi = subCategoriaMaximaApi;
            _produtosPorFilialMaximaApi = apiProdutosPorFilial;
            _redeMaximaApi = redeMaximaApi;
            _rotaClienteMaximaApi = rotaClienteMaximaApi;
            _referenciaComercialClienteMaxima = referenciaComercialClienteMaxima;
            _statusClienteMaximaApi = apiStatusCliente;
            _transportadoraMaximaApi = transportadoraMaxima;
            _vendedorMaximaApi = apiVendedor;
            _visitaVendedorMaximaApi = apiVisitaVendedor;
            _comissaoProfissionalMaximaApi = comissaoProfissionalMaximaApi;
            _pedidoMaximaApi = pedidoMaximaApi;
            _pracaMaximaApi = pracaMaximaApi;
            _previsaoRecebimentoMercadoriaMaximaApi = previsaoRecebimentoMercadoriaMaximaApi;
            _regiaoMaximaApi = regiaoMaximaApi;
            _regiaoClienteMaximaApi = regiaoClienteMaximaApi;
            _planoPagamentoApi = planoPagamentoApi;
            _planoPagamentoPorClienteApi = planoPagamentoPorClienteApi;
            _planoPagamentoPorRegiaoApi = planoPagamentoPorRegiaoApi;
            _planoPagamentoPorFilialApi = planoPagamentoPorFilialApi;
            _planoPagamentoPorProdutoApi = planoPagamentoPorProdutoApi;
            _concorrenteMaximaApi = concorrenteApi;
            _cobrancaMaximaApi = cobrancaApi;
            _cobrancaClienteMaximaApi = cobrancaClienteApi;
            _cobrancaPlanoPagamentoMaximaApi = cobrancaPlanoPagamentoApi;
            _tabelaDePrecoMaxima = tabelaPrecoApi;
            _tabelasDePrecoPorClienteMaximaApi = tabelasDePrecoPorClienteMaximaApi;
            _politicaDeAcrescimoPorClienteMaximaApi = politicaDeAcrescimoPorClienteMaximaApi;
            _carregamentoMaximaApi = carregamentoApi;
            _romaneioMaximaApi = romaneioMaximaApi;
            _veiculoMaximaApi = veiculoApi;
            _enderecoClienteMaximaApi = enderecoClienteMaximaApi;
            _historicoPedidoFaltaApi = historicoPedidoFaltaApi;
            _historicoPedidoCorteMaximaApi = historicoPedidoCorteMaximaApi;
            _setorMaximaApi = setorMaximaApi;
            _categoriaDespesaMaximaApi = categoriaDespesaMaximaApi;
            _prestacaoContaItemMaximaApi = prestacaoContaItemMaximaApi;
            _metaMaximaApi = metaMaximaApi;
            _metaVendedorMaximaApi = metaVendedorMaximaApi;
            _empregadoMaximaApi = empregadoMaximaApi;
            _notaSaidaMaximaApi = notaSaidaMaximaApi;
            _notaSaidaItensMaximaApi = notaSaidaItensMaximaApi;
            _estornoComissaoMaximaApi = estornoComissaoMaximaApi;
            _faixaComissaoVendedorMaximaApi = faixaComissaoVendedorMaximaApi;
            _supervisorMaximaApi = supervisorMaximaApi;
            _gerenteMaximaApi = gerenteMaximaApi;
            _movimentoVendaPendenteWMSApi = movimentoVendaPendenteWMSApi;
            _loteMaximaApi = loteMaximaApi;
            _descontoItemMaxima = descontoItemMaxima;
            _descontoRestricaoMaxima = descontoRestricaoMaxima;
            _estadoMaximaApi = apiEstado;
            _localizacaoClienteMaxima = localizacaoClienteMaxima;
            _tributosItemMaximaApi = apiTributosItem;
            _estoqueCestaMaximaApi = estoqueCestaMaximaApi;
            _secaoMaximaApi = secaoMaximaApi;
            _restricaoVendaMaximaApi = restricaoVendaMaximaApi;
            _brindeMaximaApi = brindeMaximaApi;
            _comissaoRegiaoApi = comissaoRegiaoApi;
            _comissaoVendedorApi = comissaVendedorApi;
            _saldoContaCorrenteVendedorMaximaApi = saldoContaCorrenteVendedorMaximaApi;
            _visitaMaximaApi = visitaMaximaApi;
            _motivoVisitaMaximaApi = motivoVisitaMaximaApi;
            _motivoNaoCompraMaximaApi = motivoNaoCompraMaximaApi;
            _motivoDevolucaoMaximaApi = motivoDevolucaoMaximaApi;
            _notaFiscalEntradaCapaMaximaApi = notaFiscalEntradaCapaMaximaApi;
            _prestacaoContaCapaMaximaApi = prestacaoContaCapaMaximaApi;
            _precoCestaMaximaApi = precoCestaMaximaApi;
            _precoCestaItemMaximaApi = precoCestaItemMaximaApi;
            _precoPromocaoMaximaApi = precoPromocaoMaximaApi;
            _tipoBonificacaoMaximaApi = tipoBonificacaoMaximaApi;
            _limiteComboMaxima = limiteComboMaximaApi;
            _configuracaoERPApi = configuracaoERPApi;
            _descontoCapaApi = descontoCapaApi;
            _validadeProdutoWMSMaximaApi = validadeProdutoWMSMaximaApi;
            _descontoCategoriaApi = descontoCategoriaApi;
            _produtoCestaApi = produtoCestaApi;
            _tributosCapaApi = tributosCapaApi;
            _tabelaPrecoCestaApi = tabelaPrecoCestaApi;
            _notaFiscalStatusEntregaApi = notaFiscalStatusEntregaApi;
        }
        /// <summary>
        /// Realiza o login com o usuário fornecido pela Máxima
        /// </summary>
        /// <param name="login">Usuário da Máxima</param>
        /// <param name="senha">Senha da Máxima</param>
        /// <returns></returns>
        public bool RealizarLogin(string login, string senha)
        {
            _apiMaxima.Usuario = login;
            _apiMaxima.Senha = senha;
            return _apiMaxima.Token != null;
        }

        /// <summary>
        /// Busca todos os pedidos que ainda não foram importados.
        /// </summary>
        /// <returns>Retorna uma lista de pedidos maxima.</returns>
        public async Task<List<PedidoMaxima>> GetPedidoNaoImportados()
        {
            return await _apiMaxima.GetPedidosNaoImportados();
        }
    }
}

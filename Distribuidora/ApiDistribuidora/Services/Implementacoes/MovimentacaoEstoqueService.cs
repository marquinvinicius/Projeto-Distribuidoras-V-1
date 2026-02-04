using ApiDistribuidora.DTOs.Filters;
using ApiDistribuidora.Estrategy.Interface;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using BackDistribuidora.Entidades;
using BackDistribuidora.Entidades.Enums;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class MovimentacaoEstoqueService : IMovimentacaoEstoqueService
    {
        private readonly ILogger<MovimentacaoEstoqueService> _logger;
        private readonly IMovimentacaoEstoqueRepository _movEstoque;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IUnitOfWork _uof;
        private readonly Dictionary<TipoTransacao, IMovimentacaoEstrategy> _strategies;

        public MovimentacaoEstoqueService(ILogger<MovimentacaoEstoqueService> logger, IMovimentacaoEstoqueRepository movEstoque,
            IProdutoRepository produtoRepository, IUnitOfWork uof, IEnumerable<IMovimentacaoEstrategy> strategia)
        {
            _logger = logger;
            _movEstoque = movEstoque;
            _produtoRepository = produtoRepository;
            _uof = uof;
            _strategies = strategia.ToDictionary(s => s.Tipo);
        }

        public async Task ProcessarMovimentacao(int produtoId, EstoqueProdutoValue quantidade,
            CustoProdutoValue custo, TipoTransacao tipoTransacao, TipoUnidade tipoUnidade)
        {
            _logger.LogInformation("Iniciando a adição de movimentação de estoque para o produto ID: {ProdutoId}", produtoId);
            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(p => p.Id == produtoId);
                if (produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com ID: {produtoId} não encontrado.");
                    throw new ArgumentException("Produto inválido.");
                }
                if (!_strategies.ContainsKey(tipoTransacao))
                {
                    throw new ArgumentException("Estrategia não encontrada");
                }
                produtoExiste.AjustarEstoque(quantidade.Valor);
                produtoExiste.AtualizarPrecoCusto(custo);

                var strategy = _strategies[tipoTransacao];

                await strategy.ExecutarMovimentacao(produtoExiste, quantidade.Valor, tipoUnidade, custo);
                await _produtoRepository.UpdateAsync(produtoExiste);
                await _uof.CommitAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao movimentar o produto com Id = {produtoId}");
                throw;
            }
        }

        public async Task<IEnumerable<MovimentacaoEstoque>> ObterTodasMovimentacoesAsync()
        {
            _logger.LogInformation("Obtendo todas as movimentações de estoque.");
            try
            {
                var movimentacoes = await _movEstoque.GetAllAsync();
                if (movimentacoes == null || !movimentacoes.Any())
                {
                    _logger.LogWarning("Nenhuma movimentação de estoque encontrada.");
                    return Enumerable.Empty<MovimentacaoEstoque>();
                }
                _logger.LogInformation("Obtenção de todas as movimentações de estoque concluída com sucesso.");
                return movimentacoes;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as movimentações de estoque");
                throw;
            }
        }

        public async Task<MovimentacaoEstoque?> ObterMovimentacaoPorIdAsync(int id)
        {
            _logger.LogInformation("Obtendo movimentação de estoque por ID: {Id}", id);
            try
            {
                var movimentacao = await _movEstoque.GetByIdAsync(m => m.Id == id);
                if (movimentacao == null)
                {
                    _logger.LogWarning($"Movimentação de estoque com ID: {id} não encontrada.");
                    return null;
                }
                _logger.LogInformation("Obtenção da movimentação de estoque por ID concluída com sucesso.");
                return movimentacao;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter a movimentação de estoque pelo ID");
                throw;
            }

        }

        public Task<IEnumerable<MovimentacaoEstoque>> ObterMovimentacoesPorProdutoAsync(int produtoId)
        {
            _logger.LogInformation("Obtendo movimentações de estoque para o produto ID: {ProdutoId}", produtoId);
            try
            {
                var movimentacoes = _movEstoque.ObterPorProdutoIdAsync(produtoId);
                _logger.LogInformation("Obtenção das movimentações de estoque para o produto ID: {ProdutoId} concluída com sucesso.", produtoId);
                return movimentacoes;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter as movimentações de estoque pelo ID do produto");
                throw;
            }
        }

        public async Task<IEnumerable<MovimentacaoEstoque>> ObterMovimentacoesPorFiltroAsync(MovimentacaoFilterInput filterInput)
        {
            _logger.LogInformation("Obtendo movimentações de estoque com filtros aplicados.");

            try
            {
                if (filterInput == null)
                {
                    _logger.LogWarning("Filtro de movimentações de estoque é nulo.");
                    throw new ArgumentNullException(nameof(filterInput), "O filtro não pode ser nulo.");
                }
                var movimentacoes = await _movEstoque.ObterPorFiltroAsync(filterInput);

                return movimentacoes;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao filtrar por datas");
                throw;
            }
        }
    }
}

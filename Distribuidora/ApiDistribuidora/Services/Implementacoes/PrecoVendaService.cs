using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Entidades;
using BackDistribuidora.Factory;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class PrecoVendaService : IPrecoVendaService
    {
        private readonly ILogger<PrecoVendaService> _logger;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uof;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMarcaRepository _marcaRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IPrecoVendaRepository _precoVendaRepository;
        private readonly IPrecoVendaFactory _precoVendaFactory;

        public PrecoVendaService(ILogger<PrecoVendaService> logger, IMapper mapper, IUnitOfWork uof,
            IProdutoRepository produtoRepository, IMarcaRepository marcaRepository,
            ICategoriaRepository categoriaRepository, IPrecoVendaRepository precoVendaRepository,
            IPrecoVendaFactory precoVendaFactory)
        {
            _logger = logger;
            _mapper = mapper;
            _uof = uof;
            _produtoRepository = produtoRepository;
            _marcaRepository = marcaRepository;
            _categoriaRepository = categoriaRepository;
            _precoVendaRepository = precoVendaRepository;
            _precoVendaFactory = precoVendaFactory;
        }

        #region Preço de Venda
        public async Task<IEnumerable<PrecoVendaDTO>> ObterTodosPrecosAsync()
        {
            _logger.LogInformation("Obtendo todos os preços de venda.");
            try
            {
                var precos = await _precoVendaRepository.GetPrecosAtuaisAsync();
                var precosDto = _mapper.Map<IEnumerable<PrecoVendaDTO>>(precos);
                _logger.LogInformation("Preços de venda obtidos com sucesso.");
                return precosDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todos os preços");
                throw;
            }
        }
        public async Task<PrecoVendaDTO> AdicionarPrecoVendaAsync(int produtoId, decimal valorVenda)
        {
            _logger .LogInformation($"Adicionando preço de venda para o produto ID {produtoId}.");
            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(i => i.Id == produtoId);
                if (produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com ID {produtoId} não encontrado ao tentar adicionar preço de venda.");
                    throw new KeyNotFoundException($"Produto com ID {produtoId} não encontrado.");
                }
                if (valorVenda <= produtoExiste.PrecoCusto.Valor)
                {
                    _logger.LogWarning("Tentativa de adicionar preço de venda com valor inválido.");
                    throw new ArgumentException("O valor do preço de venda deve ser maior que zero.");
                }
                var criarPreco = _precoVendaFactory.CriarPrecoVenda(produtoExiste, valorVenda, DateTime.UtcNow, null);

                await _precoVendaRepository.AddAsync(criarPreco);
                await _uof.CommitAsync();
                var precoDto = _mapper.Map<PrecoVendaDTO>(criarPreco);

                _logger.LogInformation($"Preço de venda adicionado com sucesso para o produto ID {produtoId}.");
                return precoDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adicionar o preço de venda");
                throw;
            }

        }

        public async Task<PrecoVendaDTO?> EncerrarPrecoAtualAsync(int produtoId)
        {
            _logger.LogInformation($"Encerrando preço atual para o produto ID {produtoId}.");
            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(i => i.Id == produtoId);
                if (produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com ID {produtoId} não encontrado ao tentar encerrar preço atual.");
                    throw new KeyNotFoundException($"Produto com ID {produtoId} não encontrado.");
                }
                var precoAtual = await _precoVendaRepository.GetByIdAsync(p => p.Id == produtoId);
                if (precoAtual == null)
                {
                    _logger.LogWarning($"Nenhum preço atual encontrado para o produto ID {produtoId} ao tentar encerrar.");
                    return null;
                }
                precoAtual.EncerrarPreco(DateTime.UtcNow);
                
                await _precoVendaRepository.UpdateAsync(precoAtual);
                await _uof.CommitAsync();

                var precoDto = _mapper.Map<PrecoVendaDTO>(precoAtual);
                _logger.LogInformation($"Preço atual encerrado com sucesso para o produto ID {produtoId}.");
                return precoDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao encerrar o preço atual do produto com id {produtoId}");
                throw;
            }
        }

        public async Task<IEnumerable<PrecoVendaDTO>> ObterHistoricoPrecosAsync(int produtoId)
        {
            _logger.LogInformation($"Obtendo histórico de preços para o produto ID {produtoId}.");
            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(p => p.Id == produtoId);
                if(produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com id {produtoId} não encontrado");
                    throw new Exception($"Produto com {produtoId} inexistente");
                }

                var historicoPrecos = await _precoVendaRepository.GetHistoricoPrecosAsync(produtoId);
                var historicoPrecosDto = _mapper.Map<IEnumerable<PrecoVendaDTO>>(historicoPrecos);
                _logger.LogInformation($"Histórico de preços obtido com sucesso para o produto ID {produtoId}.");
                return historicoPrecosDto;
            }
            catch ( Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter o histórico de preços do produto com id {produtoId}");
                throw;
            }
        }

        public async Task<PrecoVendaDTO?> ObterPrecoAtualAsync(int produtoId)
        {
            _logger.LogInformation($"Obtendo preço atual para o produto ID {produtoId}.");
            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(p => p.Id == produtoId);
                if (produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com id {produtoId} não encontrado");
                    throw new Exception($"Produto com {produtoId} inexistente");
                }
                var precoAtual = await _precoVendaRepository.GetPrecoAtualByProdutoIdAsync(produtoId);
                var precoAtualDto = _mapper.Map<PrecoVendaDTO>(precoAtual);
                _logger.LogInformation($"Preço atual obtido com sucesso para o produto ID {produtoId}.");
                return precoAtualDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter o preço do produto com id {produtoId}");
                throw;
            }
        }
        #endregion

        #region Margem de Lucro
        public async Task<IEnumerable<PrecoVendaDTO>> AdcionarMargemGeralAsync(decimal margemLucro)
        {
            _logger.LogInformation("Adicionando o preço geral com margem de lucro");
            try
            {
                var novosPrecos = new List<PrecoVenda>();
                var produto = await _produtoRepository.GetAllAsync();
                if(!produto.Any())
                {
                    throw new ArgumentException("Nenhum produto encontrado para aplicar a margem");
                }
                var precosAtuais = await _precoVendaRepository.GetPrecosAtuaisAsync();
                var precosMap = precosAtuais.ToDictionary(p => p.ProdutoId, p => p);
                foreach (var preco in produto)
                {
                    var novoPrecoVenda = CalcularPrecoComMargem(preco.PrecoCusto.Valor, margemLucro);
                    _logger.LogInformation($"Novo valor de venda calculado para o produto" +
                        $" {preco.NomeProduto.Valor}: {novoPrecoVenda}");
                    if (precosMap.TryGetValue(preco.Id, out var precoAtual))
                    {
                        precoAtual.EncerrarPreco(DateTime.Now);
                    }
                    var novoPreco = _precoVendaFactory.CriarPrecoVenda(preco, novoPrecoVenda, DateTime.Now, null);
                    novosPrecos.Add(novoPreco);
                }
                await _precoVendaRepository.AddRangeAsync(novosPrecos);
                await _uof.CommitAsync();
                var novosPrecosDto = _mapper.Map<IEnumerable<PrecoVendaDTO>>(novosPrecos);
                _logger.LogInformation("Preços adicionados com sucesso de forma geral");
                return novosPrecosDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao aplicar a margem geral para os preços");
                throw;
            }
        }

        public async Task<IEnumerable<PrecoVendaDTO>> AdcionarMargemCategoriaAsync(int categoriaId, decimal margemLucro)
        {
            _logger.LogInformation("Adicionando o preço a categoria");
            try
            {
                var novosPrecos = new List<PrecoVenda>();
                var categoriaExiste = await _categoriaRepository.GetByIdAsync(c => c.Id == categoriaId);
                if(categoriaExiste == null)
                {
                    _logger.LogError("Categoria não encontrada");
                    throw new Exception("Categoria não encontrada");
                }
                var produtos = await _produtoRepository.BuscarPorCategoriaAsync(categoriaId);
                if(!produtos.Any())
                {
                    throw new ArgumentException("Nenhum produto encontrado para aplicar a margem");
                }
                var precosAtuais = await _precoVendaRepository.GetPrecosAtuaisAsync();
                var precosMap = precosAtuais.ToDictionary(p => p.ProdutoId, p => p);
                foreach (var preco in produtos)
                {
                    var novoPrecoVenda = CalcularPrecoComMargem(preco.PrecoCusto.Valor, margemLucro);
                    _logger.LogInformation($"Novo valor de venda calculado para o produto" +
                        $" {preco.NomeProduto.Valor}: {novoPrecoVenda}");
                    if (precosMap.TryGetValue(preco.Id, out var precoAtual))
                    {
                        precoAtual.EncerrarPreco(DateTime.Now);
                    }
                    var novoPreco = _precoVendaFactory.CriarPrecoVenda(preco, novoPrecoVenda, DateTime.Now, null);
                    novosPrecos.Add(novoPreco);
                }
                await _precoVendaRepository.AddRangeAsync(novosPrecos);
                await _uof.CommitAsync();

                var novosPrecosDto = _mapper.Map<IEnumerable<PrecoVendaDTO>>(novosPrecos);
                _logger.LogInformation("Preços adicionados com sucesso na categoria");
                return novosPrecosDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adcionar preço na categoria");
                throw;
            }
        }

        public async Task<PrecoVendaDTO> AdcionarPrecoUnicoPorMargemAsync(int produtoId, decimal margemLucro)
        {
            _logger.LogInformation("Adicionando o preço único por margem de lucro");
            try
            {
                var produto = await _produtoRepository.GetByIdAsync(p => p.Id == produtoId);
                if (produto == null)
                {
                    _logger.LogError("Produto não encontrado");
                    throw new Exception("Produto não encontrado");
                }

                var precosAtuais = await _precoVendaRepository.GetPrecosAtuaisAsync();
                var precoAtual = precosAtuais.FirstOrDefault(p => p.ProdutoId == produtoId);

                if (precoAtual != null)
                {
                    precoAtual.EncerrarPreco(DateTime.Now);
                }
                var novoPrecoVenda = CalcularPrecoComMargem(produto.PrecoCusto.Valor, margemLucro);
                _logger.LogInformation($"Novo valor de venda calculado para o produto" +
                    $" {produto.NomeProduto.Valor}: {novoPrecoVenda}");

                var novoPreco = _precoVendaFactory.CriarPrecoVenda(produto, novoPrecoVenda, DateTime.Now, null);

                await _precoVendaRepository.AddAsync(novoPreco);
                await _uof.CommitAsync();

                var novoPrecoDto = _mapper.Map<PrecoVendaDTO>(novoPreco);
                _logger.LogInformation("Preço único adicionado com sucesso por margem de lucro");
                return novoPrecoDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adcionar preço único por margem de lucro");
                throw;
            }
        }

        public async Task<IEnumerable<PrecoVendaDTO>> AdicionarMargemMarcaAsync(int marcaId, decimal margemLucro)
        {
            _logger.LogInformation("Adicionando o preço a marca");
            try
            {
                var novosPrecos = new List<PrecoVenda>();
                var marcaExiste = await _marcaRepository.GetByIdAsync(m => m.Id == marcaId);
                if (marcaExiste == null)
                {
                    _logger.LogError("Marca não encontrada");
                    throw new Exception("Marca não encontrada");
                }
                var produtos = await _produtoRepository.BuscarPorMarcaAsync(marcaId);
                if (!produtos.Any())
                {
                    throw new ArgumentException("Nenhum produto encontrado para aplicar a margem");
                }
                var precosAtuais = await _precoVendaRepository.GetPrecosAtuaisAsync();
                var precosMap = precosAtuais.ToDictionary(p => p.ProdutoId, p => p);
                foreach (var preco in produtos)
                {
                    var novoPrecoVenda = CalcularPrecoComMargem(preco.PrecoCusto.Valor, margemLucro);
                    _logger.LogInformation($"Novo valor de venda calculado para o produto" +
                        $" {preco.NomeProduto.Valor}: {novoPrecoVenda}");
                    if (precosMap.TryGetValue(preco.Id, out var precoAtual))
                    {
                        precoAtual.EncerrarPreco(DateTime.Now);
                    }
                    var novoPreco = _precoVendaFactory.CriarPrecoVenda(preco, novoPrecoVenda, DateTime.Now, null);
                    novosPrecos.Add(novoPreco);
                }

                await _precoVendaRepository.AddRangeAsync(novosPrecos);
                await _uof.CommitAsync();

                var novosPrecosDto = _mapper.Map<IEnumerable<PrecoVendaDTO>>(novosPrecos);
                _logger.LogInformation("Preços adicionados com sucesso na marca");
                return novosPrecosDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao adcionar preço na marca");
                throw;
            }

        }
        private static decimal CalcularPrecoComMargem (decimal custo, decimal margemLucro)
        {
            if (margemLucro < 0)
            {
                throw new ArgumentException("Margem de lucro deve ser maior que 0");
            }
            if (custo < 0)
            {
                throw new ArgumentException("O custo deve ser maior que 0");
            }
            var margem = custo * (margemLucro / 100);
            return margem + custo;
        }
        #endregion
    }
}

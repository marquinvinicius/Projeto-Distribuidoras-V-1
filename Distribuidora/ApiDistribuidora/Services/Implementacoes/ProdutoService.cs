using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Builder;
using BackDistribuidora.Entidades;
using BackDistribuidora.Factory;
using Distribuidora.Back.Entidades.Object_Values;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class ProdutoService : IProdutoService
    {
        private readonly IUnitOfWork _uof;
        private readonly ProdutoFactory _produtoFactory;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMarcaRepository _marcaRepository;
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ProdutoService> _logger;

        public ProdutoService(IUnitOfWork uof, ProdutoFactory produtoFactory, IProdutoRepository produtoRepository, 
            IMarcaRepository marcaRepository, ICategoriaRepository categoriaRepository, 
            IMapper mapper, ILogger<ProdutoService> logger)
        {
            _uof = uof;
            _produtoFactory = produtoFactory;
            _produtoRepository = produtoRepository;
            _marcaRepository = marcaRepository;
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
            _logger = logger;
        }


        #region Gets

        public async Task<IEnumerable<ProdutoDTO>> ObterTodosProdutosAsync()
        {
            _logger.LogInformation("Iniciando a obtenção de todos os produtos.");
            try
            {
                var produtos = await _produtoRepository.GetAllAsync();
                var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
                _logger.LogInformation("Obtenção de todos os produtos concluída com sucesso.");
                return produtosDTO;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro aobter todos os produtos");
                throw;
            }
        }
        public async Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorNomeAsync(string nome)
        {
            _logger.LogInformation("Iniciando a busca de produtos por nome: {Nome}", nome);

            try
            {
                var produtos = await _produtoRepository.BuscarPorNomeAsync(nome);
                var produtosDTO = _mapper.Map<IEnumerable<ProdutoDTO>>(produtos);
                _logger.LogInformation("Busca de produtos por nome concluída com sucesso.");
                return produtosDTO;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar o produto por nome");
                throw;
            }
        }

        public async Task<ProdutoDTO?> ObterProdutoPorIdAsync(int id)
        {
            _logger.LogInformation("Iniciando a obtenção do produto por ID: {Id}", id);
            try
            {
                var produto =  await _produtoRepository.GetByIdAsync(p => p.Id == id);
                var produtoDTO = _mapper.Map<ProdutoDTO>(produto);
                _logger.LogInformation("Obtenção do produto por ID concluída com sucesso.");
                return produtoDTO;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter o preço pelo ID");
                throw;
            }
        }

        public async Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorMarcaAsync(int marcaId)
        {
            _logger.LogInformation("Iniciando a busca por marca");
            try
            {
                var produto = await _produtoRepository.BuscarPorMarcaAsync(marcaId);
                var produtoDto = _mapper.Map<IEnumerable<ProdutoDTO>>(produto);

                _logger.LogInformation("Sucesso ao obter os produtos por marca");

                return produtoDto;
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro no servidor para concluir a ação");
                throw;
            }
        }

        public async Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorCategoriaAsync(int categoriaId)
        {
            _logger.LogInformation("Iniciando a busca por categoria");
            try
            {
                var produto = await _produtoRepository.BuscarPorCategoriaAsync(categoriaId);
                var dto = _mapper.Map<IEnumerable<ProdutoDTO>>(produto);

                _logger.LogInformation("Sucesso ao obter os produtos por categoria");
                return dto;
            }
            catch (Exception ex)
            {
                _logger.LogError("Erro do servidor ao obter os produtos por categoria");
                throw;
            }
        }


        #endregion

        #region Post
        public async Task<ProdutoDTO> CriarProdutoAsync(ProdutoInputDTO produtoInputDTO)
        {
            _logger.LogInformation("Iniciando a criação de um novo produto.");

            try
            {
                var categoria = await  _categoriaRepository.GetByIdAsync(c => c.Id == produtoInputDTO.CategoriaId);

                var marca = await _marcaRepository.GetByIdAsync(m => m.Id == produtoInputDTO.MarcaId);

                if (marca == null)
                {
                    _logger.LogWarning($"Categoria com ID: {produtoInputDTO.CategoriaId} não encontrada.");
                    throw new ArgumentException("Categoria inválida.");
                }
                if (categoria == null)
                {
                    _logger.LogWarning($"Marca com ID: {produtoInputDTO.MarcaId} não encontrada.");
                }
                var produtoExiste = await _produtoRepository.BuscarPorNomeAsync(produtoInputDTO.Nome);

                if (produtoExiste.Any())
                {
                    _logger.LogWarning($"Produto com nome: {produtoInputDTO.Nome} já existe.");
                    throw new ArgumentException("Produto com esse nome já existe.");
                }
                var novoProduto = new ProdutoBuilder()
                    .ComNome(new NomeProdutoValue(produtoInputDTO.Nome))
                    .ComQuantidadeFardo(new QuantidadeFardoValue(produtoInputDTO.QuantidadeFardo))
                    .ComPrecoCusto(new CustoProdutoValue(produtoInputDTO.PrecoCusto))
                    .ComMarcaId(marca.Id)
                    .ComCategoriaId(categoria.Id)
                    .Criar();
                await _produtoRepository.AddAsync(novoProduto);
                await _uof.CommitAsync();

                _logger.LogInformation("Criação do novo produto concluída com sucesso.");
                return _mapper.Map<ProdutoDTO>(novoProduto);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao cadastrar produto");
                throw;
            }
        }

        public async Task<IEnumerable<ProdutoDTO>> CriarListaProdutosAsync(IEnumerable<ProdutoInputDTO> produtosInputDTO)
        {
            _logger.LogInformation("Iniciando a criação de uma lista de produtos.");
            var produtosCriados = new List<Produto>();
            try
            {
                _logger.LogInformation("Iniciando a criação de uma lista de produtos.");

                var categoriaIds = produtosInputDTO.Select(p => p.CategoriaId).Distinct();
                var marcaIds = produtosInputDTO.Select(p => p.MarcaId).Distinct();

                var categoriasValidas = await _categoriaRepository.GetAllAsync();
                var marcasValidas = await _marcaRepository.GetAllAsync();

                foreach (var input in produtosInputDTO)
                {
                    var categoria = categoriasValidas.FirstOrDefault(c => c.Id == input.CategoriaId);
                    var marca = marcasValidas.FirstOrDefault(m => m.Id == input.MarcaId);

                    if (categoria == null || marca == null)
                    {
                        _logger.LogWarning($"Categoria {input.CategoriaId} ou Marca {input.MarcaId} não encontrada.");
                        continue;
                    }

                    var novoProduto = new ProdutoBuilder()
                        .ComNome(new NomeProdutoValue(input.Nome))
                        .ComQuantidadeFardo(new QuantidadeFardoValue(input.QuantidadeFardo))
                        .ComPrecoCusto(new CustoProdutoValue(input.PrecoCusto))
                        .ComMarcaId(marca.Id)
                        .ComCategoriaId(categoria.Id)
                        .Criar();

                    produtosCriados.Add(novoProduto);
                }

                await _produtoRepository.AddRangeAsync(produtosCriados);
                await _uof.CommitAsync();

                return _mapper.Map<IEnumerable<ProdutoDTO>>(produtosCriados);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao cadastrar lista de produtos");
                throw;
            }
        }
        #endregion

        #region Put
        public async Task<ProdutoDTO?> AtualizarProdutoAsync(int id, ProdutoInputDTO produtoInputDTO)
        {
            _logger.LogInformation("Iniciando a atualização do produto com ID: {Id}", id);

            try
            {
                var produtoExistente =  await _produtoRepository.GetByIdAsync(p => p.Id == id);
                if (produtoExistente == null)
                {
                    _logger.LogWarning($"Produto com ID: {id} não encontrado.");
                    return null;
                }
                var categoria = await _categoriaRepository.GetByIdAsync(c => c.Id == produtoInputDTO.CategoriaId);
                if (categoria == null)
                {
                    _logger.LogWarning($"Categoria com ID: {produtoInputDTO.CategoriaId} não encontrada.");
                    throw new ArgumentException("Categoria inválida.");
                }
                var marca = await _marcaRepository.GetByIdAsync(m => m.Id == produtoInputDTO.MarcaId);
                if (marca == null)
                {
                    _logger.LogWarning($"Marca com ID: {produtoInputDTO.MarcaId} não encontrada.");
                    throw new ArgumentException("Marca inválida.");
                }
                _produtoFactory.AtualizarProduto(produtoExistente,
                    new NomeProdutoValue(produtoInputDTO.Nome),
                    new QuantidadeFardoValue(produtoInputDTO.QuantidadeFardo),
                    new CustoProdutoValue(produtoInputDTO.PrecoCusto),
                    produtoInputDTO.CategoriaId,
                    produtoInputDTO.MarcaId);

                await _produtoRepository.UpdateAsync(produtoExistente); 
                await _uof.CommitAsync();

                _logger.LogInformation("Atualização do produto com ID: {Id} concluída com sucesso.", id);
                return _mapper.Map<ProdutoDTO>(produtoExistente);

            }
            catch (ArgumentException ex)
            {
                _logger.LogWarning(ex, $"Erro de validação ao atualizar o produto {produtoInputDTO.Nome}");
                throw;
            }

            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar o produto {produtoInputDTO.Nome}");
                throw;
            }
        }

        #endregion

        #region Delete
        public async Task<bool> DeletarProdutoAsync(int id)
        {
            _logger.LogInformation("Iniciando a exclusão do produto com ID: {Id}", id);

            try
            {
                var produtoExiste = await _produtoRepository.GetByIdAsync(p => p.Id == id);
                if (produtoExiste == null)
                {
                    _logger.LogWarning($"Produto com ID: {id} não encontrado.");
                    return false;
                }
                await _produtoRepository.DeleteAsync(produtoExiste);
                await _uof.CommitAsync();
                _logger.LogInformation("Exclusão do produto com ID: {Id} concluída com sucesso.", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar produto com ID: {id}.");
                throw;
            }

        }
        #endregion
    }
}

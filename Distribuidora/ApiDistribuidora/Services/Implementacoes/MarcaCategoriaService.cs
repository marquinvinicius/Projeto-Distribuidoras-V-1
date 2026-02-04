using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class MarcaCategoriaService : IMarcaCategoriaService
    {
        private readonly ILogger<MarcaCategoria> _logger;
        private readonly IUnitOfWork _uof;
        private readonly IMarcaCategoriaRepository _repository;
        private readonly IMapper _mapper;

        public MarcaCategoriaService(ILogger<MarcaCategoria> logger, IUnitOfWork uof,
            IMarcaCategoriaRepository repository, IMapper mapper)
        {
            _logger = logger;
            _uof = uof;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoriaDTO>> ObterCategoriaPorMarcaAsync(int marcaId)
        {
            _logger.LogInformation("Começando a obter todas as categorias por marca");
            try
            {
                var map = await _repository.GetByMarcaAsync(marcaId);

                var categorias = map.Select(m => m.Categoria).ToList();

                var categoriasDto = _mapper.Map<IEnumerable<CategoriaDTO>>(categorias); 

                return categoriasDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as categorias por marca");
                throw;
            }
        }

        public async Task<bool> VincularMarcaCategoriaAsync(int marcaId, int categoriaId)
        {
            _logger.LogInformation("Começando a vincular marca e categoria");
            try
            {
                var vinculo = await _repository.GetAsync(marcaId, categoriaId);
                if (vinculo != null)
                {
                    _logger.LogWarning("Vínculo já existe entre marca e categoria");
                    throw new InvalidOperationException("Vínculo já existe entre marca e categoria");
                }
                var vinculoNovo = new MarcaCategoria
                {
                    MarcaId = marcaId,
                    CategoriaId = categoriaId
                };

                await _repository.AddAsync(vinculoNovo);
                await _uof.CommitAsync();

                _logger.LogInformation("Vínculo entre marca e categoria criado com sucesso");
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao vincular marca e categoria");
                throw;
            }
        }

        public async Task<bool> DesvincularMarcaCategoriaAsync(int marcaId, int categoriaId)
        {
            _logger.LogInformation("Começando a desvincular marca e categoria");
            try
            {
                var vinculo = await _repository.GetAsync(marcaId, categoriaId);
                if (vinculo == null)
                {
                    _logger.LogWarning("Vínculo não encontrado entre marca e categoria");
                    throw new InvalidOperationException("Vínculo não encontrado entre marca e categoria");
                }

                await _repository.DeleteAsync(vinculo);
                await _uof.CommitAsync();

                _logger.LogInformation("Vínculo entre marca e categoria removido com sucesso");
                return true;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao disvincular a marca {marcaId} e a categoria {categoriaId}");
                throw;
            }
        }

    }
}

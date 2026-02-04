using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ILogger<CategoriaService> _logger;
        private readonly IUnitOfWork _uof;  
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IMapper _mapper;

        public CategoriaService(ILogger<CategoriaService> logger, IUnitOfWork uof,
            ICategoriaRepository categoriaRepository, IMapper mapper)
        {
            _logger = logger;
            _uof = uof;
            _categoriaRepository = categoriaRepository;
            _mapper = mapper;
        }

        #region Gets
        public async Task<IEnumerable<CategoriaDTO>> ObterTodasCategoriasAsync()
        {
            _logger.LogInformation("Iniciando a obtenção de todas as categorias.");
            try
            {
                var categorias =  await _categoriaRepository.GetAllAsync();
                var categoriasDTO = _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
                _logger.LogInformation("Obtenção de todas as categorias concluída com sucesso.");
                return categoriasDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error ao obter todas as categorias");
                throw;
            }
        }

        public async Task<CategoriaDTO?> ObterCategoriaPorIdAsync(int id)
        {
            _logger.LogInformation("Iniciando a obtenção da categoria por ID: {Id}", id);
            try
            {
                var categoria = await _categoriaRepository.GetByIdAsync(c => c.Id == id);
                var categoriaDTO = _mapper.Map<CategoriaDTO>(categoria);

                _logger.LogInformation("Obtenção da categoria por ID concluída com sucesso.");
                return categoriaDTO;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error ao obter a categoria do id {id}");
                throw;
            }
        }
        public async Task<IEnumerable<CategoriaDTO>> ObterCategoriasPorNomeAsync(string nome)
        {
            _logger.LogInformation("Iniciando a busca de categorias por nome: {Nome}", nome);
            try
            {
                var categoria = await _categoriaRepository.GetByNameAsync(nome);
                var categoriaDTO = _mapper.Map<IEnumerable<CategoriaDTO>>(categoria);
                _logger.LogInformation("Busca de categorias por nome concluída com sucesso.");
                return categoriaDTO;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error ao obter a categoria {nome}");
                throw;
            }
        }

        #endregion

        public async Task<CategoriaDTO> CriarCategoriaAsync(CategoriaInputDTO categoriaInputDTO)
        {
            _logger.LogInformation("Iniciando a criação de uma nova categoria.");
            try
            {
                var categoria = _mapper.Map<Categoria>(categoriaInputDTO);
                await _categoriaRepository.AddAsync(categoria);
                await _uof.CommitAsync();
                _logger.LogInformation("Criação da nova categoria concluída com sucesso.");
                return _mapper.Map<CategoriaDTO>(categoria);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar a categoria");
                throw;
            }
        }

        public async Task<CategoriaDTO?> AtualizarCategoriaAsync(int id, CategoriaInputDTO categoriaInputDTO)
        {
            _logger.LogInformation("Iniciando a atualização da categoria com ID: {Id}", id);
            try
            {
                var categoriaExiste = await _categoriaRepository.GetByIdAsync(c => c.Id == id);
                if (categoriaExiste == null)
                {
                    _logger.LogWarning($"Categoria com ID: {id} não encontrada.");
                    return null;
                }
                categoriaExiste.Nome = categoriaInputDTO.Nome;
                await _categoriaRepository.UpdateAsync(categoriaExiste);
                await _uof.CommitAsync();

                _logger.LogInformation("Atualização da categoria com ID: {Id} concluída com sucesso.", id);
                return _mapper.Map<CategoriaDTO>(categoriaExiste);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar a categoria {categoriaInputDTO.Nome}");
                throw;
            }
        }

        public async Task<bool> DeletarCategoriaAsync(int id)
        {
            _logger.LogInformation("Iniciando a deleção da categoria com ID: {Id}", id);
            try
            {
                var categoriaExiste = await _categoriaRepository.GetByIdAsync(c => c.Id == id);
                if (categoriaExiste == null)
                {
                    _logger.LogWarning($"Categoria com ID: {id} não encontrada.");
                    return false;
                }
                await _categoriaRepository.DeleteAsync(categoriaExiste);
                await _uof.CommitAsync();
                _logger.LogInformation("Deleção da categoria com ID: {Id} concluída com sucesso.", id);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar a categoria {id}");
                throw;
            }
        }
    }
}

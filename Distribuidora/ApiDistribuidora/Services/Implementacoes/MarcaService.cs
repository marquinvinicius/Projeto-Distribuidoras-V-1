using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using ApiDistribuidora.Repositories.Interfaces;
using ApiDistribuidora.Services.Interfaces;
using AutoMapper;
using BackDistribuidora.Entidades;
using System.Net.WebSockets;

namespace ApiDistribuidora.Services.Implementacoes
{
    public class MarcaService : IMarcaService
    {
        private readonly ILogger<MarcaService> _logger;
        private readonly IUnitOfWork _uof;
        private readonly IMarcaRepository _marcaRepository;
        private readonly IMapper _mapper;
        public MarcaService(ILogger<MarcaService> logger, IUnitOfWork uof,
            IMarcaRepository marcaRepository, IMapper mapper)
        {
            _logger = logger;
            _uof = uof;
            _marcaRepository = marcaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MarcaDTO>> ObterTodasMarcasAsync()
        {
            _logger.LogInformation("Iniciando a obtenção de todas as marcas.");
            try
            {
                var marcas =  await _marcaRepository.GetAllAsync();
                if (marcas == null || !marcas.Any())
                {
                    _logger.LogWarning("Nenhuma marca encontrada.");
                    return Enumerable.Empty<MarcaDTO>();
                }
                _logger.LogInformation("Obtenção de todas as marcas concluída com sucesso.");
                var dto = _mapper.Map<IEnumerable<MarcaDTO>>(marcas);
                return dto;  

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao obter todas as marcas");
                throw;
            }
        }

        public async Task<MarcaDTO> ObterMarcaPorIdAsync(int id)
        {
            _logger.LogInformation("Iniciando a obtenção da marca por ID: {Id}", id);
            try
            {
                var marcaExiste = await _marcaRepository.GetByIdAsync(m => m.Id == id);
                if (marcaExiste == null)
                {
                    _logger.LogWarning($"Marca com ID: {id} não existe.");
                    return null;
                }
                _logger.LogInformation("Obtenção da marca por ID concluída com sucesso.");
                var dto = _mapper.Map<MarcaDTO>(marcaExiste);
                return dto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao obter a marca pelo id  = {id}");
                throw;
            }
        }

        public async Task<IEnumerable<MarcaDTO>> ObterMarcasPorNomeAsync(string nome)
        {
            _logger.LogInformation($"Inicando a busca da marca = {nome}");
            try
            {
                var marcaExiste = await _marcaRepository.GetByNameAsync(nome);
                if (marcaExiste == null || !marcaExiste.Any())
                {
                    _logger.LogWarning($"Marca com nome: {nome} não existe.");
                    return Enumerable.Empty<MarcaDTO>();
                }
                _logger.LogInformation("Busca da marca por nome concluída com sucesso.");
                var dto = _mapper.Map<IEnumerable<MarcaDTO>>(marcaExiste);
                return dto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao encontrar a marca {nome}");
                throw;
            }
        }

        public async Task<MarcaDTO> CriarMarcaAsync(MarcaInputDTO marcaInput)
        {
            _logger.LogInformation("Iniciando a criação de uma nova marca.");
            try
            {
                var marcadto = _mapper.Map<Marca>(marcaInput);

                if (marcadto == null)
                {
                    _logger.LogWarning("Dados inválidos para criação de marca.");
                    throw new ArgumentException("Dados inválidos para criação de marca.");
                }

                await _marcaRepository.AddAsync(marcadto);
                await _uof.CommitAsync();

                _logger.LogInformation("Criação da nova marca concluída com sucesso.");

                return _mapper.Map<MarcaDTO>(marcadto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error ao criar marca {marcaInput.Nome}");
                throw;
            }
        }

        public async Task<MarcaDTO> AtualizarMarcaAsync(int id, MarcaInputDTO marca)
        {
            _logger.LogInformation("Iniciando a atualização da marca com ID: {Id}", id);
            try
            {
                var marcaExiste = await _marcaRepository.GetByIdAsync(m => m.Id == id);
                if (marcaExiste == null)
                {
                    _logger.LogWarning($"Marca com ID: {id} não existe.");
                    return null;
                }
                marcaExiste.Nome = marca.Nome;

                await _marcaRepository.UpdateAsync(marcaExiste);
                await _uof.CommitAsync();

                _logger.LogInformation("Atualização da marca com ID: {Id} concluída com sucesso.", id);
                var dto = _mapper.Map<MarcaDTO>(marcaExiste);
                return dto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao atualizar a marca {marca.Nome}");
                throw;
            }
        }

        public async Task<bool> DeletarMarcaAsync(int id)
        {
            _logger.LogInformation("Iniciando a deleção da marca com ID: {Id}", id);
            try
            {
                var marcaExiste = await _marcaRepository.GetByIdAsync(m => m.Id == id);
                if (marcaExiste == null)
                {
                    _logger.LogWarning($"Marca com ID: {id} não existe.");
                    return false;
                }
                await _marcaRepository.DeleteAsync(marcaExiste);

                await _uof.CommitAsync();
                _logger.LogInformation("Deleção da marca com ID: {Id} concluída com sucesso.", id);

                return true;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erro ao deletar marca com o id {id}");
                throw;
            }
        }
    }
}

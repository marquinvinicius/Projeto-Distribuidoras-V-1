using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IMarcaService
    {
        Task<MarcaDTO> CriarMarcaAsync(MarcaInputDTO marca);

        Task<MarcaDTO> ObterMarcaPorIdAsync(int id);

        Task<IEnumerable<MarcaDTO>> ObterTodasMarcasAsync();

        Task<MarcaDTO> AtualizarMarcaAsync(int id, MarcaInputDTO marca);

        Task<bool> DeletarMarcaAsync(int id);

        Task<IEnumerable<MarcaDTO>> ObterMarcasPorNomeAsync(string nome);
    }
}

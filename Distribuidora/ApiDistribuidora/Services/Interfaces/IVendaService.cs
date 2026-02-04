using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IVendaService
    {
        Task<VendaDTO> CriarVendaAsync(VendaInputDTO vendaInputDTO);
        Task<VendaDTO?> ObterVendaPorIdAsync(int id);
        Task<IEnumerable<VendaDTO>> ObterTodasVendasAsync();
        Task<VendaDTO?> AtualizarVendaAsync(int id, VendaInputDTO vendaInputDTO);
        Task<bool> DeletarVendaAsync(int id);
        Task<bool> CancelarVendaAsync(int id);
    }
}

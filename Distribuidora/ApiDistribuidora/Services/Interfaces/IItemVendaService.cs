using ApiDistribuidora.DTOs.Response;
using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IItemVendaService
    {
        Task<ItemVendaDTO> CriarItemVendaAsync(ItemVendaDTO itemVenda);
        Task<ItemVendaDTO?> ObterItemVendaPorIdAsync(int id);
        Task<IEnumerable<ItemVendaDTO>> ObterTodosItensVendaAsync();
        Task<ItemVendaDTO?> AtualizarItemVendaAsync(int id, ItemVenda itemVenda);
        Task<bool> DeletarItemVendaAsync(int id);
    }
}

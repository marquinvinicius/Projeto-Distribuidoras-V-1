using ApiDistribuidora.DTOs.Response;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IPrecoVendaService
    {
        Task<IEnumerable<PrecoVendaDTO>> ObterTodosPrecosAsync();
        Task<IEnumerable<PrecoVendaDTO>> ObterHistoricoPrecosAsync(int produtoId);
        Task<PrecoVendaDTO?> ObterPrecoAtualAsync(int produtoId);
        Task<PrecoVendaDTO> AdicionarPrecoVendaAsync(int produtoId, decimal valorVenda);
        Task<PrecoVendaDTO?> EncerrarPrecoAtualAsync(int produtoId);

        //Margem de Lucro
        Task<IEnumerable<PrecoVendaDTO>> AdcionarMargemGeralAsync(decimal margemLucro);
        Task<PrecoVendaDTO> AdcionarPrecoUnicoPorMargemAsync(int produtoId, decimal margemLucro);
        Task<IEnumerable<PrecoVendaDTO>> AdcionarMargemCategoriaAsync(int categoriaId, decimal margemLucro);
        Task<IEnumerable<PrecoVendaDTO>> AdicionarMargemMarcaAsync(int marcaId, decimal margemLucro);
    }
}

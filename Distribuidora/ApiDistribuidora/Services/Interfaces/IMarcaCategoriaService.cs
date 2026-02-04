using ApiDistribuidora.DTOs.Response;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IMarcaCategoriaService
    {
        Task<IEnumerable<CategoriaDTO>> ObterCategoriaPorMarcaAsync(int marcaId);
        Task<bool> VincularMarcaCategoriaAsync(int marcaId, int categoriaId);
        Task<bool> DesvincularMarcaCategoriaAsync(int marcaId, int categoriaId);
    }
}

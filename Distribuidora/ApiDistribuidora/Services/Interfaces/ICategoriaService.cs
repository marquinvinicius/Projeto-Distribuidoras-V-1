using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface ICategoriaService
    {
        Task<CategoriaDTO> CriarCategoriaAsync(CategoriaInputDTO categoriaInputDTO);
        Task<CategoriaDTO?> ObterCategoriaPorIdAsync(int id);
        Task<IEnumerable<CategoriaDTO>> ObterTodasCategoriasAsync();
        Task<CategoriaDTO?> AtualizarCategoriaAsync(int id, CategoriaInputDTO categoriaInputDTO);
        Task<bool> DeletarCategoriaAsync(int id);
        Task<IEnumerable<CategoriaDTO>> ObterCategoriasPorNomeAsync(string nome);
    }
}

using ApiDistribuidora.DTOs.Input;
using ApiDistribuidora.DTOs.Response;

namespace ApiDistribuidora.Services.Interfaces
{
    public interface IProdutoService 
    {
        Task<ProdutoDTO> CriarProdutoAsync(ProdutoInputDTO produtoInputDTO);
        Task<IEnumerable<ProdutoDTO>> CriarListaProdutosAsync(IEnumerable<ProdutoInputDTO> produtosInputDTO);
        Task<ProdutoDTO?> ObterProdutoPorIdAsync(int id);
        Task<IEnumerable<ProdutoDTO>> ObterTodosProdutosAsync();
        Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorNomeAsync(string nome);
        Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorMarcaAsync(int marcaId);
        Task<IEnumerable<ProdutoDTO>> BuscarProdutoPorCategoriaAsync(int categoriaId);
        Task<ProdutoDTO?> AtualizarProdutoAsync(int id, ProdutoInputDTO produtoInputDTO);
        Task<bool> DeletarProdutoAsync(int id);
    }
}

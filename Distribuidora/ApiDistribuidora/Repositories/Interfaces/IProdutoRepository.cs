using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> BuscarPorNomeAsync(string nome);

        Task<IEnumerable<Produto>> BuscarPorCategoriaAsync(int categoriaId);

        Task<IEnumerable<Produto>> BuscarPorMarcaAsync(int marcaId);

        Task<IEnumerable<Produto>> BuscarPorEstoqueAsync(int quantidadeMinima);

    }
}

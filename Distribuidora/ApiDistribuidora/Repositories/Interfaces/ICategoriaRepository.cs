using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        Task<IEnumerable<Categoria>> GetByNameAsync(string name);
    }
}

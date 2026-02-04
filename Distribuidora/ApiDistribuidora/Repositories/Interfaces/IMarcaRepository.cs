using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IMarcaRepository : IRepository<Marca>
    {
        Task<IEnumerable<Marca>> GetByNameAsync(string nome);
    }
}

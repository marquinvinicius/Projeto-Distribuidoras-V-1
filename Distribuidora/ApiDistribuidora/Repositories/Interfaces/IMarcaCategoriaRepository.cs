using BackDistribuidora.Entidades;

namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IMarcaCategoriaRepository : IRepository<MarcaCategoria>
    {
        Task<MarcaCategoria> GetAsync(int marcaId, int categoriaId);
        Task<IEnumerable<MarcaCategoria>> GetByMarcaAsync(int marcaId);
    }
}

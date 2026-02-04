namespace ApiDistribuidora.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CommitAsync();


    }
}

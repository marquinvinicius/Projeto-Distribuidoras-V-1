using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UnitOfWork> _logger;

        public UnitOfWork(AppDbContext context, ILogger<UnitOfWork> logger)
        {
            _context = context;
            _logger = logger;
        }


        public async Task<int> CommitAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();

            }
            catch (DbUpdateException ex)
            {
                _logger.LogError(ex, "Erro ao salvar as alterações no banco de dados.");
                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

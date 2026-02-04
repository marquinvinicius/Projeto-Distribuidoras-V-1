using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System.Linq.Expressions;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _context.Produtos.
                Include(p => p.Marca).
                Include(p => p.Categoria)
                .AsNoTracking()
                .ToListAsync();
        }

        public override async Task<Produto?> GetByIdAsync(Expression<Func<Produto, bool>> predicate)
        {
            return await _context.Produtos.
                Include(p => p.Marca).
                Include(p => p.Categoria).
                AsNoTracking().
                FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<Produto>> BuscarPorNomeAsync(string nome)
        {
            string normalizedNome = nome.ToLower();
            return await _context.Produtos
                .Where(p => p.NomeProduto.Valor.ToLower().Contains(normalizedNome))
                .Include(p => p.Categoria)
                .Include(p => p.Marca)
                .ToListAsync();
        }
        public async Task<IEnumerable<Produto>> BuscarPorEstoqueAsync(int quantidadeMinima)
        {
            IQueryable<Produto> query = _context.Set<Produto>();
            query = query.Where(p => p.QuantidadeEstoque.Valor >= quantidadeMinima);
            return await query.ToListAsync();
        }
        public async Task<IEnumerable<Produto>> BuscarPorCategoriaAsync(int categoriaId)
        {
            return await BuscarMarcaeCategoriaAsync(null, categoriaId);
        }

        public async Task<IEnumerable<Produto>> BuscarPorMarcaAsync(int marcaId)
        {
            return await BuscarMarcaeCategoriaAsync(marcaId, null);
        }

        private async Task<IEnumerable<Produto>> BuscarMarcaeCategoriaAsync(int? marcaId, int? categoriaId)
        {
            IQueryable<Produto> query = _context.Set<Produto>();
            query = query.Include(m => m.Marca).Include(m => m.Categoria);

            if (marcaId.HasValue) 
                query = query.Where(p => p.MarcaId == marcaId.Value);

            if (categoriaId.HasValue)
                query = query.Where(p => p.CategoriaId == categoriaId.Value);

            return await query.AsNoTracking().ToListAsync();
        }
    }
}

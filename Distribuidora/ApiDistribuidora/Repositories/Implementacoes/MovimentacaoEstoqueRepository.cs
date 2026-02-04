using ApiDistribuidora.DTOs.Filters;
using ApiDistribuidora.Repositories.Interfaces;
using BackDistribuidora.Data;
using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace ApiDistribuidora.Repositories.Implementacoes
{
    public class MovimentacaoEstoqueRepository : Repository<MovimentacaoEstoque>, IMovimentacaoEstoqueRepository
    {
        public MovimentacaoEstoqueRepository(AppDbContext context) : base(context)
        {
        }

        public async Task AdicionarAsync(MovimentacaoEstoque movimentacao)
        {
            await _context.MovimentacoesEstoque.AddAsync(movimentacao); 
        }

        public async Task AdicionarRangeAsync(IEnumerable<MovimentacaoEstoque> movimentoes)
        {
            await _context.MovimentacoesEstoque.AddRangeAsync(movimentoes);
        }

        public async Task<IEnumerable<MovimentacaoEstoque>> ObterPorFiltroAsync(MovimentacaoFilterInput filtro)
        {
            var query = _context.MovimentacoesEstoque.
                Include(m => m.Produto).
                ThenInclude(p => p.Categoria).
                Include(m => m.Produto).
                ThenInclude(p => p.Marca).
                AsQueryable();

            query = AplicarFiltroTemporal(query, filtro);

            var conditions = new List<string>();
            var parameters = new List<object>();


            if (filtro.TipoTransacao.HasValue)
            {
                conditions.Add($"TipoTransacao == @{parameters.Count}");
                parameters.Add(filtro.TipoTransacao.Value);
            }

            if (filtro.ProdutoId.HasValue)
            {
                conditions.Add($"ProdutoId == @{parameters.Count}");
                parameters.Add(filtro.ProdutoId.Value);
            }

            if (filtro.MarcaId.HasValue)
            {
                conditions.Add($"Produto.MarcaId == @{parameters.Count}");
                parameters.Add(filtro.MarcaId.Value);
            }

            if (filtro.CategoriaId.HasValue)
            {
                conditions.Add($"Produto.CategoriaId == @{parameters.Count}");
                parameters.Add(filtro.CategoriaId.Value);
            }

            if (conditions.Any())
            {
                string finalWhereClause = string.Join(" AND ", conditions);
                query = query.Where(finalWhereClause, parameters.ToArray());
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<MovimentacaoEstoque>> ObterPorProdutoIdAsync(int produtoId)
        {
            return await _context.MovimentacoesEstoque
                .Where(m => m.ProdutoId == produtoId)
                .ToListAsync();
        }  
    }
}

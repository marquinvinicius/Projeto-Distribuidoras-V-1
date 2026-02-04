using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemVenda> ItensVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<PrecoVenda> PrecosVenda { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<MarcaCategoria> MarcasCategorias { get;set; }
        public DbSet<MovimentacaoEstoque> MovimentacoesEstoque { get; set; }
    }
}

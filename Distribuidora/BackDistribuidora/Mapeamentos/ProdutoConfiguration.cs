using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Mapeamentos
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> entity)
        {
            entity.HasKey(p => p.Id);

            entity.OwnsOne(p => p.NomeProduto, p =>
            {
                p.Property(p => p.Valor)
                .HasColumnName("Nome")
                .HasMaxLength(200)
                .IsRequired();
            });

            entity.OwnsOne(p => p.QuantidadeFardo, p =>
            {
                p.Property(p => p.Valor)
                .HasColumnName("QuantidadeFardo")
                .IsRequired();
            });
            entity.OwnsOne(p => p.QuantidadeEstoque, p =>
            {
                p.Property(p => p.Valor)
               .HasColumnName("QuantidadeEstoque")
               .HasDefaultValue(0)
               .IsRequired();
            });
            entity.OwnsOne(p => p.PrecoCusto, p =>
            {
                p.Property(p => p.Valor)
                .HasColumnName("PrecoCusto")
                .IsRequired();
            });
            entity.HasOne(p => p.Marca)
                .WithMany(m => m.Produtos)
                .HasForeignKey(p => p.MarcaId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            entity.HasOne(p => p.Categoria)
                .WithMany(m => m.Produtos)
                .HasForeignKey(p => p.CategoriaId)
                .IsRequired();

        }
    }
}

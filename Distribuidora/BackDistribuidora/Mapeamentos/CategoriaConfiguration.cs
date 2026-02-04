using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Mapeamentos
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> entity)
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);

            entity.HasIndex(e => e.Nome)
                .IsUnique();
        }
    }
}

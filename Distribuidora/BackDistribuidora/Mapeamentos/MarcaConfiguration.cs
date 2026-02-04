using BackDistribuidora.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDistribuidora.Mapeamentos
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> entity)
        {
            entity.HasKey(m => m.Id);

            entity.Property(m => m.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(100);

            entity.HasMany(m => m.MarcaCategorias)
                .WithOne(mc => mc.Marca)
                .HasForeignKey(mc => mc.MarcaId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasIndex(m => m.Nome)
                .IsUnique();
        }
    }
}

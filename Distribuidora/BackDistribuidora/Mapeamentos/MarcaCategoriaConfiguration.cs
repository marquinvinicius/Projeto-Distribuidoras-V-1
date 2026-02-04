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
    public class MarcaCategoriaConfiguration : IEntityTypeConfiguration<MarcaCategoria>
    {
        public void Configure(EntityTypeBuilder<MarcaCategoria> entity)
        {
            entity.HasKey(mc => new { mc.MarcaId, mc.CategoriaId });

            entity.HasOne(mc => mc.Marca)
                .WithMany(m => m.MarcaCategorias)
                .HasForeignKey(mc => mc.MarcaId)
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne(mc => mc.Categoria)
                .WithMany(c => c.MarcaCategorias)
                .HasForeignKey(mc => mc.CategoriaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

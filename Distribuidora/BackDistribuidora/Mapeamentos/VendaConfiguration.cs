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
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> entity)
        {
            entity.ToTable("Vendas");
            entity.HasKey(v => v.Id);

            entity.Property(v => v.DataVenda)
                .HasColumnName("DataVenda")
                .IsRequired();

            entity.HasMany(v => v.Itens)
                .WithOne(iv => iv.Venda)
                .HasForeignKey(iv => iv.VendaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            entity.Ignore(v => v.Total);
        }
    }
}

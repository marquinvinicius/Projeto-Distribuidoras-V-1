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
    public class ItemVendaConfiguration : IEntityTypeConfiguration<ItemVenda>
    {
        public void Configure(EntityTypeBuilder<ItemVenda> entity)
        {
            entity.HasKey(iv => iv.Id);

            entity.Property(iv => iv.Quantidade)
                .IsRequired();

            entity.Property(iv => iv.PrecoCusto)
                .HasColumnName("PrecoCusto")
                .IsRequired();
            
            entity.Property(iv => iv.PrecoVenda)
                .HasColumnName("PrecoVenda")
                .IsRequired();

            entity.Ignore(iv => iv.SubTotal);

            entity.HasOne(iv => iv.Venda)
                .WithMany(v => v.Itens)
                .HasForeignKey(iv => iv.VendaId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            entity.HasOne<Produto>()
                .WithMany()
                .HasForeignKey(iv => iv.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

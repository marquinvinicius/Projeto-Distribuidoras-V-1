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
    public class PrecoVendaConfiguration : IEntityTypeConfiguration<PrecoVenda>
    {
        public void Configure(EntityTypeBuilder<PrecoVenda> entity)
        {
            entity.ToTable("PrecosVendas");

            entity.HasKey(pv => pv.Id);

            entity.Property(pv => pv.PrecoUnitario)
                .HasColumnName("ValorUnitario")
                .HasConversion
                (
                    v => Math.Round(v, 2), 
                    v => Math.Round(v, 2)
                )
                .IsRequired();

            entity.HasOne(pv => pv.Produto)
                .WithMany()
                .HasForeignKey(pv => pv.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            entity.Property(pv => pv.PrecoFardo)
                .HasColumnName("ValorFardo")
                .HasConversion
                (
                    v => Math.Round(v, 2),
                    v => Math.Round(v, 2)
                )
                .IsRequired();

            entity.HasIndex(pv => new { pv.ProdutoId, pv.DataFim });

            entity.Property(pv => pv.DataInicio)
                .HasColumnName("DataInicio")
                .IsRequired();

            entity.Property(pv => pv.DataFim)
                .HasColumnName("DataFim")
                .IsRequired(false);

        }
    }
}

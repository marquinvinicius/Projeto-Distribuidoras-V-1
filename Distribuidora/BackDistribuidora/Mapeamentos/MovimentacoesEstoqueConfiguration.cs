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
    public class MovimentacoesEstoqueConfiguration : IEntityTypeConfiguration<MovimentacaoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoEstoque> entity)
        {
            entity.ToTable("MovimentacoesEstoque");
            entity.HasKey(me => me.Id);

            entity.Property(me => me.TipoTransacao)
                .HasColumnName("TipoMovimentacao")
                .IsRequired();

            entity.Property(me => me.TipoUnidade)
                .HasColumnName("TipoUnidade")
                .IsRequired();

            entity.HasOne(me => me.Produto)
                .WithMany(me  => me.MovimentacoesEstoque)
                .HasForeignKey(me => me.ProdutoId)
                .IsRequired();

            entity.Property(me => me.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();
            entity.OwnsOne(p => p.PrecoUnitario, p =>
            {
                p.Property(p => p.Valor)
                .HasColumnName("PrecoCusto")
                .IsRequired();
            });
            entity.Property(me => me.DataMovimentacao)
                .HasColumnName("DataMovimentacao")
                .IsRequired();
        }
    }
}

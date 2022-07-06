using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using ProdutoAgg = SistemaCompra.Domain.ProdutoAggregate;

namespace SistemaCompra.Infra.Data.Produto
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<ProdutoAgg.Produto>
    {
        public void Configure(EntityTypeBuilder<ProdutoAgg.Produto> builder)
        {
            builder.ToTable("Produto");
            builder.OwnsOne(c => c.Preco, b => b.Property("Value").HasColumnName("Preco"));
            builder
                .Property(p => p.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(p => p.Nome)
                .HasColumnType("Nome")
                .HasColumnType("varchar(100)")
                .IsRequired();
            builder
                .Property(p => p.Situacao)
                .HasColumnName("Situacao")
                .HasColumnType("int")
                .IsRequired();
            builder
                .Property(p => p.Categoria)
                .HasColumnName("Categoria")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}

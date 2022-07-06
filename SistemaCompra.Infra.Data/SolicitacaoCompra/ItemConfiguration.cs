using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;
using System.Text;
using ItemAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
	public class ItemConfiguration : IEntityTypeConfiguration<ItemAgg.Item>
	{
		public void Configure(EntityTypeBuilder<ItemAgg.Item> builder)
		{
			builder.ToTable("ItemCompras");
			builder.Property(p=>p.Qtde).HasColumnName("Quantidade").IsRequired();
			builder.OwnsOne(c => c.Subtotal, b => b.Property("Value").HasColumnName("Subtotal"));
		}
	}
}

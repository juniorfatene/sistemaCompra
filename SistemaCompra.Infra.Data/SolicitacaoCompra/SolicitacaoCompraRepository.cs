using System;
using System.Collections.Generic;
using System.Text;
using SolicitacacaoCompraAgg = SistemaCompra.Domain.SolicitacaoCompraAggregate;

namespace SistemaCompra.Infra.Data.SolicitacaoCompra
{
	public class SolicitacaoCompraRepository : SolicitacacaoCompraAgg.ISolicitacaoCompraRepository
	{
		private readonly SistemaCompraContext context;

		public SolicitacaoCompraRepository(SistemaCompraContext context)
		{
			this.context = context;
		}

		public void RegistrarCompra(SolicitacacaoCompraAgg.SolicitacaoCompra entity)
		{
			context.Set<SolicitacacaoCompraAgg.SolicitacaoCompra>().Add(entity);
		}
	}
}

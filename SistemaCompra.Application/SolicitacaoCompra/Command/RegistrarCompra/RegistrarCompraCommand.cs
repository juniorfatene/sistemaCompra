using MediatR;
using SistemaCompra.Domain.Core.Model;
using SistemaCompra.Domain.SolicitacaoCompraAggregate;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
	public class RegistrarCompraCommand : IRequest<bool>
	{
		public UsuarioSolicitante UsuarioSolicitante { get; private set; }
		public NomeFornecedor NomeFornecedor { get; set; }
		public IList<Item> Itens { get; private set; }
		public DateTime Data { get; private set; }
		public Money TotalGeral { get; private set; }
	}
}

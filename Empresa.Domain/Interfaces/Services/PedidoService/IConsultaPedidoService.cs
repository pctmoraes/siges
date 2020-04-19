using Empresa.Domain.Entities;
using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Services.PedidoService
{
    public interface IConsultaPedidoService
    {
        IEnumerable<Pedido> Get();
        Pedido GetId(int id);
    }
}

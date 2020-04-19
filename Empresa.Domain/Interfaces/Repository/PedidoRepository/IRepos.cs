using Empresa.Domain.Entities;
using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Repository.PedidoRepository
{
    public interface IRepos
    {
        IEnumerable<Pedido> Get();
        Pedido GetId(int id);
        void Create(Pedido pedido);
        void UpdatePedido(int id, Pedido pedido);
        void UpdateStatus(int id, string status);
    }
}

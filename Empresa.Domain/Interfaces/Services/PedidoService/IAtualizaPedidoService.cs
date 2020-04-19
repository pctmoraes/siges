using Empresa.Domain.Entities;

namespace Empresa.Domain.Interfaces.Services.PedidoService
{
    public interface IAtualizaPedidoService
    {
        void UpdatePedido(int id, Pedido pedido);
    }
}

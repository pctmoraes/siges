using Empresa.Domain.Entities;

namespace Empresa.Domain.Interfaces.Services.PedidoService
{
    public interface IAdicionaPedidoService
    {
        void Create(Pedido pedido);
    }
}

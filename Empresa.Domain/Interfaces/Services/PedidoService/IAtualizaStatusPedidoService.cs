
namespace Empresa.Domain.Interfaces.Services.PedidoService
{
    public interface IAtualizaStatusPedidoService
    {
        void UpdateStatus(int id, string status);
    }
}

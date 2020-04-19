
namespace Empresa.Domain.Interfaces.Services.ItemService
{
    public interface IVerficaEstoqueItemService
    {
        bool VerificaItemEmEstoque(int id, int quantidade);
    }
}

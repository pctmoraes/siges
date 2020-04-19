using Empresa.Domain.Entities.ItemEntity;

namespace Empresa.Domain.Interfaces.Services.ItemService
{
    public interface IAdicionaItemService
    {
        void Create(ItemViewModel item);
    }
}

using Empresa.Domain.Entities.ItemEntity;

namespace Empresa.Domain.Interfaces.Services.ItemService
{
    public interface IAtualizaItemService
    {
        void Update(int id, ItemViewModel item);
    }
}

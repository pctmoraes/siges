using Empresa.Domain.Entities;
using Empresa.Domain.Entities.ItemEntity;
using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Repository.ItemRepository
{
    public interface IReposit
    {
        IEnumerable<Item> Get();
        Item GetId(int id);
        void Create(ItemViewModel item);
        void Update(int id, ItemViewModel item);
        void UpdateQuantidadeItem(int id, int quantidade);
        void Delete(int id);
        bool VerificaItemEmEstoque(int id, int quantidade);
    }
}

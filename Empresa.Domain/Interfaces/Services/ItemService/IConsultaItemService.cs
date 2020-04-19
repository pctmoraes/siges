using Empresa.Domain.Entities;
using System.Collections.Generic;

namespace Empresa.Domain.Interfaces.Services.ItemService
{
    public interface IConsultaItemService
    {
        IEnumerable<Item> Get();
        Item GetId(int id);
    }
}

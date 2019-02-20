using System.Collections.Generic;

namespace DateTimeDemo.Models
{
    public interface IItemRepository
    {
        Item Create(Item item);
        List<Item> ReadAll();
        Item ReadById(int id);
        void Update(int id, Item newItemInfo);
        void Delete(int id);
    }
}
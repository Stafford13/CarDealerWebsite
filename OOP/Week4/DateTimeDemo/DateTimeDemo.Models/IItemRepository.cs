using System.Collections.Generic;

namespace DateTimeDemo.Models
{
    public interface IItemRepository
    {
        Item Create(Item item);
        List<Item> ReadAll();
        Item ReadById(int id);
        List<Item> ReadByCharacterId(int characterId);
        void Update(int id, Item newItemInfo);
        void Delete(int id);
    }
}
using System.Collections.Generic;
using DateTimeDemo.Models;

namespace DateTimeDemo.Services
{
    public interface ICharacterService
    {
        void BuyItem(int characterId, int itemId);
        Character CreateCharacter(Character character);
        void DeleteCharacter(int id);
        List<Character> ReadAllCharacters();
        Character ReadByCharacterId(int characterId);
        List<Item> RetrieveAvailableItems();
        void SellItem(int characterId, int itemId, decimal amount);
        void UpdateCharacter(Character character);
    }
}
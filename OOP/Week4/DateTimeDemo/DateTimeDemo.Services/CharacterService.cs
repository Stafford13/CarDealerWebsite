using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.Services
{
    public class CharacterService : ICharacterService
    {
        private ICharacterRepository _characterRepository;
        private IItemRepository _itemRepository;

        public CharacterService(ICharacterRepository characterRepository, IItemRepository itemRepository)
        {
            _characterRepository = characterRepository;
            _itemRepository = itemRepository;
        }
        // ADD CRUD Functionality for service
        public Character CreateCharacter(Character character)
        {
            // RULES:
                // 1.) Must have a name
                // 2.) Character can not start with more than 100 health
            return _characterRepository.Create(character);
        }

        public List<Character> ReadAllCharacters()
        {
            return _characterRepository.ReadAll();
        }

        public Character ReadByCharacterId(int characterId)
        {
            Character character = _characterRepository.ReadById(characterId);
            character.Items = _itemRepository.ReadByCharacterId(characterId);
            return character;
        }

        public void UpdateCharacter(Character character)
        {
            _characterRepository.Update(character.Id, character);
        }

        public void DeleteCharacter(int id)
        {
            _characterRepository.Delete(id);
        }

        public List<Item> RetrieveAvailableItems()
        {
            var query = from item in _itemRepository.ReadAll()
                where item.CharacterId.HasValue == false
                select item;
            if (!query.Any()) throw new NoItemAvailableException("No items available");
            return query.ToList();

        }

        public void BuyItem(int characterId, int itemId)
        {
            // TODO: Character Buys an item
            // RULES:
                //0) Is the item already owned?
            Item item = _itemRepository.ReadById(itemId);
            Character character = this.ReadByCharacterId(characterId);
            if (item.CharacterId.HasValue) throw new Exception("This item is already owned");
            //1) You must have gold to buy item
            if (character.Gold < item.Cost) throw new Exception("You be broke! Arghh!");
            //2) YOu can carry 3 items
            if (character.Items.Count() >= 3) throw new Exception("You can not buy any more items"); 
            //3) You can only buy 1 item type by character
            if (character.Items.Any(i => i.Name == item.Name)) throw new Exception("You already have this item");


            // if you have reached this point, you may update the item, and character.
            character.Gold -= item.Cost;
            item.CharacterId = character.Id;

            // Must update the Item Repository when a change needs to be stored
            _itemRepository.Update(itemId, item);
            _characterRepository.Update(characterId, character);



        }
        public void SellItem(int characterId, int itemId, decimal amount)
        {
            // TODO: Character Buys an item
            // RULES:
            //0) Is the item already owned?
            Item item = _itemRepository.ReadById(itemId);
            Character character = this.ReadByCharacterId(characterId);

            if (item.CharacterId != characterId) throw new Exception("This item is not owned by you!");
            //1) You must have gold to buy item
            if (amount > item.Cost * 1.5m ) throw new Exception("That be too much");



            // if you have reached this point, you may update the item, and character.
            character.Gold += amount;
            item.CharacterId = null;

            // Must update the Item Repository when a change needs to be stored
            _itemRepository.Update(itemId, item);
            _characterRepository.Update(characterId, character);



        }
        // Add to ListAll Items
        // TODO: Character Sells an Item
    }
}

using System;
using System.Collections.Generic;
using DateTimeDemo.Models;
using DateTimeDemo.Services;

namespace DateTimeDemo
{
    public class CharacterManager
    {
        private IUserIO io;
        private ICharacterService _characterService;

        public CharacterManager(IUserIO io, ICharacterService characterService)
        {
            this.io = io;
            _characterService = characterService;
        }
        public void Run()
        {
            bool keepRunning = true;
            int menuChoice = 0;

            while (keepRunning == true)
            {
                menuChoice = io.GetOptions("1.) Readall\n2.) Create \n3.) Buy Item \n4.) Exit", 1, 4);
                switch (menuChoice)
                {
                    case 1:
                        this.ListAllCharacters();
                        break;
                    case 2:
                        CreateCharacter();
                        break;
                    case 3:
                        ShopItem();
                        break;
                    case 4:
                        keepRunning = false;
                        break;
                    default:
                        break;
                }
                io.PrintMessagerClear("Please press Continue");

            }

            //// Read ALL
            //ListAllCharacters();
            //Console.ReadLine();
            //Console.Clear();

            //// Create

            //CreateCharacter();
            //// Read By Id

            //ReadCharacterById();

            ////Delete Character
            //DeleteCharacter();






        }

        private void ShopItem()
        {

            // WHo are you?
            Character c = _characterService.ReadByCharacterId( io.PromptUserForInt("What is your character's id?"));

            // Oh Hello... character
            io.DisplayCharacter(c);


            // have a look at my wares
            bool keepGoing = true;
            do
            {

                try
                {
                    io.DisplayItems(_characterService.RetrieveAvailableItems());

                    //What would you like to buy?
                    int itemId = io.PromptUserForInt("Select Item");

                    // attempt a sale
                    _characterService.BuyItem(c.Id, itemId);
                    keepGoing = false;
                }
                catch (NoItemAvailableException e)
                {
                    io.Display(e.Message);
                    keepGoing = false;
                }
                catch (Exception e)
                {
                    // you've done something wrong!
                    io.Display(e.Message);
                    if (c.Gold <= 0)
                    {
                        keepGoing = false;
                    }
                }
            } while (keepGoing);

        }

        private void ListAllCharacters()
        {
            io.PrintCharacters(_characterService.ReadAllCharacters());
        }

        private void ReadCharacterById()
        {
            Character characterInfo = _characterService.ReadByCharacterId(io.PromptUserForInt("Enter Id"));


            if (characterInfo != null)
            {
                io.DisplayCharacter(characterInfo);
                // Update Character
                UpdateCharacter(characterInfo);
            }
        }

        private void UpdateCharacter(Character characterInfo)
        {
            string name = io.PromptUser("Please Enter a name");
            characterInfo.Name = name;
            _characterService.UpdateCharacter(characterInfo);
            Console.Clear();
            io.DisplayCharacter(_characterService.ReadByCharacterId(characterInfo.Id));
        }

        private void CreateCharacter()
        {
            Character newCharacter = io.PromptUserForNewCharacter();

            newCharacter = _characterService.CreateCharacter(newCharacter);

            io.DisplayCharacter(_characterService.ReadByCharacterId(newCharacter.Id));
        }

        private void DeleteCharacter()
        {
            int id = io.PromptUserForInt("Enter Id to remove");
            _characterService.DeleteCharacter(id);
            Character deletedInfo = _characterService.ReadByCharacterId(io.PromptUserForInt("Enter Id for character"));
            if (deletedInfo == null)
            {
                Console.WriteLine("No character found");
            }
        }

    }
}

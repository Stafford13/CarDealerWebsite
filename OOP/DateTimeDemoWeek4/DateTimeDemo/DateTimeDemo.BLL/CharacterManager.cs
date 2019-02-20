using System;
using DateTimeDemo.Models;

namespace DateTimeDemo
{
    public class CharacterManager
    {
        private  ICharacterRepository repo;
        private IUserIO io;
        public CharacterManager(IUserIO io, ICharacterRepository repo)
        {
            this.repo = repo;
            this.io = io;
        }
        public void Run()
        {
            bool keepRunning = true;
            int menuChoice = 0;

            while (keepRunning == true)
            {
                menuChoice = io.GetOptions("1.) Readall\n2.) Create 3.) Exit", 1, 3);
                switch (menuChoice)
                {
                    case 1:
                       this.ListAllCharacters();
                        break;
                    case 2:
                        CreateCharacter();
                        break;
                    case 3:
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

        private  void ListAllCharacters()
        {
            io.PrintCharacters(repo.ReadAll());
        }

        private  void ReadCharacterById()
        {
            Character characterInfo = repo.ReadById(io.PromptUserForInt("Enter Id"));
            characterInfo.Name = "Bob";


            if (characterInfo != null)
            {
                io.DisplayCharacter(characterInfo);
                // Update Character
                UpdateCharacter( characterInfo);
            }
        }

        private  void UpdateCharacter( Character characterInfo)
        {
            string name = io.PromptUser("Please Enter a name");
            characterInfo.Name = name;
            repo.Update(characterInfo.Id, characterInfo);
            Console.Clear();
            io.DisplayCharacter(repo.ReadById(characterInfo.Id));
        }

        private  void CreateCharacter()
        {
            Character newCharacter = io.PromptUserForNewCharacter();

            newCharacter = repo.Create(newCharacter);

            io.DisplayCharacter(repo.ReadById(newCharacter.Id));
        }

        private  void DeleteCharacter()
        {
            int id = io.PromptUserForInt("Enter Id to remove");
            repo.Delete(id);
            Character deletedInfo = repo.ReadById(io.PromptUserForInt("Enter Id for character"));
            if (deletedInfo == null)
            {
                Console.WriteLine("No character found");
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Data;
using DateTimeDemo.Models;
using DateTimeDemo.UI;

namespace DateTimeDemo
{
    public class CharacterManager
    {
        public static void Run()
        {
            CharacterRepository repo = new CharacterRepository();
            // Read ALL
            ListAllCharacters(repo);
            Console.ReadLine();
            Console.Clear();

            // Read By Id
            ReadCharacterById(repo);



            // Create

            CreateCharacter(repo);


            //Delete Character
            DeleteCharacter(repo);

        }

        private static void ListAllCharacters(CharacterRepository repo)
        {
            UserIO.PrintCharacters(repo.ReadAll());
        }

        private static void ReadCharacterById(CharacterRepository repo)
        {
            Character characterInfo = repo.ReadById(UserIO.PromptUserForInt("Enter Id"));
            if (characterInfo != null)
            {
                UserIO.DisplayCharacter(characterInfo);
                // Update Character
                UpdateCharacter(repo, characterInfo);
            }
        }

        private static void UpdateCharacter(CharacterRepository repo, Character characterInfo)
        {
            string name = UserIO.PromptUser("Please Enter a name");
            characterInfo.Name = name;
            repo.Update(characterInfo.Id, characterInfo);
            Console.Clear();
            UserIO.DisplayCharacter(repo.ReadById(characterInfo.Id));
        }

        private static void CreateCharacter(CharacterRepository repo)
        {
            Character newCharacter = UserIO.PromptUserForNewCharacter();

            newCharacter = repo.Create(newCharacter);

            UserIO.DisplayCharacter(repo.ReadById(newCharacter.Id));
        }

        private static void DeleteCharacter(CharacterRepository repo)
        {
            int id = UserIO.PromptUserForInt("Enter Id to remove");
            repo.Delete(id);
            Character deletedInfo = repo.ReadById(UserIO.PromptUserForInt("Enter Id for character"));
            if (deletedInfo == null)
            {
                Console.WriteLine("No character found");
            }
        }

    }
}

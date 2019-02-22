using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.UI
{
    public class UserIO
    {
        public static int PromptUserForInt(string message)
        {
            int result;
            int.TryParse(PromptUser(message), out result);
            return result;
        }

        public static Character PromptUserForNewCharacter()
        {
            string name = PromptUser("What is your Character's name?");
            int health = int.Parse(PromptUser("What is your Character's max health?")); ;
            double startingGold = double.Parse(PromptUser("What is your Character's max health?"));
            Character result = new Character();
            result.Gold = startingGold;
            result.MaxHealth = health;
            result.CurrentHealth = result.MaxHealth;
            result.Name = name;
            return result;
        }

        private static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintCharacters(List<Character> characterList)
        {
            foreach (Character character in characterList)
            {
                DisplayCharacter(character);
            }
        }

        public static void DisplayCharacter(Character character)
        {
            TimeSpan age = DateTime.Now - character.CreateDate;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Character Name: {0}", character.Id);
            Console.WriteLine("Character Name: {0}", character.Name);
            Console.WriteLine("\tCharacter Health: {0}/{1}"
                , character.CurrentHealth, character.MaxHealth);
            Console.WriteLine("\tCharacter Gold: {0}", character.Gold.ToString("###.##"));
            Console.WriteLine("\tCharacter Age (days): {0}", age.TotalDays.ToString("F"));
            Console.WriteLine("-----------------------------");
        }
    }
}

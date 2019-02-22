using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.UI
{
    public class UserIO : IUserIO
    {
        public  int PromptUserForInt(string message)
        {
            int result;
            int.TryParse(PromptUser(message), out result);
            return result;
        }

        public void PrintMessagerClear(string message)
        {
            ReadString(message);
            Console.Clear();
        }

        public  Character PromptUserForNewCharacter()
        {
            string name = PromptUser("What is your Character's name?");
            int health = int.Parse(PromptUser("What is your Character's max health?")); ;
            double startingGold = double.Parse(PromptUser("How much gold would your character start with?"));
            Character result = new Character();
            result.Gold = startingGold;
            result.MaxHealth = health;
            result.CurrentHealth = result.MaxHealth;
            result.Name = name;
            return result;
        }

        public  string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public  void PrintCharacters(List<Character> characterList)
        {
            foreach (Character character in characterList)
            {
                DisplayCharacter(character);
            }
        }

        public  void DisplayCharacter(Character character)
        {
            TimeSpan age = DateTime.Now - character.CreateDate;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Character Id: {0}", character.Id);
            Console.WriteLine("Character Name: {0}", character.Name);
            Console.WriteLine("\tCharacter Health: {0}/{1}"
                , character.CurrentHealth, character.MaxHealth);
            Console.WriteLine("\tCharacter Gold: {0}", character.Gold.ToString("###.##"));
            Console.WriteLine("\tCharacter Age (days): {0}", age.TotalDays.ToString("F"));
            Console.WriteLine("-----------------------------");
        }

        public string ReadString(string message)
        {
            Display(message);
            return Console.ReadLine();
        }

        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public int ReadInt(string message)
        {
            int result = 0;
            while (int.TryParse(ReadString(message), out result) == false)
            {
                Display("You've messed up");
            }
            return result;
        }

        public int GetOptions(string message, int min, int max)
        {
            int result = 0;
            do
            {
                result = ReadInt(message);
                if (result < min || result > max)
                {
                    Display("Invalid entery range");
                }
            } while (result < min || result > max);
            return result;

        }
    }
}

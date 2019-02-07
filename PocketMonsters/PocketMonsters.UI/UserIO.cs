using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.UI
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

        public Pokemon PromptUserForNewPokemon()
        {
            string Name = PromptUser("What is your Pokemon's name?");
            int Number = int.Parse(PromptUser("What is your Pokemon's number? (Your answer must be greater than 151)")); ;
            string Type = PromptUser("What is your Pokemon's type?");
            //string EvolveInto = PromptUser("Does your Pokemon evolve? If so, what does it evolve into? If it doesn't evolve, leave this blank");
            Pokemon result = new Pokemon();
            //result.Type = PokemonType;
            //result.Number = PokemonNumber;
            //result.Name = PokemonName;
            //result.EvolveInto = LeveledUpPokemon;
            return result;
        }

        public  string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public  void PrintPokemon(List<Pokemon> pokemonList)
        {
            foreach (Pokemon pokemon in pokemonList)
            {
                DisplayPokemon(pokemon);
            }
        }

        public  void DisplayPokemon(Pokemon pokemon)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pokemon Name: {0}", pokemon.Name);
            Console.WriteLine("\tPokemon Number: {0}", pokemon.Number);
            Console.WriteLine("\tPokemon Type: {0}", pokemon.Type);
            //Console.WriteLine("\tWhat does your Pokemon elvove into? {0}", pokemon.EvolveInto);
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

using System;
using System.Collections.Generic;
using System.Linq;
using Noun;
using ListData;
using Models;

namespace PokeUser
{
    public class UserIO
    {
        public static int PromptUserForInt(string message)
        {
            int result;
            int.TryParse(PromptUser(message), out result);
            return result;
        }

        public static Pokemon PromptUserForNewPokemon()
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

        public static string PromptUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static void PrintPokemon(List<Pokemon> pokemonList)
        {
            foreach (Pokemon character in pokemonList)
            {
                DisplayPokemon(character);
            }
        }

        public static void DisplayPokemon(Pokemon pokemon)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Pokemon Name: {0}", pokemon.Name);
            Console.WriteLine("\tPokemon Number: {0}", pokemon.Number);
            Console.WriteLine("\tPokemon Type: {0}", pokemon.Type);
            //Console.WriteLine("\tWhat does your Pokemon elvove into? {0}", pokemon.EvolveInto);
            Console.WriteLine("-----------------------------");
        }
    }
}
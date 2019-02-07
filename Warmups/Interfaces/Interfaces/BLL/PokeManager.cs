using System;
using System.Collections.Generic;
using Noun;
using PokeUser;
using ListData;
using Models;

namespace PokeManager
{
    public class PokeManager
    {
        public static void Run()
        {
            PokemonRepository repo = new PokemonRepository();
            // Read ALL
            ListAllPokemon(repo);
            Console.ReadLine();
            Console.Clear();

            // Read By Id
            // ReadPokemonById(repo);


            // Create
            CreatePokemon(repo);


            //Delete Pokemon
            DeletePokemon(repo);

            //PokemonRepository repo = new PokemonRepository();
            //List<Pokemon> pokemons = new List<Pokemon>();
        }

        private static void ListAllPokemon(PokemonRepository repo)
        {
            UserIO.PrintPokemon(repo.ListAll());
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

        private static void UpdatePokemon(PokemonRepository repo, Pokemon pokemonInfo)
        {
            string name = UserIO.PromptUser("Please Enter a name");
            pokemonInfo.Name = name;
            repo.Update(pokemonInfo.Id, pokemonInfo);
            Console.Clear();
            UserIO.DisplayPokemon(repo.ReadById(pokemonInfo.Id));
        }

        private static void CreatePokemon(PokemonRepository repo)
        {
            Pokemon newPokemon = UserIO.PromptUserForNewPokemon();

            newPokemon = repo.Create(newPokemon);

            UserIO.DisplayPokemon(repo.ReadById(newPokemon.Id));
        }

        private static void DeletePokemon(PokemonRepository repo)
        {
            int id = UserIO.PromptUserForInt("Enter Id to remove");
            repo.Delete(id);
            Pokemon deletedInfo = repo.ReadById(UserIO.PromptUserForInt("Enter Id for Pokemon"));
            if (deletedInfo == null)
            {
                Console.WriteLine("No Pokemon found");
            }
        }
    }
    }
}

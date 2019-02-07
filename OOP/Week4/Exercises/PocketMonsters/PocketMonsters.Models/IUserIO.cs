using System.Collections.Generic;
using PocketMonsters.Models;

namespace PocketMonsters.Models
{
    public interface IUserIO
    {
        string ReadString(string message);
        void Display(string message);
        int ReadInt(string message);
        int GetOptions(string message, int min, int max);
        void DisplayPokemon(Pokemon pokemon);
        void PrintPokemon(List<Pokemon> pokemonList);
        string PromptUser(string message);
        int PromptUserForInt(string message);
        void PrintMessagerClear(string message);
        Pokemon PromptUserForNewPokemon();
    }
}

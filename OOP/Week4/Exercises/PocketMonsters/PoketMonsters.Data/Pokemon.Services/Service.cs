using System;
using PocketMonsters.Models;

namespace PocketMonsters.Services
{
    public class PokemonService
    {
        public PokemonService(IPokemonRepository pokemonRepository)
        {
            _pokemonRepository = pokemonRepository;
        }
        // ADD CRUD functionality for Service
        public Pokemon CreatePokemon(Pokemon pokemon)
        {

        }

        // Add method to listAll items
        //TODO: Pokemon starts with move
             //RULES:
                //1. You can only have two moves
                //2. You can only trade one item at a time
                //3. You can only have one move type
        //TODO: Pokemon can trade move for another, after battles
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Data
{
    public class ListPokemonRepository : IPokemonRepository
    {
        protected List<Pokemon> _pokemon;

        public ListPokemonRepository()
        {
            _pokemon = new List<Pokemon>();
        }

        public ListPokemonRepository(List<Pokemon> pokemon)
        {
            _pokemon = pokemon;
        }
        private int nextId()
        {
            int id = 4;
            foreach (Pokemon pokemon in _pokemon)
            {
                if (pokemon.Id > id)
                {
                    id = pokemon.Id;
                }
            }
            id = id + 1;
            return id;
        }

        // CREATE
        public Pokemon Create(Pokemon pokemon)
        {
            pokemon.Id = nextId();
            _pokemon.Add(pokemon);
            return pokemon;
        }

        // READALL
        public List<Pokemon> ReadAll()
        {
            return _pokemon;
        }

        // READBY
        public virtual Pokemon ReadById(int id)
        {

            foreach (Pokemon pokemon in _pokemon)
            {
                if (pokemon.Id == id)
                {
                    return pokemon;
                }
            }
            return null;
        }
        // UPDATE
        public void Update(int id, Pokemon newPokemonInfo)
        {
            // Loop until find the index, and modify way
            for (int i = 0; i < _pokemon.Count; i++)
            {
                if (_pokemon[i].Id != id) continue;
                _pokemon[i] = newPokemonInfo;
                break;
            }
            //int index = _pokemon.FindIndex((Pokemon c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _pokemon[index] = newPokemonInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            _pokemon.RemoveAll((Pokemon pokemonInfo) => pokemonInfo.Id == id);
        }

    }
}

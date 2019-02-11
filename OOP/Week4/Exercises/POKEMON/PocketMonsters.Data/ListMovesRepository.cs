using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Data
{
    public class ListMovesRepository : IMovesRepository
    {
        protected List<Moves> _pokemon;

        public ListMovesRepository()
        {
            _pokemon = new List<Moves>();
        }

        public ListMovesRepository(List<Moves> pokemon)
        {
            _pokemon = pokemon;
        }
        private int nextId()
        {
            int id = 4;
            foreach (Moves pokemon in _pokemon)
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
        public Moves Create(Moves pokemon)
        {
            pokemon.Id = nextId();
            _pokemon.Add(pokemon);
            return pokemon;
        }

        // READALL
        public List<Moves> ReadAll()
        {
            return _pokemon;
        }

        // READBY
        public virtual Moves ReadById(int id)
        {

            foreach (Moves pokemon in _pokemon)
            {
                if (pokemon.Id == id)
                {
                    return pokemon;
                }
            }
            return null;
        }
        // UPDATE
        public void Update(int id, Moves newMovesInfo)
        {
            // Loop until find the index, and modify way
            for (int i = 0; i < _pokemon.Count; i++)
            {
                if (_pokemon[i].Id != id) continue;
                _pokemon[i] = newMovesInfo;
                break;
            }
            //int index = _pokemon.FindIndex((Moves c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _pokemon[index] = newMovesInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            _pokemon.RemoveAll((Moves pokemonInfo) => pokemonInfo.Id == id);
        }

    }
}

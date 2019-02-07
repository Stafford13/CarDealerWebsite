using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Data
{

    // Repository - abstract away how to get a CRUD of object
    // CREATE
    // READALL
    // READBY
    // UPDATE
    // DELETE

    public class FilePokemonRepository : IPokemonRepository
    {
        protected List<Pokemon> pokemon;
        private readonly string FILENAME;

        public FilePokemonRepository(string filename)
        {
            FILENAME = filename;
            LoadPokemon();
        }

        private int nextId()
        {
            int id = 0;
            foreach (Pokemon pokemon in pokemon)
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
            pokemon.Add(pokemon);
            SavePokemon();
            return pokemon;
        }

        // READALL
        public List<Pokemon> ReadAll()
        {
            return pokemon;
        }

        // READBY
        public virtual Pokemon ReadById(int id)
        {

            foreach (Pokemon pokemon in pokemon)
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
            for (int i = 0; i < pokemon.Count; i++)
            {
                if (pokemon[i].Id != id) continue;
                pokemon[i] = newPokemonInfo;
                break;
            }
            SavePokemon();
            //int index = _pokemon.FindIndex((Pokemon c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _pokemon[index] = newPokemonInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            pokemon.RemoveAll((Pokemon pokemonInfo) => pokemonInfo.Id == id);
            SavePokemon();
        }

        /// <summary>
        /// Load from a text file into the pokemon list
        /// </summary>
        private void LoadPokemon()
        {
            List<Pokemon> results = new List<Pokemon>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FILENAME);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    Pokemon p = PokemonMapper.ToPokemon(row);
                    results.Add(p);
                }
                pokemon = results;

            }
            catch (FileNotFoundException fileNotFound)
            {
                Console.WriteLine(fileNotFound.FileName + " was not found");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }


        }

        /// <summary>
        /// Saving to a text file what is in a character list
        /// </summary>
        private void SavePokemon()
        {
            StreamWriter sw = null;
           
            try
            {
                sw = new StreamWriter(FILENAME);
                
                foreach (Pokemon pokemon in pokemon)
                {
                    sw.WriteLine(PokemonMapper.toStringCSV(pokemon));
                    sw.Flush();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                if (sw != null) sw.Close();
            }

        }
    }
}

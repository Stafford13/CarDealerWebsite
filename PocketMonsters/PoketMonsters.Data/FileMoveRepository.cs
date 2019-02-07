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

    public class FileMovesRepository : IMovesRepository
    {
        protected List<Moves> pokemon;
        private readonly string FILENAME;

        public FileMovesRepository(string filename)
        {
            FILENAME = filename;
            LoadMoves();
        }

        private int nextId()
        {
            int id = 0;
            foreach (Moves pokemon in pokemon)
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
            pokemon.Add(pokemon);
            SaveMoves();
            return pokemon;
        }

        // READALL
        public List<Moves> ReadAll()
        {
            return pokemon;
        }

        // READBY
        public virtual Moves ReadById(int id)
        {

            foreach (Moves pokemon in pokemon)
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
            for (int i = 0; i < pokemon.Count; i++)
            {
                if (pokemon[i].Id != id) continue;
                pokemon[i] = newMovesInfo;
                break;
            }
            SaveMoves();
            //int index = _pokemon.FindIndex((Moves c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _pokemon[index] = newMovesInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            pokemon.RemoveAll((Moves pokemonInfo) => pokemonInfo.Id == id);
            SaveMoves();
        }

        /// <summary>
        /// Load from a text file into the pokemon list
        /// </summary>
        private void LoadMoves()
        {
            List<Moves> results = new List<Moves>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FILENAME);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    Moves p = MovesMapper.ToMoves(row);
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
        private void SaveMoves()
        {
            StreamWriter sw = null;
           
            try
            {
                sw = new StreamWriter(FILENAME);
                
                foreach (Moves pokemon in pokemon)
                {
                    sw.WriteLine(MovesMapper.toStringCSV(pokemon));
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

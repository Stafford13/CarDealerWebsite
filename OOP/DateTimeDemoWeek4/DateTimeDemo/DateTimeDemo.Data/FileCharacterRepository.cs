using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.Data
{

    // Repository - abstract away how to get a CRUD of object
    // CREATE
    // READALL
    // READBY
    // UPDATE
    // DELETE
    public class FileCharacterRepository : ICharacterRepository
    {
        protected List<Character> characters;
        private readonly string FILENAME;

        public FileCharacterRepository(string filename)
        {
            FILENAME = filename;
            LoadCharacters();
        }

        private int nextId()
        {
            int id = 0;
            foreach (Character character in characters)
            {
                if (character.Id > id)
                {
                    id = character.Id;
                }
            }
            id = id + 1;
            return id;
        }

        // CREATE
        public Character Create(Character character)
        {
            character.Id = nextId();
            character.CreateDate = DateTime.Now;
            characters.Add(character);
            SaveCharacters();
            return character;
        }

        // READALL
        public List<Character> ReadAll()
        {
            return characters;
        }

        // READBY
        public virtual Character ReadById(int id)
        {

            foreach (Character character in characters)
            {
                if (character.Id == id)
                {
                    return character;
                }
            }
            return null;
        }
        // UPDATE
        public void Update(int id, Character newCharacterInfo)
        {
            // Loop until find the index, and modify way
            for (int i = 0; i < characters.Count; i++)
            {
                if (characters[i].Id != id) continue;
                characters[i] = newCharacterInfo;
                break;
            }
            SaveCharacters();
            //int index = _characters.FindIndex((Character c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _characters[index] = newCharacterInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            characters.RemoveAll((Character characterInfo) => characterInfo.Id == id);
            SaveCharacters();
        }

        /// <summary>
        /// Load from a text file into the character list
        /// </summary>
        private void LoadCharacters()
        {
            List<Character> results = new List<Character>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(FILENAME);
                string row = "";
                while ((row = sr.ReadLine()) != null)
                {
                    Character c = CharacterMapper.ToCharacter(row);
                    results.Add(c);
                }
                characters = results;

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
        private void SaveCharacters()
        {
            StreamWriter sw = null;
           
            try
            {
                sw = new StreamWriter(FILENAME);
                
                foreach (Character character in characters)
                {
                    sw.WriteLine(CharacterMapper.toStringCSV(character));
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

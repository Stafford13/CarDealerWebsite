using System;
using System.Collections.Generic;
using System.Linq;
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

    public class CharacterRepository
    {
        private static List<Character> characters;

        public CharacterRepository()
        {
            if (characters == null)
            {
                characters = new List<Character>();
                for (int i = 0; i < 10; i++)
                {
                    Character character = new Character
                    {
                        Id = i + 1,
                        MaxHealth = 10,
                        CurrentHealth = 10,
                        Gold = 10,
                        Name = "Character " + i,
                        CreateDate = DateTime.Now.AddMonths(-1 * i)
                    };
                    characters.Add(character);
                }
            }
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
            return character;
        }

        // READALL
        public List<Character> ReadAll()
        {
            return characters;
        }

        // READBY
        public Character ReadById(int id)
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

            //int index = characters.FindIndex((Character c) => c.Id == id);
            //if (index >= 0)
            //{
            //    characters[index] = newCharacterInfo;
            //}

          
        }
        // DELETE
        public void Delete(int id)
        {
            characters.RemoveAll((Character characterInfo) => characterInfo.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.Data
{
    public class ListCharacterRepository : ICharacterRepository
    {
        protected List<Character> _characters;

        public ListCharacterRepository()
        {
            _characters = new List<Character>();
        }

        public ListCharacterRepository(List<Character> characters)
        {
            _characters = characters;
        }
        private int nextId()
        {
            int id = 9000;
            foreach (Character character in _characters)
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
            _characters.Add(character);
            return character;
        }

        // READALL
        public List<Character> ReadAll()
        {
            return _characters;
        }

        // READBY
        public virtual Character ReadById(int id)
        {

            foreach (Character character in _characters)
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
            for (int i = 0; i < _characters.Count; i++)
            {
                if (_characters[i].Id != id) continue;
                _characters[i] = newCharacterInfo;
                break;
            }
            //int index = _characters.FindIndex((Character c) => c.Id == id);
            //if (index >= 0)
            //{
            //    _characters[index] = newCharacterInfo;
            //}


        }
        // DELETE
        public void Delete(int id)
        {
            _characters.RemoveAll((Character characterInfo) => characterInfo.Id == id);
        }

    }
}

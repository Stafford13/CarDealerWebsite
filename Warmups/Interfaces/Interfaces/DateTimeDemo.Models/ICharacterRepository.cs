using System.Collections.Generic;


namespace DateTimeDemo.Models
{
    public interface ICharacterRepository
    {
        Character Create(Character character);
        void Delete(int id);
        List<Character> ReadAll();
        Character ReadById(int id);
        void Update(int id, Character newCharacterInfo);
    }
}
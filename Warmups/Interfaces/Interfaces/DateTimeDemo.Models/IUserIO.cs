using System.Collections.Generic;
using DateTimeDemo.Models;

namespace DateTimeDemo
{
    public interface IUserIO
    {
        string ReadString(string message);
        void Display(string message);
        int ReadInt(string message);
        int GetOptions(string message, int min, int max);
        void DisplayCharacter(Character character);
        void PrintCharacters(List<Character> characterList);
        string PromptUser(string message);
        int PromptUserForInt(string message);
        void PrintMessagerClear(string message);
        Character PromptUserForNewCharacter();
    }
}

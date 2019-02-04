using System;
using System.IO;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @".\List.txt";

            if (!File.Exists(path))
            {
                File.Create(path);
            }
            string[] lines = new string[]
            {
            "Blue",
            "Green",
            "Yellow",
            "Red",
            "Orange"
            };

            File.WriteAllLines(path,lines);
        }
    }
}

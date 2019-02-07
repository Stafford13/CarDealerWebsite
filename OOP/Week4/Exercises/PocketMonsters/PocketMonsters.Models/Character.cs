using System;

namespace PocketMonsters.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Number { get; set; }

        public List<Moves> Moves { get; set; }
    }
    
}

using System;

namespace DateTimeDemo.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public double Gold { get; set; }
        public DateTime CreateDate { get; set; }
        
    }
    
}

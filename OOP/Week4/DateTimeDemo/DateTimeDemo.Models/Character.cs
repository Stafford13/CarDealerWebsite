using System;
using System.Collections.Generic;

namespace DateTimeDemo.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public decimal Gold { get; set; }
        public DateTime CreateDate { get; set; }
        
        /// <summary>
        /// Character can hold many items
        /// </summary>
        public List<Item> Items { get; set; }
    }
    
}

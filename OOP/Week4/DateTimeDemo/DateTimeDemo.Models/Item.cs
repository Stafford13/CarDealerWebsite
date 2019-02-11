using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int? CharacterId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        /// <summary>
        /// Overwrites equal function to compare each property in the obj passed in as long as it's a type of 'Item'
        /// </summary>
        /// <param name="obj">object to compare</param>
        /// <returns>returns true</returns>
        public override bool Equals(object obj)
        {
            //TODO: ADVANCE STUFF! Please use with caution!!!
            if (obj.GetType() != typeof(Item)) return base.Equals(obj);
            Item c = (Item) obj;
            return (c.Id == this.Id && 
                this.CharacterId == c.CharacterId &&
                c.Name == this.Name &&
                c.Description == this.Description &&
                c.Cost == this.Cost);
        }
    }
}

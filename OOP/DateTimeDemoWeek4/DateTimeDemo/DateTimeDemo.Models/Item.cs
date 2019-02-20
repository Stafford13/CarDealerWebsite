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
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Item)) return base.Equals(obj);
            Item c = (Item) obj;
            return (c.Id == this.Id && c.Name == this.Name && c.Description == this.Description && c.Cost == this.Cost);
        }
    }
}

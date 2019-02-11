using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DateTimeDemo.Models;

namespace DateTimeDemo.Data
{
    public class CharacterMapper
    {

        public static Character ToCharacter(string row)
        {
            Character c = new Character();
            string[] fields = row.Split(',');
            c.Id = int.Parse(fields[0]);
            c.Name = fields[1];
            c.CurrentHealth = int.Parse(fields[2]);
            c.MaxHealth = int.Parse(fields[3]);
            c.Gold = decimal.Parse(fields[4]);
            c.CreateDate = DateTime.Parse(fields[5]);
            return c;
        }

        public static string toStringCSV(Character c)
        {
            string row = $"{c.Id},{c.Name},{c.CurrentHealth},{c.MaxHealth},{c.Gold},{c.CreateDate.ToString("s")}";
       
            return row;
        }
    }
}

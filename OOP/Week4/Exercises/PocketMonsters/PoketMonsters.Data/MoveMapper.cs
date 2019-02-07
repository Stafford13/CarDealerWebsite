using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Data
{
    public class MovesMapper
    {

        public static Moves ToMoves(string row)
        {
            Moves m = new Moves();
            string[] fields = row.Split(',');
            m.Id = int.Parse(fields[0]);
            m.Name = fields[1];
            m.Description = fields[2];
            m.Damage = int.Parse(fields[3]);
            return m;
        }

        public static string toStringCSV(Moves m)
        {
            string row = $"{m.Id},{m.Name},{m.Description},{m.Damage}";
       
            return row;
        }
    }
}

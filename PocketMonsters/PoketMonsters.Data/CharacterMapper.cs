using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocketMonsters.Models;

namespace PocketMonsters.Data
{
    public class PokemonMapper
    {

        public static Pokemon ToPokemon(string row)
        {
            Pokemon p = new Pokemon();
            string[] fields = row.Split(',');
            p.Id = int.Parse(fields[0]);
            p.Name = fields[1];
            p.Type = fields[2];
            p.Number = int.Parse(fields[3]);
            return p;
        }

        public static string toStringCSV(Pokemon p)
        {
            string row = $"{p.Id},{p.Name},{p.Type},{p.Number}";
       
            return row;
        }
    }
}

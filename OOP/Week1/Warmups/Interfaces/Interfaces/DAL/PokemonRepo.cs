using System;
using System.Collections.Generic;
using PokeUser;
using Noun;
using Models;

namespace ListData
{
    public class PokemonRepository : IPokemonRepository
    {
         Pokemon p1 = new Pokemon
         {
             Name = "Raichu",
             Type = "Electric",
             Number = 026
         };

        Pokemon p2 = new Pokemon
        {
            Name = "Pikachu",
            Type = "Electric",
            Number = 025,
            //EvolveInto = 026
        };

        Pokemon p3 = new Pokemon
        {
            Name = "Onix",
            Type = "Rock // Ground",
            Number = 095
        };

        Pokemon p4 = new Pokemon
        {
            Name = "Vaporeon",
            Type = "Water",
            Number = 134
        };

        Pokemon p5 = new Pokemon
        {
            Name = "Jolteon",
            Type = "Electric",
            Number = 135
        };

        Pokemon p6 = new Pokemon
        {
            Name = "Flareon",
            Type = "Fire",
            Number = 136
        };

        Pokemon p7 = new Pokemon
        {
            Name = "Eevee",
            Type = "Normal",
            Number = 133,
            //Random rnd = new Random()
            //EvolveInto = p4,
            //(EvolveInto = p5),
            //EvolveInto = p6
        };


    }

}


using System;
using PocketMonsters.Data;
using PocketMonsters.Models;
using PocketMonsters.UI;
using PocketMonsters.BLL;

namespace PocketMonsters
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserIO bob = new UserIO();
            
            IPokemonRepository repo = new FilePokemonRepository("PocketMonsters.txt");
            IMovesRepository movesRepo = new FileMovesRepository("Moves.txt");
            PokeManager manager = new PokeManager(bob, repo, movesRepo);
            manager.Run();
        }
    }
    //public abstract class Shape
    //{
    //    public int Length { get; set; }
    //    public int Height { get; set; }

    //    public void Draw()
    //    {
    //        Console.WriteLine("I'm a shape.");
    //    }

    //    public abstract void Fill();

    //    public virtual void Erase()
    //    {

    //    }
    //}
    //public class Circle : Shape
    //{
    //    public override void Fill()
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public override void Erase()
    //    {
    //        Console.WriteLine("Before");
    //        base.Erase();
    //    }
    //}
}
using System;
using DateTimeDemo.Data;
using DateTimeDemo.Models;
using DateTimeDemo.UI;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserIO io = new UserIO();
            
            ICharacterRepository repo = new FileCharacterRepository("Characters.txt");
            CharacterManager manager = new CharacterManager(io, repo);
            manager.Run();
        }
    }

    //public abstract class Shape
    //{
    //    public int Length { get; set; }
    //    public int Height { get; set; }

    //    public void Draw()
    //    {
    //        Console.WriteLine("I'm a shape");
    //    }

    //    public abstract void Fill();

    //    public virtual void Erase()
    //    {
    //        Console.WriteLine("blah");
    //    }
    //}

    //public class Circle : Shape
    //{
    //    public override void Fill()
    //    {
    //        Console.WriteLine("Phil on the wall...");
    //    }

    //    public override void Erase()
    //    {
    //        Console.WriteLine("Before");
    //        base.Erase();
    //        Console.WriteLine("After");
    //    }
    //}
}
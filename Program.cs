using System;
using dotnet_poo.src.Entities;


namespace dotnet_poo
{

    class Program
    {
        static void Main(string[]args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));



        }
    }
}
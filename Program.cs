using System;
using JogoC.src.Entities;

namespace JogoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Arus", 12, "Warrior");
            Wizard wizard = new Wizard("Jennica", 24, "Mage");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
        }
    }
}

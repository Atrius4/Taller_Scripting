using System;
using System.Dynamic;

namespace CRITTERS_
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager Juego = new GameManager();
            Console.WriteLine(Juego.ThrowCritter());
            while (Console.ReadLine() != null)
            {
                Juego.Combat(Juego.fightingCritter1, Juego.fightingCritter2);
            }

           




        }
    }
}

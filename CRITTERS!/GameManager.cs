using System;
using System.Collections.Generic;
using System.Text;

namespace CRITTERS_
{
    class GameManager
    {
        Player darkar = new Player(3);
        Player mecoboy = new Player(3);
        Critter fightingCritter1;
        Critter fightingCritter2;
        public string ThrowCritter()
        {
            string resultado;
            Critter fightingCritter1 = darkar.critters.Dequeue();
            Critter fightingCritter2 = mecoboy.critters.Dequeue();
            this.fightingCritter1 = fightingCritter1;
            this.fightingCritter2 = fightingCritter2;

            resultado = ("Darkar ha lanzado a " + fightingCritter1.Name + "\n Mecoboy ha lanzado a " + fightingCritter2.Name);
            return resultado;
        }

        

        
    }
}

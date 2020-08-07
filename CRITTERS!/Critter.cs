using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRITTERS_
{
    class Critter
    {
        public string Name { get; private set; }                    //Attributes needed

        public int BaseAttack { get; private set; }                //Each stat will have a base value, which won't change, and an actual stat which is gonna be used in combat just in case there's some modifications 
        public int AttackStat { get; private set; }

        public int BaseDefense { get; private set; }
        public int DefenseStat { get; private set; }

        public int BaseSpeed { get; private set; }
        public int SpeedStat { get; private set; }

        public Eaffinity Affinity { get; private set; }

        public List<Skill> moveset = new List<Skill>();

        public int HP { get; private set; }

        public enum Eaffinity
        {
            Fire,
            Wind,
            Water,
            Earth,
            Light,
            Dark
        }

        public Critter(string name, int baseAttack, int baseDefense, int baseSpeed, int HP, int affinityNumber)
        {
            Name = name;
            BaseAttack = baseAttack;
            BaseDefense = baseDefense;
            BaseSpeed = baseSpeed;
            this.HP = HP;

            AttackStat = baseAttack;
            DefenseStat = baseDefense;
            SpeedStat = baseSpeed;

            SetAffinity(affinityNumber);
            FillMoveset(moveset);



        }

        public void SetAffinity(int affinityNumber)
        {

            switch (affinityNumber)
            {
                case 1:
                    Affinity = Eaffinity.Fire;
                    break;
                case 2:
                    Affinity = Eaffinity.Wind;
                    break;
                case 3:
                    Affinity = Eaffinity.Water;
                    break;
                case 4:
                    Affinity = Eaffinity.Earth;
                    break;
                case 5:
                    Affinity = Eaffinity.Light;
                    break;
                case 6:
                    Affinity = Eaffinity.Dark;
                    break;

            }
        }
        public void FillMoveset(List<Skill> Crittermoveset)
        {
            Random random = new Random();
            if (Crittermoveset == moveset)
            {
                for (int i = 0; i < random.Next(1, 4); i++)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        moveset.Add(new AttackSkill("Habilidad de Ataque " + (i+1), random.Next(1, 10), random.Next(1, 7)));
                    }
                    else
                    {
                        moveset.Add(new SupportSkill("Habilidad de soporte " + (i+1), random.Next(1, 7),0 ));
                    }
                }

            }
        }

        public Skill UseSkill()
        {
            Random random = new Random();
            int numeroElegido = random.Next(1, moveset.Count);

            return moveset[numeroElegido];
        }
    }
}

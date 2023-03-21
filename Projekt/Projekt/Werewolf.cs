using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Werewolf
    {
        public double MaxHealth;
        public double Health;
        public bool IsAlive = true;
        public Random random = new Random();
        public double baseDamage = 5;
        public double Resistance = 0.3;
        public bool DoubleAttack = false;
        public double extraHealth = 2;
        public double extraDamage = 3;
        public string type;

        public double HealthRegeneration(SwampWerewolf werewolf)
        {
            if (random.Next(100) < 10)
            {
                Console.WriteLine("Werewolf's health became restored to maximum");
                return werewolf.MaxHealth;
            }
            else return werewolf.Health;
        }
        public Werewolf(double MaxHealth, bool IsAlive, double baseDamage)
        {
            this.MaxHealth = MaxHealth;
            Health = MaxHealth;
            this.IsAlive = IsAlive;
            this.baseDamage = baseDamage;
            type = "Werewolf";
        }
    }
}

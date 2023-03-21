using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Drowner
    {
        public double MaxHealth;
        public double Health;
        public Random rnd = new Random();
        public bool IsAlive = true;
        public double baseDamage = 3;
        public double Resistance = 0.1;
        public bool DoubleAttack = false;
        public double extraHealth = 2;
        public double extraDamage = 3;
        public string type;


        public Drowner(double MaxHealth, bool IsAlive, double baseDamage)
        {
            this.MaxHealth = MaxHealth;
            Health = MaxHealth;
            this.IsAlive = IsAlive;
            this.baseDamage = baseDamage;
        }

        public bool Dodge()
        {
            int number = rnd.Next(1, 10);
            if (number > 18)
                return true;
            else return false;
        }
    }
}

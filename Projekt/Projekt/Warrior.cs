using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class Warrior
    {
        public double MaxHealth;
        public double Health;
        public bool IsAlive = true;
        public double Resistance = 0;
        public double baseDamage = 5;
        public bool DoubleAttack = false;
        public int extraHealth = 2;
        public int extraDamage = 3;
        public string type;

        public double TakeArmor(Witcher witcher)
        {
            witcher.Health -= witcher.armor.ArmorPoints;
            return witcher.Health;
        }
        public Warrior(double MaxHealth, bool IsAlive, double baseDamage)
        {
            this.MaxHealth = MaxHealth;
            Health = MaxHealth;
            this.IsAlive = IsAlive;
            this.baseDamage = baseDamage;
        }

    }
}

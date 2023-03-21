using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class ForestWarrior: Warrior
    {
        public double TakeArmor(Witcher witcher)
        {
            witcher.Health -= witcher.armor.ArmorPoints;
            return witcher.Health;
        }

        public double RestoreArmor(Witcher witcher)
        {
            witcher.Health += witcher.armor.ArmorPoints;
            return witcher.Health;
        }
        public ForestWarrior(double MaxHealth, bool isAlive, double baseDamage, double Resistance, int extraHealth, int extraDamage) : base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;
            this.extraHealth = extraHealth;
            this.extraDamage = extraDamage;
            type = "Forest Warrior";
        }
    }
}

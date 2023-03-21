using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SwampWarrior: Warrior
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
        public SwampWarrior(double MaxHealth, bool isAlive, double baseDamage, double Resistance, bool DoubleAttack) : base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;
            this.DoubleAttack = DoubleAttack;
            type = "Swamp Warrior";
        }
    }
}

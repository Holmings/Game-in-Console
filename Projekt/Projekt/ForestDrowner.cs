using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class ForestDrowner: Drowner
    {
        public bool Dodge()
        {
            int number = rnd.Next(1, 10);
            if (number > 18)
                return true;
            else return false;
        }


        public ForestDrowner(double MaxHealth, bool isAlive, double baseDamage, double Resistance, int extraHealth, int extraDamage) : base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;
            this.extraHealth = extraHealth;
            this.extraDamage = extraDamage;
            Health += extraHealth;
            this.baseDamage += extraDamage;
            type = "Forest Drowner";
        }
    }
}

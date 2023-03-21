using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SwampDrowner: Drowner
    {
        public bool Dodge()
        {
            int number = rnd.Next(1, 20);
            if (number > 15)
                return true;
            else return false;
        }
        public SwampDrowner(double MaxHealth, bool isAlive, double baseDamage, double Resistance, bool DoubleAttack):base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;   
            this.DoubleAttack = DoubleAttack;
            type = "Swamp Drowner";
        }
    }
}

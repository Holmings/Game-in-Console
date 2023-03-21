using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SwampWerewolf: Werewolf
    {
        public double HealthRegeneration(SwampWerewolf werewolf)
        {
            if (random.Next(100) < 10)
            {
            Console.WriteLine("Werewolf's health became restored to maximum");
            return werewolf.MaxHealth;
            }
            else return werewolf.Health;
        }

        public SwampWerewolf(double MaxHealth, bool isAlive, double baseDamage, double Resistance, bool DoubleAttack) : base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;
            this.DoubleAttack = DoubleAttack;
            type = "Swamp Werewolf";
        }
    }
}

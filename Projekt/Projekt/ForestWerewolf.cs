using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class ForestWerewolf: Werewolf
    {
        public double HealthRegeneration(ForestWerewolf werewolf)
        {
            if (random.Next(100) < 10)
            {
                Console.WriteLine("Werewolf's health became restored to maximum");
                return werewolf.MaxHealth;
            }
            else return werewolf.Health;
        }
        public ForestWerewolf(double MaxHealth, bool isAlive,  double baseDamage, double Resistance, int extraHealth, int extraDamage) : base(MaxHealth, isAlive, baseDamage)
        {
            this.Resistance = Resistance;
            this.extraHealth = extraHealth;
            this.extraDamage = extraDamage;
            type = "Forest Werewolf";
        }
    }
}

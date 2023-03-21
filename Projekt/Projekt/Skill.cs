using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Skill
    {
        public void IncreaseSilverSword(Witcher sword)
        {
            sword.sword2.Power += 3;
        }

        public void IncreaseSteelSword(Witcher sword)
        {
            sword.sword1.Power += 3;
        }

        public void ExtraHealth(Witcher health) 
        {
            health.baseDamage -= 2;
            health.Health += 10;

        }

        public void CriticalDamageChance(Witcher chance)
        {
            chance.CriticalDamageChance += 5;
        }

        public void ResetHealth(Witcher health)
        {
            health.Health = health.MaxHealth;
        }
    }
}

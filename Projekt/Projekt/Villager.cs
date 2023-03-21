using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Villager
    {
        public string SkillName { get; set; }

        public Villager(string Skillname)
        {
            this.SkillName = Skillname;
        }

        public string Information()
        {
            return "This Villager's skill: " + SkillName + ". It's time to play Gwent for it.\n" +
                SkillName;
        }


        public void UseSkill(Witcher witcher)
        {
            witcher.WitcherSkills[SkillName] = true;  
        }

        public void SkillInfo()
        {
            if(SkillName == "IncreaseSilverSword")
            {
                Console.Write(" Adds 3 points to Silver Sword's power");
            }
            else if(SkillName == "IncreaseSteelSword")
            {
                Console.Write(" Adds 3 point to Steel Sword's power");
            }
            else if(SkillName== "ExtraHealth")
            {
                Console.Write(" Adds 10 points to Witcher's health but it costs 2 points of damage");
            }
            else if(SkillName == "CriticalDamageChance")
            {
                Console.Write(" Adds 5 point to Critical Damage chance");
            }
            else if(SkillName == "ResetHealth")
            {
                Console.Write(" Sets Witcher's base health as his current health");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Witcher
    {
        public double MaxHealth { get; set; }
        public double Health { get; set; }
        public double baseDamage { get; set; }
        public int CriticalDamageChance { get; set; }
        public Sword sword1 = new SteelSword();
        public Sword sword2 = new SilverSword();
        public Armor armor = new Armor(40);
        public Dictionary<string, bool> WitcherSkills = new Dictionary<string, bool>();
        public void DictionaryClass()
        {
            WitcherSkills.Add("IncreaseSilverSword", false);
            WitcherSkills.Add("IncreaseSteelSword", false);
            WitcherSkills.Add("ExtraHealth", false);
            WitcherSkills.Add("CriticalDamageChance", false);
            WitcherSkills.Add("ResetHealth", false);
        }

        public void ModifySkills(string skillname)
        {
            WitcherSkills[skillname] = true;
        }

        public Witcher(double MaxHealth, int CriticalDamageChance, int baseDamage)
        {
            this.MaxHealth = MaxHealth;
            Health = MaxHealth + armor.ArmorPoints;
            this.CriticalDamageChance = CriticalDamageChance;
            this.baseDamage = baseDamage;
        }
    }
}

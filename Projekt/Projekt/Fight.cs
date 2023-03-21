using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Fight
    {
        Skill skill = new Skill();
        Random random = new Random();
        string value;

        public void BeforeFight(Witcher witcher)
        {
            Console.WriteLine("\nYou can use one of your skills for this fight.");
            int j = 1;

            foreach (KeyValuePair<string, bool> kvp in witcher.WitcherSkills)
            {
                if (kvp.Value == true)
                {
                    Console.WriteLine(j + " - " + kvp.Key);
                    j++;
                }
                else
                {
                    Console.WriteLine(j + " - {0} not available");
                    j++;
                }
            }
            Console.WriteLine("Press another key to exit");
            value = Console.ReadLine();

            switch(value)
            {
                case "1":
                    if(witcher.WitcherSkills["IncreaseSilverSword"]==true)
                        skill.IncreaseSilverSword(witcher);
                    break;
                case "2":
                    if (witcher.WitcherSkills["IncreaseSteelSword"] == true)
                        skill.IncreaseSteelSword(witcher);
                    break;
                case "3":
                    if (witcher.WitcherSkills["ExtraHealth"] == true)
                        skill.ExtraHealth(witcher);
                    break;
                case "4":
                    if (witcher.WitcherSkills["CriticalDamageChance"]==true)
                        skill.CriticalDamageChance(witcher);
                    break;
                case "5":
                    if (witcher.WitcherSkills["ResetHealth"]==true)
                        skill.ResetHealth(witcher);
                    break;
                default:
                    break;
            }
        }
        public bool FightSwampDrowner(Witcher witcher, SwampDrowner swampdrowner)
        {
            witcher.baseDamage += witcher.sword2.Power;
            while ((witcher.Health>0)&&(swampdrowner.Health>0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Swamp Drowner health: " + swampdrowner.Health);
                if(random.Next(100)<=witcher.CriticalDamageChance)
                {
                    swampdrowner.Health = 0;
                    swampdrowner.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                if (swampdrowner.Dodge() == false)
                { swampdrowner.Health -= witcher.baseDamage; }
                else Console.WriteLine("Monster dodged your attack.");
                if (swampdrowner.DoubleAttack == true)
                {
                    Console.WriteLine("Swamp Drowner's double attack!");
                    witcher.Health -= 2*swampdrowner.baseDamage;
                }
                else witcher.Health -= swampdrowner.baseDamage;
            }
            witcher.baseDamage -= witcher.sword2.Power;
            if (swampdrowner.Health <= 0)
            {
                swampdrowner.IsAlive=false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FightSwampDrownerResult(Witcher witcher, List<Drowner> drownershere)
        {
            foreach (SwampDrowner item in drownershere)
            {
                Console.WriteLine("You meet Swamp Drowner");
                BeforeFight(witcher);
                Console.Clear();
                if (FightSwampDrowner(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    System.Environment.Exit(0);
                }
            }
            return witcher.Health;
        }

        public bool FightForestDrowner(Witcher witcher, ForestDrowner forestDrowner)
        {
            witcher.baseDamage += witcher.sword2.Power;
            while ((witcher.Health > 0) && (forestDrowner.Health > 0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Forest Drowner health: " + forestDrowner.Health);
                if (random.Next(100) <= witcher.CriticalDamageChance)
                {
                    forestDrowner.Health = 0;
                    forestDrowner.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                if (forestDrowner.Dodge() == false)
                { forestDrowner.Health -= witcher.baseDamage; }
                else Console.WriteLine("Monster dodged your attack.");
                witcher.Health -= forestDrowner.baseDamage;
            }
            witcher.baseDamage -= witcher.sword2.Power;
            if (forestDrowner.Health <= 0)
            {
                forestDrowner.IsAlive = false;
                return true;
            }
            else
            {
                return false;
            }
        }


        public double FightForestDrownerResult(Witcher witcher, List<Drowner> drownershere)
        {
            foreach (ForestDrowner item in drownershere)
            {
                Console.WriteLine("You meet Forest Drowner");
                BeforeFight(witcher);
                Console.Clear();
                if (FightForestDrowner(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    return 0;
                }
            }
            return witcher.Health;
        }

        public bool FightSwampWerewolf(Witcher witcher, SwampWerewolf swampWerewolf)
        {
            witcher.baseDamage += witcher.sword2.Power;
            while ((witcher.Health > 0) && (swampWerewolf.Health > 0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Swamp Werewolf health: " + swampWerewolf.Health);
                if (random.Next(100) <= witcher.CriticalDamageChance)
                {
                    swampWerewolf.Health = 0;
                    swampWerewolf.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                swampWerewolf.Health -= witcher.baseDamage;
                swampWerewolf.Health = swampWerewolf.HealthRegeneration(swampWerewolf);
                if (swampWerewolf.DoubleAttack == true)
                {
                    Console.WriteLine("Swamp Werewolf's double attack!");
                    witcher.Health -= 2 * swampWerewolf.baseDamage;
                }
                else witcher.Health -= swampWerewolf.baseDamage;
            }
            witcher.baseDamage -= witcher.sword2.Power;
            if (swampWerewolf.Health <= 0)
            {
                swampWerewolf.IsAlive = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FightSwampWerewolfResult(Witcher witcher, List<Werewolf> werewolfshere)
        {
            foreach (SwampWerewolf item in werewolfshere)
            {
                Console.WriteLine("You meet Swamp Werewolf");
                BeforeFight(witcher);
                Console.Clear();
                if (FightSwampWerewolf(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    System.Environment.Exit(0);
                }
            }
            return witcher.Health;
        }

        public bool FightForestWerewolf(Witcher witcher, ForestWerewolf forestWerewolf)
        {
            witcher.baseDamage += witcher.sword2.Power;
            while ((witcher.Health > 0) && (forestWerewolf.Health > 0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Forest Werewolf health: " + forestWerewolf.Health);
                if (random.Next(100) <= witcher.CriticalDamageChance)
                {
                    forestWerewolf.Health = 0;
                    forestWerewolf.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                forestWerewolf.Health -= witcher.baseDamage;
                forestWerewolf.Health = forestWerewolf.HealthRegeneration(forestWerewolf);
                witcher.Health -= forestWerewolf.baseDamage;
            }
            witcher.baseDamage -= witcher.sword2.Power;
            if (forestWerewolf.Health <= 0)
            {
                forestWerewolf.IsAlive = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FightForestWerewolfResult(Witcher witcher, List<Werewolf> werewolfshere)
        {
            foreach (ForestWerewolf item in werewolfshere)
            {
                Console.WriteLine("You meet Forest Werewolf");
                BeforeFight(witcher);
                Console.Clear();
                if (FightForestWerewolf(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    System.Environment.Exit(0);
                }
            }
            return witcher.Health;
        }

        public bool FightSwampWarrior(Witcher witcher, SwampWarrior swampWarrior)
        {
            witcher.Health = swampWarrior.TakeArmor(witcher);
            Console.WriteLine("Warrior took your armor");
            witcher.baseDamage += witcher.sword1.Power;
            while ((witcher.Health > 0) && (swampWarrior.Health > 0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Swamp Warrior health: " + swampWarrior.Health);
                if (random.Next(100) <= witcher.CriticalDamageChance)
                {
                    swampWarrior.Health = 0;
                    swampWarrior.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                swampWarrior.Health -= witcher.baseDamage;
                if (swampWarrior.DoubleAttack == true)
                {
                    Console.WriteLine("Swamp Warrior's double attack!");
                    witcher.Health -= 2 * swampWarrior.baseDamage;
                }
                else witcher.Health -= swampWarrior.baseDamage;
            }
            witcher.baseDamage -= witcher.sword1.Power;
            if (swampWarrior.Health <= 0)
            {
                swampWarrior.IsAlive = false;
                witcher.Health = swampWarrior.RestoreArmor(witcher);
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FightSwampWarriorfResult(Witcher witcher, List<Warrior> warriorshere)
        {
            foreach (SwampWarrior item in warriorshere)
            {
                Console.WriteLine("You meet Swamp Warrior");
                BeforeFight(witcher);
                Console.Clear();
                if (FightSwampWarrior(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    System.Environment.Exit(0);
                }
            }
            return witcher.Health;
        }

        public bool FightForestWarrior(Witcher witcher, ForestWarrior forestWarrior)
        {
            witcher.Health = forestWarrior.TakeArmor(witcher);
            Console.WriteLine("Warrior took your armor");
            witcher.baseDamage += witcher.sword1.Power;
            while ((witcher.Health > 0) && (forestWarrior.Health > 0))
            {
                Console.WriteLine("Witcher's health: " + witcher.Health);
                Console.WriteLine("Forest Warrior health: " + forestWarrior.Health);
                if (random.Next(100) <= witcher.CriticalDamageChance)
                {
                    forestWarrior.Health = 0;
                    forestWarrior.IsAlive = false;
                    Console.WriteLine("Critical Damage!");
                    return true;
                }
                forestWarrior.Health -= witcher.baseDamage;
                witcher.Health -= forestWarrior.baseDamage;
            }
            witcher.baseDamage -= witcher.sword1.Power;
            if (forestWarrior.Health <= 0)
            {
                witcher.Health = forestWarrior.RestoreArmor(witcher);
                forestWarrior.IsAlive = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double FightForestWarriorResult(Witcher witcher, List<Warrior> warriorshere)
        {
            foreach (ForestWarrior item in warriorshere)
            {
                Console.WriteLine("You meet Forest Warrior");
                BeforeFight(witcher);
                Console.Clear();
                if (FightForestWarrior(witcher, item) == true)
                {
                    Console.WriteLine("You won. Your health now: " + witcher.Health);
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("You lost");
                    System.Environment.Exit(0);
                }
            }
            return witcher.Health;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Journey
    {
        Witcher witcher = new Witcher(200, 20, 70);
        Villager villager1 = new Villager("IncreaseSilverSword");
        Villager villager2 = new Villager("IncreaseSteelSword");
        Villager villager3 = new Villager("ExtraHealth");
        Villager villager4 = new Villager("CriticalDamageChance");
        Villager villager5 = new Villager("ResetHealth");
        Fight fight = new Fight();
        string choice;


        public void Go()
        {
            witcher.DictionaryClass();
            Console.WriteLine("You are a Witcher. You received a mission to deliver a letter to Velen. It won't be an easy trip. " +
                "You have to be prepared for everything. Let's go.");
            while (true)
            {
                Console.WriteLine("Choose your base skill:\n1 - IncreaseSilverSword\n2 - IncreaseSteelSword\n3 - ExtraHealth\n4 - CriticalDamageChance");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        witcher.WitcherSkills["IncreaseSilverSword"] = true;
                        break;
                    case "2":
                        witcher.WitcherSkills["IncreaseSteelSword"] = true;
                        break;
                    case "3":
                        witcher.WitcherSkills["ExtraHealth"] = true;
                        break;
                    case "4":
                        witcher.WitcherSkills["CriticalDamageChance"] = true;
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
                break;
            }
            Console.WriteLine("You can use any available skill before fight with each one enemy. The effect lasts untill the end of the game.");
            Console.ReadKey();
            Console.Clear();
            Forest forest1 = new Forest(true);
            Swamp swamp1 = new Swamp(true);
            Hut hut1 = new Hut(false);
            Forest forest2 = new Forest(false);
            Hut hut2 = new Hut(true);
            Swamp swamp2 = new Swamp(false);
            Hut hut3 = new Hut(false);
            Swamp swamp3 = new Swamp(true);
            Forest forest3 = new Forest(true);

            Console.WriteLine(forest1.Type);
            witcher.baseDamage = forest1.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            forest1.CreateDrownerList(3, 1);
            forest1.CreateWarriorList(2, 1);
            forest1.CreateWerewolfList(1, 1);
            witcher.Health = fight.FightForestDrownerResult(witcher, forest1.DrownersHere);
            witcher.Health = fight.FightForestWerewolfResult(witcher, forest1.WerewolfsHere);
            witcher.Health = fight.FightForestWarriorResult(witcher, forest1.WarriorsHere);

            Console.WriteLine(swamp1.Type);
            witcher.baseDamage = swamp1.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            swamp1.CreateDrownerList(2, 1);
            swamp1.CreateWarriorList(1, 1);
            swamp1.CreateWerewolfList(1, 1);
            witcher.Health = fight.FightSwampDrownerResult(witcher, swamp1.DrownersHere);
            witcher.Health = fight.FightSwampWerewolfResult(witcher, swamp1.WerewolfsHere);
            witcher.Health = fight.FightSwampWarriorfResult(witcher, swamp1.WarriorsHere);

            //pierwsza chata
            Console.WriteLine(hut1.Type);
            Console.ReadKey();
            witcher.baseDamage = hut1.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            hut1.CreateVillagersList(villager1);
            hut1.CreateVillagersList(villager3);

            foreach(Villager vill in hut1.VillagersHere)
            {
                Console.Write(vill.Information());
                vill.SkillInfo();
                Game.WithComputer(vill, witcher);
            }

            Console.WriteLine(forest2.Type);
            Console.ReadKey();
            witcher.baseDamage = forest2.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            forest2.CreateDrownerList(2, 2);
            forest2.CreateWarriorList(1, 2);
            forest2.CreateWerewolfList(3, 2);
            witcher.Health = fight.FightForestDrownerResult(witcher, forest2.DrownersHere);
            witcher.Health = fight.FightForestWerewolfResult(witcher, forest2.WerewolfsHere);
            witcher.Health = fight.FightForestWarriorResult(witcher, forest2.WarriorsHere);

            //druga chata
            Console.WriteLine(hut2.Type);
            Console.ReadKey();
            witcher.baseDamage = hut2.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            hut2.CreateVillagersList(villager2);
            hut2.CreateVillagersList(villager5);
            hut2.CreateVillagersList(villager3);
            foreach (Villager vill in hut2.VillagersHere)
            {
                Console.Write(vill.Information());
                vill.SkillInfo();
                Game.WithComputer(vill, witcher);
            }


            Console.WriteLine(swamp2.Type);
            witcher.baseDamage = swamp2.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            swamp2.CreateDrownerList(4, 2);
            swamp2.CreateWarriorList(2, 2);
            swamp2.CreateWerewolfList(2, 2);
            witcher.Health = fight.FightSwampDrownerResult(witcher, swamp2.DrownersHere);
            witcher.Health = fight.FightSwampWerewolfResult(witcher, swamp2.WerewolfsHere);
            witcher.Health = fight.FightSwampWarriorfResult(witcher, swamp2.WarriorsHere);

            //trzecia chata
            Console.WriteLine(hut3.Type);
            Console.ReadKey();
            hut3.PlaceOfPowerInfo();
            witcher.baseDamage = hut3.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            hut3.CreateVillagersList(villager4);
            hut3.CreateVillagersList(villager2);
            foreach (Villager vill in hut3.VillagersHere)
            {
                Console.Write(vill.Information());
                vill.SkillInfo();
                Game.WithComputer(vill, witcher);
            }


            Console.WriteLine(forest3.Type);
            witcher.baseDamage = forest3.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            forest3.CreateDrownerList(4, 3);
            forest3.CreateWarriorList(4, 3);
            forest3.CreateWerewolfList(3, 3);
            witcher.Health = fight.FightForestDrownerResult(witcher, forest3.DrownersHere);
            witcher.Health = fight.FightForestWerewolfResult(witcher, forest3.WerewolfsHere);
            witcher.Health = fight.FightForestWarriorResult(witcher, forest3.WarriorsHere);

            Console.WriteLine(swamp3.Type);
            witcher.baseDamage = swamp3.PlaceOfPowerTrue(witcher);
            Console.ReadKey();
            Console.Clear();
            swamp3.CreateDrownerList(5, 3);
            swamp3.CreateWarriorList(4, 3);
            swamp3.CreateWerewolfList(4, 3);
            witcher.Health = fight.FightSwampDrownerResult(witcher, swamp3.DrownersHere);
            witcher.Health = fight.FightSwampWerewolfResult(witcher, swamp3.WerewolfsHere);
            witcher.Health = fight.FightSwampWarriorfResult(witcher, swamp3.WarriorsHere);


            Console.WriteLine("You succesfully completed your mission. The letter is delivered.");
        }
    }
}


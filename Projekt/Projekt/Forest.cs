using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Forest: DangerousPlace
    {
        public string TypeOfDangerousPlace { get; set; }
        public List<Drowner> DrownersHere = new List<Drowner>();
        public List<Warrior> WarriorsHere = new List<Warrior>();
        public List<Werewolf> WerewolfsHere = new List<Werewolf>();

        public void CreateDrownerList(int numberOfDrowners, int stageNumber)
        {
            ForestBoost forest = new ForestBoost();
            MonsterFactory factory = new MonsterFactory(forest);
            for (int i = 0; i < numberOfDrowners; i++)
            {
                DrownersHere.Add(factory.CreateDrowner(stageNumber));
            }
        }

        public void CreateWarriorList(int numberOfWarrior, int stageNumber)
        {
            ForestBoost forest = new ForestBoost();
            MonsterFactory factory = new MonsterFactory(forest);
            for (int i = 0; i < numberOfWarrior; i++)
            {
                WarriorsHere.Add(factory.CreateWarrior(stageNumber));
            }
        }

        public void CreateWerewolfList(int numberOfWerewolf, int stageNumber)
        {
            ForestBoost forest = new ForestBoost();
            MonsterFactory factory = new MonsterFactory(forest);
            for (int i = 0; i < numberOfWerewolf; i++)
            {
                WerewolfsHere.Add(factory.CreateWerewolf(stageNumber));
            }
        }

        public double PlaceOfPowerTrue(Witcher witcher)
        {
            if (PlaceofPower == true)
            {
                Console.WriteLine("You found a place of power. You have to draw from it.\nWitcher's damage increased to: " + (witcher.baseDamage + 20));
                return witcher.baseDamage += 20;
            }
            else
            {
                Console.WriteLine("There is no place of power here.");
                return witcher.baseDamage;
            }
        }

        public Forest(bool PlaceofPower)
        {
            Type = "Forest";
            this.PlaceofPower = PlaceofPower;
        }
    }
}

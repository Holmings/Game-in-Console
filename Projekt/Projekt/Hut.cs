using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Hut: SafePlace
    {
        public string TypeOfSafePlace { get; set; }
        public List<Villager> VillagersHere = new List<Villager>();

        public void CreateVillagersList(Villager villager)
        {
            VillagersHere.Add(villager);
        }

        public string PlaceOfPowerInfo()
        {
            if (PlaceofPower == true)
                return "You found a place of power. You have to draw from it.";
            else return "There is no place of power here.";
        }

        public double PlaceOfPowerTrue(Witcher witcher)
        {
            if(PlaceofPower == true)
            {
                return witcher.baseDamage += 20;
            }
            else return witcher.baseDamage;
        }


        public Hut(bool PlaceofPower)
        {
            Type = "Hut";
            this.PlaceofPower = PlaceofPower;
        }
    }
}

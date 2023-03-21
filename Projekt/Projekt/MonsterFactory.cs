using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class MonsterFactory
    {
        public PlaceBoost placeBoost;
        public MonsterFactory(PlaceBoost placeBoost)
        {
            this.placeBoost = placeBoost;
        }

        public Drowner CreateDrowner(int stageNumber)
        {
            Drowner drowner = placeBoost.ProduceDrowner(stageNumber);
            return drowner;
        }

        public Werewolf CreateWerewolf(int stageNumber)
        {
            Werewolf werewolf = placeBoost.ProduceWerewolf(stageNumber);
            return werewolf;
        }
        public Warrior CreateWarrior(int stageNumber)
        {
            Warrior warrior = placeBoost.ProduceWarrior(stageNumber);
            return warrior;
        }


    }
}

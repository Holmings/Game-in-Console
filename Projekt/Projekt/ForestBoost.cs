using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class ForestBoost: PlaceBoost
    {

        protected int ExtraHealth(int extra)
        {
            return extra;
        }

        protected int ExtraDamage(int extra)
        {
            return extra;
        }
        public override Drowner ProduceDrowner(int stageNUmber)
        {
            if (stageNUmber == 1)
            {
                return new ForestDrowner(8, true, 3, 0.1, 1, 1);
            }
            else if (stageNUmber == 2)
            {
                return new ForestDrowner(13, true, 4, 0.2, 2, 3);
            }
            else
                return new ForestDrowner(15, true, 5, 0.4, 3, 5);
        }

        public override Warrior ProduceWarrior(int stageNumber)
        {
            if(stageNumber == 1)
            {
                return new ForestWarrior(15, true, 5, 0.3, 5, 4);
            }
            else
            {
                return new ForestWarrior(19, true, 6, 0.4, 6, 6);
            }
        }

        public override Werewolf ProduceWerewolf(int stageNumber)
        {
            
            if(stageNumber ==1)
            {
                return new ForestWerewolf(13, true, 15, 0.4, 1, 1);
            }
            else if(stageNumber == 2)
            {
                return new ForestWerewolf(15, true, 17, 0.4, 2, 2);
            }
            else
            {
                return new ForestWerewolf(17, true, 19, 0.5, 3, 4);
            }
        }
    }
}

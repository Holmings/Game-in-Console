using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class SwampBoost: PlaceBoost
    {

        protected bool DoubleAttack(bool attack)
        {
            return attack;
        }

        public override Werewolf ProduceWerewolf(int stageNumber)
        {
            if(stageNumber == 1)
            {
                return new SwampWerewolf(15, true, 10, 0.2, false);
            }
            else if(stageNumber == 2)
            {
                return new SwampWerewolf(16, true, 15, 0.3, true);
            }
            else
            {
                return new SwampWerewolf(17, true, 15, 0.4, true);
            }
        }

        public override Drowner ProduceDrowner(int stageNumber)
        {
            if(stageNumber == 1)
            {
                return new SwampDrowner(10, true, 5, 0.1, false);
            }
            else if(stageNumber==2)
            {
                return new SwampDrowner(12, true, 3, 0.2, false);
            }
            else
            {
                return new SwampDrowner(15, true, 5, 0.4, true);
            }
        }

        public override Warrior ProduceWarrior(int stageNumber)
        {
            if(stageNumber==1)
            {
                return new SwampWarrior(15, true, 10, 0.1, false);
            }
            else if(stageNumber == 2)
            {
                return new SwampWarrior(18, true, 11, 0.3, true);
            }
            else
            {
                return new SwampWarrior(20, true, 12, 0.5, true);
            }
        }
    }
}

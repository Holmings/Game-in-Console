using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    abstract class PlaceBoost
    {
        public abstract Drowner ProduceDrowner(int stageNumber);
        public abstract Werewolf ProduceWerewolf(int stageNumber);
        public abstract Warrior ProduceWarrior(int stageNumber);
    }
}

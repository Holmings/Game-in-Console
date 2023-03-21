using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class Sword
    {
        protected string type;
        protected double power;
        public string SwordType
        {
            get { return type; }
            set { type = value; }
        }

        public double Power
        { 
            get { return power; }
            set { power = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Place
    {
        public bool PlaceofPower { get; set; }
        protected string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}

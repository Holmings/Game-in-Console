using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Journey journey = new Journey();
            menu.ShowMenu();
            journey.Go();
        }
    }
}
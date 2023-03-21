using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    internal class Menu
    {
        public void ShowMenu()
        {
            string text = File.ReadAllText("plik.txt");
            Console.WriteLine(text);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Players
    {
        int possition;
        public char sign;
        public string name;



        public Players(char sign, string name)
        {
            this.sign = sign;
            this.name = name;
        }


        public int getField(Players player)
        {
            do
            {
                Console.Write("\n\n{0} : Select a field number {1}  : ", name, sign);

                String possitionString = Console.ReadLine();
                try
                {
                    possition = int.Parse(possitionString);
                    possition--;
                }
                catch (Exception)
                {
                    
                }
            } while (possition < 0 || possition > 15 || Map.ArrayMap[possition] == 'X' || Map.ArrayMap[possition] == 'O');


            return possition;
        }



        public int getComputersField()
        {
            Random generate = new Random();
            int possition;

            do
            {
                possition = generate.Next(0, 15);

            } while (possition < 0 || possition > 15 || Map.ArrayMap[possition] == 'X' || Map.ArrayMap[possition] == 'O');


            return possition;
        }
    }
}

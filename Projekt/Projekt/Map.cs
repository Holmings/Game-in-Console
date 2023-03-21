using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Map
    {
        public static char[] ArrayMap;
        public string winner;

        public Map()
        {
            ArrayMap = new char[16];     // Tworzy tablicę 16-cio elementową

            for (int i = 0; i < 16; i++)
            {
                ArrayMap[i] = ' ';
            }
        }


        public void DrawMap()
        {
            Console.Write("\n\t\t\t\t\t\t\t\t\t1 2 3 4\n\n\t\t\t\t\t\t\t\t\t5 6 7 8\n\n\t\t\t\t\t\t\t\t\t9 10 11 12\n\n\t\t\t\t\t\t\t\t\t13 14 15 16\n");
            for (int i = 0; i < ArrayMap.Length; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("\n\t\t\t\t\t\t\t-----------------");
                    Console.Write("\n\t\t\t\t\t\t\t|");
                }
                Console.Write(" {0} |", ArrayMap[i]);
            }
            Console.Write("\n\t\t\t\t\t\t\t-----------------");
        }





        public void PutSign(int possition, Players player)
        {
            ArrayMap[possition] = player.sign;        // wpisuje znak do tablicy
        }



        public bool CheckResultGame(Players player)
        {
            if ((ArrayMap[0] == player.sign && ArrayMap[1] == player.sign && ArrayMap[2] == player.sign) ||
                (ArrayMap[1] == player.sign && ArrayMap[2] == player.sign && ArrayMap[3] == player.sign) ||
                (ArrayMap[4] == player.sign && ArrayMap[5] == player.sign && ArrayMap[6] == player.sign) ||
                (ArrayMap[5] == player.sign && ArrayMap[6] == player.sign && ArrayMap[7] == player.sign) ||
                (ArrayMap[8] == player.sign && ArrayMap[9] == player.sign && ArrayMap[10] == player.sign) ||
                (ArrayMap[9] == player.sign && ArrayMap[10] == player.sign && ArrayMap[11] == player.sign) ||
                (ArrayMap[12] == player.sign && ArrayMap[13] == player.sign && ArrayMap[14] == player.sign) ||
                (ArrayMap[13] == player.sign && ArrayMap[14] == player.sign && ArrayMap[15] == player.sign) ||

                (ArrayMap[0] == player.sign && ArrayMap[4] == player.sign && ArrayMap[8] == player.sign) ||
                (ArrayMap[4] == player.sign && ArrayMap[8] == player.sign && ArrayMap[12] == player.sign) ||
                (ArrayMap[1] == player.sign && ArrayMap[5] == player.sign && ArrayMap[9] == player.sign) ||
                (ArrayMap[5] == player.sign && ArrayMap[9] == player.sign && ArrayMap[13] == player.sign) ||
                (ArrayMap[2] == player.sign && ArrayMap[6] == player.sign && ArrayMap[10] == player.sign) ||
                (ArrayMap[6] == player.sign && ArrayMap[10] == player.sign && ArrayMap[14] == player.sign) ||
                (ArrayMap[3] == player.sign && ArrayMap[7] == player.sign && ArrayMap[11] == player.sign) ||
                (ArrayMap[7] == player.sign && ArrayMap[11] == player.sign && ArrayMap[15] == player.sign) ||

                (ArrayMap[0] == player.sign && ArrayMap[5] == player.sign && ArrayMap[10] == player.sign) ||
                (ArrayMap[1] == player.sign && ArrayMap[6] == player.sign && ArrayMap[11] == player.sign) ||
                (ArrayMap[4] == player.sign && ArrayMap[9] == player.sign && ArrayMap[14] == player.sign) ||
                (ArrayMap[5] == player.sign && ArrayMap[10] == player.sign && ArrayMap[15] == player.sign) ||
                (ArrayMap[2] == player.sign && ArrayMap[5] == player.sign && ArrayMap[8] == player.sign) ||
                (ArrayMap[3] == player.sign && ArrayMap[6] == player.sign && ArrayMap[9] == player.sign) ||
                (ArrayMap[6] == player.sign && ArrayMap[9] == player.sign && ArrayMap[12] == player.sign) ||
                (ArrayMap[7] == player.sign && ArrayMap[10] == player.sign && ArrayMap[13] == player.sign))
            {
                Console.Write("\n\nWinner: {0} (sign {1})\n\n", player.name, player.sign);
                if (player.name == "Witcher")
                {
                    Console.WriteLine("You received new skill");
                    Console.ReadKey();
                    Console.Clear();
                    winner = "Witcher";
                }
                else winner = "Villager";
                return true;
            }


            int counter = 0;


            for (int i = 0; i < ArrayMap.Length; i++)
            {


                if (ArrayMap[i] != ' ')
                {
                    counter++;
                }

                if (counter == 9)
                {
                    Console.Write("\n\ndraw!\n\n");
                    return true;
                }
            }

            return false;
        }

    }
}


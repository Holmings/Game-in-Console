using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    static class Game
    {
        //https://www.elektroda.pl/rtvforum/topic2679747.html
        static public void WithComputer(Villager skill, Witcher witcher)
        {
            int possition;
            Map map = new Map();
            Players player1 = new Players('X', "Witcher");
            Players computer = new Players('O', "Villager");
            Console.ReadKey();
            Console.Clear();
            map.DrawMap();

            do
            {
                possition = player1.getField(player1);
                map.PutSign(possition, player1);
                map.DrawMap();
                if (map.CheckResultGame(player1) == true)
                {
                    witcher.WitcherSkills[skill.SkillName] = true;
                    break;
                }
                Console.Clear();
                map.DrawMap();
                possition = computer.getComputersField();
                map.PutSign(possition, computer);
                Console.Clear();
                map.DrawMap();
            } while (!(map.CheckResultGame(computer)));

        }
    }
}

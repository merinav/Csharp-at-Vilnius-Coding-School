using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GameControl
{
    class GameController
    {
        internal void StartGame(int playerNo, int diceNo)
        {            
            int allPlayers = playerNo + 2;
            Random rnd = new Random();
            int dice;
            int result = 0;

            for (int i = 1; i < allPlayers + 1; i++)
            { 
                Console.WriteLine($"Player Number {i}:");

                for (int j = 1; j < diceNo+1; j++)
                    {
                    dice = rnd.Next(1, 7);
                    Console.WriteLine($"Dice Number {j}: {dice}");
                    result += dice;
                    }

                Console.WriteLine($"Player Number {i} RESULT: {result}");
                Console.WriteLine();
            }

            Console.WriteLine("Press Enter to continue");

            Console.ReadLine();
        }
    }
}

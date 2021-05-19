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
            int thisPlayerNo = playerNo;
            int thisDiceNo = diceNo;
            
            int allPlayers = playerNo + 2;
            Random rnd = new Random();
            int dice;
            int result = 0;
            int[] playerResultArray = new int[allPlayers];
            int maxResult;
            int maxResultIndex;

            for (int i = 1; i < allPlayers + 1; i++)
            { 
                Console.WriteLine($"Player Number {i}:");

                for (int j = 1; j < diceNo+1; j++)
                    {
                    dice = rnd.Next(1, 7);
                    Console.WriteLine($"Dice Number {j}: {dice}");
                    result += dice;
                    Console.ReadKey();
                }
                playerResultArray[i - 1] = result;
                result = 0;

                Console.WriteLine($"Player Number {i} RESULT: {playerResultArray[i - 1]}");
                Console.WriteLine();

            }

            maxResult = playerResultArray.Max();
            maxResultIndex = playerResultArray.ToList().IndexOf(maxResult);
            CheckResult(maxResult, maxResultIndex, playerResultArray, thisPlayerNo, thisDiceNo);
        }

        private void CheckResult(int maxResult, 
            int maxResultIndex, int[] playerResultArray, int thisPlayerNo, int thisDiceNo)
        {
            var matchedItems = from p in playerResultArray
                               where p == maxResult
                               select p;

            int[] matchedItemsArray = new int[] { };
            matchedItemsArray = matchedItems.ToArray();

            if (matchedItemsArray.Length == 1)
            {
                Console.WriteLine($"The winner is player No. {maxResultIndex + 1}" +
               $" with a winning result of {maxResult}!");

                Console.WriteLine("Press Enter to continue");

                Console.ReadLine();

            }
            else
            {
                Console.WriteLine($"There is more than one winner so we must" +
                    $" replay the game!");

                Console.WriteLine("Press Enter to continue");

                Console.ReadLine();

                StartGame(thisPlayerNo, thisDiceNo);
            }



            
        }
    }
}

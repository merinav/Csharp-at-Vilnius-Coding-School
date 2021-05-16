using LearningApp.DiceMenu.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GameControl
{
    class InputReader
    {
        private bool isGameRunning;
        //private WindowType currentActiveWindow;
        private WindowRenderer windowController = new WindowRenderer();


        public InputReader()
        {
            
        }

        public void StartHandlingInput() 
        {   





            isGameRunning = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();


                    switch (windowController.CurrentActiveWindow)
                    {
                        
                        case WindowType.MainMenu:

                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    Console.WriteLine("ENTER");
                                    break;
                                case ConsoleKey.LeftArrow:
                                    break;
                                case ConsoleKey.UpArrow:
                                    break;
                                case ConsoleKey.RightArrow:
                                    break;
                                case ConsoleKey.DownArrow:
                                    break;
                                case ConsoleKey.M:
                                    break;
                                case ConsoleKey.P:
                                    break;
                                case ConsoleKey.Q:
                                    break;
                                case ConsoleKey.R:
                                    break;
                                default:
                                    break;
                            }

                            break;
                        case WindowType.PlayerSelection:
                            
                        case WindowType.DiceSelection:
                            
                        case WindowType.Game:
                            
                        case WindowType.GameOver:
                            
                        case WindowType.None:
                            
                        default: throw new Exception("neapdorota");
                    }



                    



                }
            } while (isGameRunning);



        }

    }
}

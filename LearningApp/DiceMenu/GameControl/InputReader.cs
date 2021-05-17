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
        private WindowRenderer windowRenderer;
        private GameController gameController = new GameController();


        public InputReader(WindowRenderer windowControllerForIR)
        {
            this.windowRenderer = windowControllerForIR;
        }

        public void StartHandlingInput() 
        {
            int playerNo;
            int playerId = 0;
            int diceNo = 5;
            isGameRunning = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    switch (windowRenderer.CurrentActiveWindow)
                    {
                            //MAIN MENU
                        case WindowType.MainMenu:
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    if (windowRenderer.PlayButtonActive)
                                    {
                                        windowRenderer.ShowPlayerSelectionWindow();
                                    }
                                    else if (windowRenderer.QuitButtonActiveMainW)
                                    {
                                        isGameRunning = false;
                                        Console.Clear();
                                    }
                                    //butu gerai padaryt exception jei abu false
                                    break;
                                case ConsoleKey.P:
                                    windowRenderer.SetActivePlayButton(true);
                                    windowRenderer.SetActiveQuitButtonMainWindow(false);
                                    break;
                                case ConsoleKey.Q:
                                    windowRenderer.SetActivePlayButton(false);
                                    windowRenderer.SetActiveQuitButtonMainWindow(true);                     
                                    break; 
                                default:
                                    break;
                            }
                            break;

                            //PLAYER SELECTION
                        case WindowType.PlayerSelection:

                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    
                                    break;
                                case ConsoleKey.RightArrow:
                                    playerId++;
                                    windowRenderer.SetButtonActive(playerId);
                                    break;
                                case ConsoleKey.LeftArrow:
                                    
                                    break;
                                case ConsoleKey.UpArrow:
                                    
                                    break;
                                case ConsoleKey.DownArrow:
                                    
                                    break;
                                default:
                                    break;
                            }




                            break;
                            
                            //DICE SELECTION
                        case WindowType.DiceSelection:
                            switch (key.Key)
                            {                               
                                case ConsoleKey.Enter:
                                    Console.Clear();
                                    gameController.StartGame(diceNo);
                                    break;
                                case ConsoleKey.RightArrow:
                                    diceNo++;
                                    windowRenderer.SetDiceNumber(diceNo);
                                    break;
                                case ConsoleKey.LeftArrow:
                                    diceNo--;
                                    windowRenderer.SetDiceNumber(diceNo);
                                    break;
                                default:
                                    break;
                            }



                            break;
                            
                        //    //GAME
                        //case WindowType.Game:
                        //    break;


                            //GAME OVER
                        case WindowType.GameOver:
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    if (windowRenderer.ReplayButtonActive)
                                    {
                                        windowRenderer.ShowPlayerSelectionWindow();
                                    }
                                    else if (windowRenderer.MenuButtonActive)
                                    {
                                        windowRenderer.ShowMainWindow();                                       
                                    }
                                    else if (windowRenderer.QuitButtonActiveGameOverW)
                                    {
                                        isGameRunning = false;
                                        Console.Clear();
                                    }
                                    //butu gerai padaryt exception jei visi false
                                    break;
                                case ConsoleKey.R:
                                    windowRenderer.SetActiveReplayButton(true);
                                    windowRenderer.SetActiveMenuButton(false);
                                    windowRenderer.SetActiveQuitButtonGameOverWindow(false);
                                    break;
                                case ConsoleKey.M:
                                    windowRenderer.SetActiveReplayButton(false);
                                    windowRenderer.SetActiveMenuButton(true);
                                    windowRenderer.SetActiveQuitButtonGameOverWindow(false);
                                    break;
                                case ConsoleKey.Q:
                                    windowRenderer.SetActiveReplayButton(false);
                                    windowRenderer.SetActiveMenuButton(false);
                                    windowRenderer.SetActiveQuitButtonGameOverWindow(true);
                                    break;
                                default:
                                    break;
                            } break;

                        case WindowType.None:
                            
                        default: throw new Exception("neapdorota");
                    }



                    //switch (key.Key)
                    //{
                    //    case ConsoleKey.Enter:
                    //        Console.WriteLine("ENTER");
                    //        break;
                    //    case ConsoleKey.LeftArrow:
                    //        break;
                    //    case ConsoleKey.UpArrow:
                    //        break;
                    //    case ConsoleKey.RightArrow:
                    //        break;
                    //    case ConsoleKey.DownArrow:
                    //        break;
                    //    case ConsoleKey.M:
                    //        break;
                    //    case ConsoleKey.P:
                    //        break;
                    //    case ConsoleKey.Q:
                    //        break;
                    //    case ConsoleKey.R:
                    //        break;
                    //    default:
                    //        break;
                    //}



                }
            } while (isGameRunning);



        }

    }
}

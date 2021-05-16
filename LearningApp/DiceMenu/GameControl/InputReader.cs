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
        private WindowRenderer windowControllerForIR;


        public InputReader(WindowRenderer windowControllerForIR)
        {
            this.windowControllerForIR = windowControllerForIR;
        }

        public void StartHandlingInput() 
        {


            isGameRunning = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();

                    switch (windowControllerForIR.CurrentActiveWindow)
                    {
                        case WindowType.MainMenu:
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    if (windowControllerForIR.PlayButtonActive)
                                    {
                                        windowControllerForIR.ShowPlayerSelectionWindow();
                                    }
                                    else if (windowControllerForIR.QuitButtonActiveMainW)
                                    {
                                        isGameRunning = false;
                                        Console.Clear();
                                    }
                                    //butu gerai padaryt exception jei abu false
                                    break;
                                case ConsoleKey.P:
                                    windowControllerForIR.SetActivePlayButton(true);
                                    windowControllerForIR.SetActiveQuitButtonMainWindow(false);
                                    break;
                                case ConsoleKey.Q:
                                    windowControllerForIR.SetActivePlayButton(false);
                                    windowControllerForIR.SetActiveQuitButtonMainWindow(true);                     
                                    break; 
                                default:
                                    break;
                            }
                            break;
                        case WindowType.PlayerSelection:
                            
                        case WindowType.DiceSelection:
                            
                        case WindowType.Game:
                            
                        case WindowType.GameOver:
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    if (windowControllerForIR.ReplayButtonActive)
                                    {
                                        windowControllerForIR.ShowPlayerSelectionWindow();
                                    }
                                    else if (windowControllerForIR.MenuButtonActive)
                                    {
                                        windowControllerForIR.ShowMainWindow();                                       
                                    }
                                    else if (windowControllerForIR.QuitButtonActiveGameOverW)
                                    {
                                        isGameRunning = false;
                                        Console.Clear();
                                    }
                                    //butu gerai padaryt exception jei visi false
                                    break;
                                case ConsoleKey.R:
                                    windowControllerForIR.SetActiveReplayButton(true);
                                    windowControllerForIR.SetActiveMenuButton(false);
                                    windowControllerForIR.SetActiveQuitButtonGameOverWindow(false);
                                    break;
                                case ConsoleKey.M:
                                    windowControllerForIR.SetActiveReplayButton(false);
                                    windowControllerForIR.SetActiveMenuButton(true);
                                    windowControllerForIR.SetActiveQuitButtonGameOverWindow(false);
                                    break;
                                case ConsoleKey.Q:
                                    windowControllerForIR.SetActiveReplayButton(false);
                                    windowControllerForIR.SetActiveMenuButton(false);
                                    windowControllerForIR.SetActiveQuitButtonGameOverWindow(true);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.ToDoList.Controllers
{
    class InputReader
    {

        private WindowController windowController;

        public InputReader()
        {
            windowController = new WindowController();
        }

        public void StartHandlingInput()
        {
            windowController.CurrentActiveWindow = Constants.WindowType.StartWindow;
            bool running = true;
            do
            {
                while (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    
                    switch (windowController.CurrentActiveWindow)
                    {
                        case Constants.WindowType.StartWindow:
                            
                             switch (key.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                    windowController.SetAddItemButtonStart(true);
                                    break;                                
                                case ConsoleKey.RightArrow:
                                    windowController.SetAddItemButtonStart(false);
                                    break;
                                case ConsoleKey.Enter:
                                    if (windowController.AddItemButtonActive)
                                    {
                                        Console.Clear();
                                        windowController.ShowAddItemWindow();
                                    }
                                    else if (windowController.ShowAllButtonActive)
                                    {
                                        Console.Clear();
                                        windowController.ShowShowAllWindow();
                                    }
                                    break;
                                case ConsoleKey.Escape:
                                    Console.Clear();
                                    running = false;
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case Constants.WindowType.AddItemWindow:

                            windowController.CollectData(Convert.ToString(Console.Read()));
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    Console.Clear();
                                    windowController.ShowShowAllWindow();
                                    break;
                                case ConsoleKey.Escape:
                                    Console.Clear();
                                    running = false;
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case Constants.WindowType.ShowAllItemsWindow:

                            windowController.DisplayItems();
                            switch (key.Key)
                            {
                                case ConsoleKey.LeftArrow:
                                    windowController.SetAddItemsButtonShowAll(true);
                                    break;
                                case ConsoleKey.RightArrow:
                                    windowController.SetAddItemsButtonShowAll(false);
                                    break;
                                case ConsoleKey.Enter:
                                    if (windowController.AddItemButtonActive)
                                    {
                                        Console.Clear();
                                        windowController.ShowAddItemWindow();
                                    }
                                    else if (windowController.GoToMainButtonActive)
                                    {
                                        Console.Clear();
                                        windowController.ShowStartWindow();
                                    }
                                    break;
                                case ConsoleKey.Escape:
                                    Console.Clear();
                                    running = false;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            } while (running);




        }


    }
}

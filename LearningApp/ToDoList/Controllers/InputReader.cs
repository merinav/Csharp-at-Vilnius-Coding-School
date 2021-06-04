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
                                default:
                                    break;
                            }
                            break;
                            break;

                        case Constants.WindowType.AddItemWindow:
                            switch (key.Key)
                            {
                                case ConsoleKey.Enter:
                                    windowController.ShowShowAllWindow();
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case Constants.WindowType.ShowAllItemsWindow:

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
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }

                }
            } while (true);




        }


    }
}

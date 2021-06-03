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
                                    windowController.SetNotActiveStartWindowButton(1);
                                    windowController.SetActiveStartWindowButton(0);
                                    break;
                                
                                case ConsoleKey.RightArrow:
                                    windowController.SetNotActiveStartWindowButton(0);
                                    windowController.SetActiveStartWindowButton(1);
                                    break;

                                case ConsoleKey.Enter:
                                    if (windowController.AddItemButtonActive)
                                    {
                                        windowController.ShowAddItemWindow();
                                    }
                                    else if (windowController.ShowAllButtonActive)
                                    {
                                        windowController.ShowShowAllWindow();
                                    }
                                    break;


                                default:
                                    break;
                            }
                            break;
                        case Constants.WindowType.AddItemWindow:
                            break;
                        case Constants.WindowType.ShowAllItemsWindow:
                            break;
                        default:
                            break;
                    }

                }
            } while (true);




        }


    }
}

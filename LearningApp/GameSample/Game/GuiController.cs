using LearningApp.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.GameSample.Game
{
    class GuiController
    {
        private CreditWindow creditWindow;
        private MenuWindow menuWindow;
        private EndGameWindow endWindow;
        private GameController gameController = new GameController();


        public GuiController() {
            creditWindow = new CreditWindow();
            menuWindow = new MenuWindow();
            endWindow = new EndGameWindow();
        }

        public void ShowMenu() 
        {
            menuWindow.Render();
        }
        public void ShowCreditWindow()
        {
            creditWindow.Render();
        }

        public void ReadKeyboardInput() 
        {
            bool programRunning = true;
            
            while (programRunning)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    menuWindow.UserMoveLeft();
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    menuWindow.UserMoveRight();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (menuWindow.ReturnStartButtonValue() == true)
                    {
                        Console.Clear();
                        gameController.StartGame();
                    }
                    else if (menuWindow.ReturCreditsButtonValue() == true)
                    {
                        creditWindow.Render();
                    }
                    else if (menuWindow.ReturnQuitButtonValue() == true)
                    {
                        Console.Clear();
                        endWindow.Render();
                    }
                }
            }
            
            


            
            
        



        }


    }
}

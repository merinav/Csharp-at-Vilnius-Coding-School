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
            bool gameRunning = false;
            bool creditWindowShowing = false;
            
            while (programRunning)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                //LeftArrow
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    menuWindow.UserMoveLeft();
                }
                //RightArrow
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    menuWindow.UserMoveRight();
                }
                //Enter
                else if (key.Key == ConsoleKey.Enter)
                {
                    if (menuWindow.ReturnStartButtonValue() == true)
                    {
                        Console.Clear();
                        gameRunning = true;
                        gameController.StartGame();
                    }
                    else if (menuWindow.ReturCreditsButtonValue() == true)
                    {
                        creditWindow.Render();
                        creditWindowShowing = true;
                        Console.ReadLine();
                        ShowMenu();
                        ReadKeyboardInput();
                    }
                    else if (menuWindow.ReturnQuitButtonValue() == true)
                    {
                        Console.Clear();
                        endWindow.Render();
                        Console.ReadLine();
                        Console.Clear();
                        programRunning = false;
                    }
                }
                //Escape
                else if (key.Key == ConsoleKey.Escape)
                {
                    if (gameRunning)
                    {
                        Console.Clear();
                        ShowMenu();
                        ReadKeyboardInput();
                    }
                    else if (creditWindowShowing)
                    {
                        Console.Clear();
                        ShowMenu();
                        ReadKeyboardInput();
                    }
                }

            }
            
            


            
            
        



        }


    }
}

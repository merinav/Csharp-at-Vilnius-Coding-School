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


        public GuiController() {
            creditWindow = new CreditWindow();
            menuWindow = new MenuWindow();        
        }

        public void ShowMenu() 
        {
            menuWindow.Render();
        }
        public void ShowCreditWindow()
        {
            creditWindow.Render();
        }

        public void CreateGameController() 
        {
            GameController gameController = new GameController();
        }

        public void ReadKeyboardInput() 
        {
            bool programRunning = true;
            while (programRunning)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow
                    || key.Key == ConsoleKey.LeftArrow
                    || key.Key == ConsoleKey.Enter)
                {
                    menuWindow.ImplementKeyboardInput(key);
                }
            }
            
            


            
            
        



        }


    }
}

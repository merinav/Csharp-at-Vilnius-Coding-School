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

       public void testPrinting() 
        {
            menuWindow.OnlyQuitButtonActive();

            Console.ReadLine();
            menuWindow.OnlyCreditsButtonActive(); 

            Console.ReadLine();
            menuWindow.OnlyStartButtonActive();

        }



        public void testInput() 
        {

            int activeButton = 0;
            var consoleInput = Console.ReadKey(false).Key;

            
            while (consoleInput == ConsoleKey.RightArrow)
            {
                for (int i = 0; i < 2; i++)
                {
                    menuWindow.ActivateButton(0);
                    activeButton++;
                }
                break;
            }

            //while (consoleInput == ConsoleKey.LeftArrow)
            //{
            //    for (int i = 0; i < 2; i++)
            //    {
            //        menuWindow.ActivateButton(0);
            //        activeButton++;
            //    }
            //    break;
  

        }


    }
}

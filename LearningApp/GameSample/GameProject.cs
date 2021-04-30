using LearningApp.GameSample.Game;
using LearningApp.GameSample.GUI;
using LearningApp.GameSample.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LearningApp.GameSample
{
    class GameProject
    {
        static void Main()
        {
            //MenuWindow gameWindow = new MenuWindow();
            //gameWindow.Render();

            //CreditWindow creditWindow = new CreditWindow();
            //creditWindow.Render();

            Console.CursorVisible = false;
           
            GuiController guiController = new GuiController();
            guiController.ShowMenu();
            guiController.ShowCreditWindow();

            Console.ReadKey();

            
            
        }
    }
}

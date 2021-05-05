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
        static void MainGP()
        {
           
            Console.CursorVisible = false;
           
            GuiController guiController = new GuiController();
            guiController.ShowMenu();

            //guiController.testPrinting();

            guiController.ReadKeyboardInput();

            Console.ReadKey();

        }
    }
}

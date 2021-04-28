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
            //GameController gameController = new GameController();
            //gameController.StartGame();

            Console.CursorVisible = false;

            MenuWindow gameWindow = new MenuWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();

            Console.ReadKey();
        }
    }
}

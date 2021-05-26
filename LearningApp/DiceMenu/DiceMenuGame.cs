using LearningApp.DiceMenu.GameControl;
using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu
{
    class DiceMenuGame
    {
        static void MainDM() 
        {
            //GameController gameController = new GameController();
            //gameController.StartGame();

            WindowRenderer windowController = new WindowRenderer();
            InputReader inputReader = new InputReader(windowController);

            windowController.ShowMainWindow();
            inputReader.StartHandlingInput();

        }
    }
}

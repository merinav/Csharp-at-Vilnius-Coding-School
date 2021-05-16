using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GameControl
{
    class GameController
    {
        WindowRenderer windowController = new WindowRenderer();
        InputReader inputReader = new InputReader();
        
        public void StartGame() 
        {
            windowController.ShowMainWindow();
            inputReader.StartHandlingInput(); 
        }

    }
}

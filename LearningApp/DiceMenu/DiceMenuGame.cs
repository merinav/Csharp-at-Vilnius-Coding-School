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
        static void Main() 
        {

            WindowRenderer windowController = new WindowRenderer();
            //windowController.ShowMainWindow();

            windowController.ShowPlayerSelectionWindow();

        }
    }
}

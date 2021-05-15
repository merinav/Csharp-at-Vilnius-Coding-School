using LearningApp.DiceMenu.GUI;
using LearningApp.DiceMenu.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GameControl
{
    
    /// <summary>
    /// Controlls which window to show
    /// </summary>

    class WindowRenderer
    {
        //private fields
       
        private MainWindow mainWindow;
        private PlayerSelectionWindow playerSelectionWindow;

        //constructor
        public WindowRenderer()
        {
            mainWindow = new MainWindow();
            playerSelectionWindow = new PlayerSelectionWindow();
        }

        internal void ShowPlayerSelectionWindow()
        {
            playerSelectionWindow.Render();
        }

        //methods
        public void ShowMainWindow()
        {
            mainWindow.Render();
        }
        
    }
}

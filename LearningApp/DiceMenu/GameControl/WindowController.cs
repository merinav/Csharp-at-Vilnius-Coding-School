using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.GameControl
{
    
    ///
    /// will control windows
    ///

    class WindowController
    {
        //private fields
       
        private MainWindow mainWindow;
        

        //constructor
        public WindowController()
        {
            mainWindow = new MainWindow();
            
        }
        //methods
        public void ShowMainWindow()
        {
            mainWindow.Render();
        }
        
    }
}

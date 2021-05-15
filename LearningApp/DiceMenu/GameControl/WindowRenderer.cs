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
        private DiceSelectionWindow diceSelectionWindow;
        private GameWindow gameWindow;
        private GameOverWindow gameOverWindow;

        //constructor
        public WindowRenderer()
        {
            mainWindow = new MainWindow();
            playerSelectionWindow = new PlayerSelectionWindow();
            diceSelectionWindow = new DiceSelectionWindow();
            gameWindow = new GameWindow();
            gameOverWindow = new GameOverWindow();
        }

        public void ShowPlayerSelectionWindow()
        {
            playerSelectionWindow.Render();
        }

        //methods
        public void ShowMainWindow()
        {
            mainWindow.Render();
        }

        public void ShowDiceSelectionWindow()
        {
            diceSelectionWindow.Render();
        }

        public void ShowGameWindow()
        {
            gameWindow.Render();
        }

        public void ShowGameOverWindow()
        {
            gameOverWindow.Render();
        }
    }
}

using LearningApp.DiceMenu.Constants;
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
        //private WindowType currentActiveWindow;


        //constructor
        public WindowRenderer()
        {
            mainWindow = new MainWindow();
            playerSelectionWindow = new PlayerSelectionWindow();
            diceSelectionWindow = new DiceSelectionWindow();
            gameWindow = new GameWindow();
            gameOverWindow = new GameOverWindow();
        }

        public WindowType CurrentActiveWindow { get; set; }

        
        //methods
        public void ShowMainWindow()
        {
            CurrentActiveWindow = WindowType.MainMenu;
            mainWindow.Render();
        }

        public void ShowPlayerSelectionWindow()
        {
            CurrentActiveWindow = WindowType.PlayerSelection;
            playerSelectionWindow.Render();
        }


        public void ShowDiceSelectionWindow()
        {
            CurrentActiveWindow = WindowType.DiceSelection;
            diceSelectionWindow.Render();
        }

        public void ShowGameWindow()
        {
            CurrentActiveWindow = WindowType.Game;
            gameWindow.Render();
        }

        public void ShowGameOverWindow()
        {
            CurrentActiveWindow = WindowType.GameOver;
            gameOverWindow.Render();
        }
    }
}

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
        private GameOverWindow gameOverWindow;
        //private WindowType currentActiveWindow;


        //constructor
        public WindowRenderer()
        {
            mainWindow = new MainWindow();
            playerSelectionWindow = new PlayerSelectionWindow();
            diceSelectionWindow = new DiceSelectionWindow();
            gameOverWindow = new GameOverWindow();
        }

        public WindowType CurrentActiveWindow { get; set; }
        public bool PlayButtonActive { get; set; }
        public bool QuitButtonActiveMainW { get; set; }
        public bool ReplayButtonActive { get; set; }
        public bool MenuButtonActive { get; set; }
        public bool QuitButtonActiveGameOverW { get; set; }


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

        public void ShowGameOverWindow()
        {
            CurrentActiveWindow = WindowType.GameOver;
            gameOverWindow.Render();
        }

        public void SetActivePlayButton(bool set) 
        {
            if (set)
            {
                mainWindow.PlayButton.SetActive();
                PlayButtonActive = true;
            }
            else
            {
                mainWindow.PlayButton.SetNotActive();
                PlayButtonActive = false;
            }
        }

        public void SetActiveQuitButtonMainWindow(bool set)
        {
            if (set)
            {
                mainWindow.QuitButton.SetActive();
                QuitButtonActiveMainW = true;
            }
            else
            {
                mainWindow.QuitButton.SetNotActive();
                QuitButtonActiveMainW = false;
            }
        }

        public void SetActiveReplayButton(bool set)
        {
            if (set)
            {
                gameOverWindow.ReplayButton.SetActive();
                ReplayButtonActive = true;
            }
            else
            {
                gameOverWindow.ReplayButton.SetNotActive();
                ReplayButtonActive = false;
            }
        }

        public void SetActiveMenuButton(bool set)
        {
            if (set)
            {
                gameOverWindow.MenuButton.SetActive();
                MenuButtonActive = true;
            }
            else
            {
                gameOverWindow.MenuButton.SetNotActive();
                MenuButtonActive = false;
            }
        }

        public void SetActiveQuitButtonGameOverWindow(bool set)
        {
            if (set)
            {
                gameOverWindow.QuitButton.SetActive();
                QuitButtonActiveGameOverW = true;
            }
            else
            {
                gameOverWindow.QuitButton.SetNotActive();
                QuitButtonActiveGameOverW = false;
            }
        }

        public void SetDiceNumber(int number)
        {
            string strNumber = number.ToString();
            diceSelectionWindow.DiceButton = new Button(50, 13, 18, 5, strNumber);
            diceSelectionWindow.Render();
        }

        public void SetButtonActive(int id)
        {
            Button playerButton =  playerSelectionWindow.PlayerButtonList[id];
            playerButton.SetActive();
        }


    }
}

using LearningApp.DiceMenu.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningApp.DiceMenu.Windows
{
    class GameOverWindow : Window
    {

        //private fields
        private TextBlock titleTextBlock;

        //constructor
        public GameOverWindow() : base(0, 0, 120, 30, "", '%')
        {
            titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "THIS IS YOUR GAME OF DICE",
                "Do you want to play or quit?",
                "Choose by clicking P or Q on your keyboard"});

            ReplayButton = new Button(30, 13, 18, 5, "Replay Game");
            //StartButton.SetActive();

            MenuButton = new Button(50, 13, 18, 5, "Got to Menu");

            QuitButton = new Button(70, 13, 18, 5, "Quit");

            List<Button> ButtonList = new List<Button> { ReplayButton, QuitButton };
        }
        //properties
        public Button ReplayButton { get; set; }
        public Button QuitButton { get; set; }

        public Button MenuButton { get; set; }
        public List<Button> ButtonList { get; set; }

        //methods
        public override void Render()
        {
            base.Render();

            titleTextBlock.Render();

            ReplayButton.Render();
            MenuButton.Render();
            QuitButton.Render();

            Console.SetCursorPosition(0, 0);
        }

        public void SetActive(Button button)
        {
            button.SetActive();
        }

        public void SetNotActive(Button button)
        {
            button.SetNotActive();
        }
    }
}
